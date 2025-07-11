using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace NkbWork
{
    public partial class CandidateAdd : Form
    {
        public CandidateAdd()
        {
            InitializeComponent();
        }

        private void CandiateAdd_Load(object sender, EventArgs e)
        {
            //LoadCombo();
        }
        private void LoadCombo()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM JobPositions", con))
                {
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    cmbSub.DataSource = ds.Tables[0];
                    cmbSub.DisplayMember = "Name";
                    cmbSub.ValueMember = "Id";
                }
            }
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString))
            {
                Image img = Image.FromFile(txtPicturePath.Text);
                MemoryStream ms = new MemoryStream();
                img.Save(ms, ImageFormat.Bmp);

                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO Candidates(CandidateId,CandidateName,CandidateContact,CandidateEmail,Picture,JobPositionId) VALUES(@i,@n,@c,@e,@p,@s)";
                cmd.Parameters.AddWithValue("@i", txtId.Text);
                cmd.Parameters.AddWithValue("@n", txtName.Text);
                cmd.Parameters.AddWithValue("@c", txtContact.Text);
                cmd.Parameters.AddWithValue("@e", txtEmail.Text);
                cmd.Parameters.Add(new SqlParameter("@p", SqlDbType.VarBinary) { Value = ms.ToArray() });
                cmd.Parameters.AddWithValue("@s", cmbSub.SelectedValue);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Data Inserted Successfully!!!");
                    ClearAll();
                }
                con.Close();
            }

        }

        private void ClearAll()
        {
            txtId.Clear();
            txtName.Clear();
            txtContact.Clear();
            txtEmail.Clear();
            txtPicturePath.Clear();
            cmbSub.SelectedIndex = -1;
            pictureBox1.Image = null;
        }

        private void btnPicture_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(openFileDialog1.FileName);
                this.pictureBox1.Image = img;
                txtPicturePath.Text = openFileDialog1.FileName;
            }
        }

        private void CandidateAdd_Load(object sender, EventArgs e)
        {
            LoadCombo();
        }
    }
}
