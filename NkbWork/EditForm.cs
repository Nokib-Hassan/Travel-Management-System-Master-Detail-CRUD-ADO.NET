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
    public partial class EditForm : Form
    {
        string currentFile = string.Empty;
        List<Details> details = new List<Details>();
        string oldFile = "";
        public EditForm()
        {
            InitializeComponent();

        }
        public VisitorsEdit TheForm { get; set; }
        public int IdToEdit { get; set; }

        private void btnBrowse_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                currentFile = openFileDialog1.FileName;
                pictureBox1.Image = Image.FromFile(currentFile);
            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
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

        private void EditForm_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            LoadInForm();
        }

        private void LoadInForm()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Visitors WHERE VisitorID=@i", con))
                {
                    cmd.Parameters.AddWithValue("@i", IdToEdit);
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        txtFirstName.Text = dr.GetString(1);
                        txtLastName.Text = dr.GetString(2);
                        dptDob.Value = dr.GetDateTime(3).Date;
                        txtAge.Text = dr.GetInt32(4).ToString();
                        txtGender.Text = dr.GetString(5);
                        txtAddress.Text = dr.GetString(6);
                        txtContact.Text = dr.GetString(7).ToString();
                        txtEmail.Text = dr.GetString(8);
                        checkBox1.Checked = dr.GetBoolean(9);
                        pictureBox1.Image = Image.FromFile(@"..\..\Pictures\" + dr.GetString(10));
                        oldFile = dr.GetString(10);
                    }
                    dr.Close();

                    cmd.CommandText = "SELECT * FROM Details WHERE VisitorID=@i";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@i", IdToEdit);
                    SqlDataReader dr2 = cmd.ExecuteReader();
                    while (dr2.Read())
                    {
                        details.Add(new Details
                        {
                            DestinationPlace = dr2.GetString(1),
                            VisitDate = dr2.GetDateTime(2).Date,
                            ReturnDate = dr2.GetDateTime(3).Date,
                            Cost = dr2.GetDecimal(4)
                        });
                    }
                    SetDataSource();
                    con.Close();
                }
            }
        }

        private void SetDataSource()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = details;
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                details.RemoveAt(e.RowIndex);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = details;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentFile))
            {
                MessageBox.Show("Please select an image file first.");
                return;
            }

            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString))
            {
                con.Open();
                using (SqlTransaction trx = con.BeginTransaction())
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = con;
                        cmd.Transaction = trx;

                        string f = oldFile;

                        if (!string.IsNullOrEmpty(currentFile))
                        {
                            string ext = Path.GetExtension(currentFile);
                            f = Path.GetFileNameWithoutExtension(DateTime.Now.Ticks.ToString()) + ext;  

                            string saveDir = Path.Combine(Application.StartupPath, @"..\..\Pictures");
                            if (!Directory.Exists(saveDir))
                            {
                                Directory.CreateDirectory(saveDir);  
                            }

                            string savePath = Path.Combine(saveDir, f);

                            try
                            {

                                File.Copy(currentFile, savePath, true);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error saving the image: " + ex.Message);
                                return;
                            }
                        }

                        cmd.CommandText = @"UPDATE Visitors SET FirstName=@fn, LastName=@ln, DateOfBirth=@dob, Age=@age, Gender=@gender, Address=@address, Contact=@contact, Email=@email, IsActive=@isd, Picture=@pic WHERE VisitorID=@id";

                        cmd.Parameters.AddWithValue("@id", IdToEdit);
                        cmd.Parameters.AddWithValue("@fn", txtFirstName.Text);
                        cmd.Parameters.AddWithValue("@ln", txtLastName.Text);
                        cmd.Parameters.AddWithValue("@dob", dptDob.Value);
                        cmd.Parameters.AddWithValue("@age", int.Parse(txtAge.Text));
                        cmd.Parameters.AddWithValue("@gender", txtGender.Text);
                        cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                        cmd.Parameters.AddWithValue("@contact", txtContact.Text);
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@isd", checkBox1.Checked);
                        cmd.Parameters.AddWithValue("@pic", f);

                        try
                        {
                            cmd.ExecuteNonQuery();
                            cmd.CommandText = "DELETE FROM Details WHERE VisitorID=@id";
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@id", IdToEdit);
                            cmd.ExecuteNonQuery();

                            foreach (var s in details)
                            {
                                cmd.CommandText = @"INSERT INTO Details(DestinationPlace, VisitDate, ReturnDate, Cost, VisitorID) 
                      VALUES(@cn, @sd, @ed, @cf, @i)";
                                cmd.Parameters.Clear();
                                cmd.Parameters.AddWithValue("@cn", s.DestinationPlace);
                                cmd.Parameters.AddWithValue("@sd", s.VisitDate);
                                cmd.Parameters.AddWithValue("@ed", s.ReturnDate);
                                cmd.Parameters.AddWithValue("@cf", s.Cost);
                                cmd.Parameters.AddWithValue("@i", IdToEdit);
                                cmd.ExecuteNonQuery();
                            }

                            trx.Commit();
                            MessageBox.Show("Data Updated successfully!!");
                            TheForm.LoadDataBindingSource();
                            
                            details.Clear();
                        }
                        catch (Exception ex)
                        {
                            trx.Rollback();
                            MessageBox.Show("An error occurred while updating data: " + ex.Message);
                        }
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString))
            {
                con.Open();
                using (SqlTransaction trx = con.BeginTransaction())
                {
                    string sql = @"DELETE FROM Details WHERE VisitorID=@id";
                    using (SqlCommand cmd = new SqlCommand(sql, con, trx))
                    {
                        cmd.Parameters.AddWithValue("@id", IdToEdit);
                        try
                        {
                            cmd.ExecuteNonQuery();
                            cmd.Parameters.Clear();
                            cmd.CommandText = "DELETE FROM Visitors WHERE VisitorID=@id";
                            cmd.Parameters.AddWithValue("@id", IdToEdit);
                            cmd.ExecuteNonQuery();
                            trx.Commit();
                            TheForm.LoadDataBindingSource();
                            MessageBox.Show("Data Deleted successfully!!");
                            details.Clear();
                            this.Close();
                        }
                        catch (Exception)
                        {
                            trx.Rollback();
                            MessageBox.Show("Failed to delete data!!");
                        }
                        con.Close();
                    }
                }

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
