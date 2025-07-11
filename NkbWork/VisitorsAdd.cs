using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NkbWork
{
    public partial class VisitorsAdd : Form
    {
        string currentFile = string.Empty;
        List<Details> details = new List<Details>();

        public VisitorsAdd()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                currentFile = openFileDialog1.FileName;
                pictureBox1.Image = Image.FromFile(currentFile);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            details.Add(new Details
            {
                DestinationPlace = txtDestinationPlace.Text,
                VisitDate = dptVisitDate.Value,
                ReturnDate = dptReturnDate.Value,
                Cost = numericUpDownCost.Value
            });
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = details;
        }

        private void btnSaveAll_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString))
            {
                con.Open();
                using (SqlTransaction trx = con.BeginTransaction())
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = con;
                        cmd.Transaction = trx;

                        string ext = Path.GetExtension(currentFile);
                        string f = Path.GetFileNameWithoutExtension(DateTime.Now.Ticks.ToString()) + ext;

                        string savePath = @"..\..\Pictures\" + f;
                        MemoryStream ms = new MemoryStream(File.ReadAllBytes(currentFile));
                        byte[] bytes = ms.ToArray();
                        FileStream fs = new FileStream(savePath, FileMode.Create);
                        fs.Write(bytes, 0, bytes.Length);
                        fs.Close();
                        cmd.CommandText = @"
                            INSERT INTO Visitors (FirstName, LastName, DateOfBirth, Age, Gender, Address, Contact, Email, IsActive, Picture) 
                            VALUES (@fn, @ln, @dob, @age, @gender, @address, @contact, @email, @isd, @pic); 
                            SELECT SCOPE_IDENTITY()";

                        cmd.Parameters.AddWithValue("@fn", txtFirstName.Text);
                        cmd.Parameters.AddWithValue("@ln", txtLastName.Text);
                        cmd.Parameters.AddWithValue("@dob", dptDob.Value);
                        cmd.Parameters.AddWithValue("@age", txtAge.Text);
                        cmd.Parameters.AddWithValue("@gender", txtGender.Text);
                        cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                        cmd.Parameters.AddWithValue("@contact", txtContact.Text);
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@isd", checkBox1.Checked);
                        cmd.Parameters.AddWithValue("@pic", f);

                        try
                        {
                            var empId = cmd.ExecuteScalar();
                            foreach (var dept in details)
                            {   cmd.CommandText = @"INSERT INTO Details(DestinationPlace, VisitDate, ReturnDate, Cost, VisitorID) VALUES(@dn, @jd, @sd, @sal, @empId)";
                                cmd.Parameters.Clear();
                                cmd.Parameters.AddWithValue("@dn", dept.DestinationPlace);
                                cmd.Parameters.AddWithValue("@jd", dept.VisitDate);
                                cmd.Parameters.AddWithValue("@sd", dept.ReturnDate);
                                cmd.Parameters.AddWithValue("@sal", dept.Cost);
                                cmd.Parameters.AddWithValue("@empId", empId);
                                cmd.ExecuteNonQuery();
                            }

                            trx.Commit();
                            MessageBox.Show("Data Saved successfully!!");
                            details.Clear();
                        }
                        catch (Exception ex)
                        {
                            trx.Rollback(); // Rollback the transaction if there is an error
                            MessageBox.Show($"Error while saving the data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                con.Close();
            }
        }
    }
}
