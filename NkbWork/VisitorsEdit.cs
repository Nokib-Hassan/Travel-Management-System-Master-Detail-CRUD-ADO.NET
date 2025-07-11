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
    public partial class VisitorsEdit : Form
    {
        BindingSource bsS = new BindingSource();
        BindingSource bsC = new BindingSource();
        DataSet ds = new DataSet();
        public VisitorsEdit()
        {
            InitializeComponent();
        }

        public void LoadDataBindingSource()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Visitors", con))
                {
                    ds = new DataSet();
                    sda.Fill(ds, "Visitors");
                    sda.SelectCommand.CommandText = "SELECT * FROM Details";
                    sda.Fill(ds, "Details");

                    ds.Tables["Visitors"].Columns.Add(new DataColumn("image", typeof(byte[])));
                    for (int i = 0; i < ds.Tables["Visitors"].Rows.Count; i++)
                    {
                     ds.Tables["Visitors"].Rows[i]["image"] = File.ReadAllBytes($@"..\..\Pictures\{ds.Tables["Visitors"].Rows[i]["picture"]}");
                    }

                    // Relationship between Visitors and Details table

                    DataRelation rel = new DataRelation("FK_S_C", ds.Tables["Visitors"].Columns["VisitorID"], ds.Tables["Details"].Columns["VisitorID"]);
                    ds.Relations.Add(rel);
                    bsS.DataSource = ds;

                    // Set the binding sources
                    bsS.DataMember = "Visitors";

                    bsC.DataSource = bsS;
                    bsC.DataMember = "FK_S_C";
                    dataGridView1.DataSource = bsC;
                    AddDataBindings();

                }
            }
        }

        private void AddDataBindings()
        {
            lblId.DataBindings.Clear();
            lblId.DataBindings.Add("Text", bsS, "VisitorID");
            lblName.DataBindings.Clear();
            lblName1.DataBindings.Add("Text", bsS, "FirstName");

            lblName.DataBindings.Clear();
            lblName.DataBindings.Add("Text", bsS, "LastName");

            txtAge.DataBindings.Clear();
            txtAge.DataBindings.Add("Text", bsS, "DateOfBirth");
            Binding bm = new Binding("Text", bsS, "DateOfBirth", true);
            bm.Format += Bm_Format;
            txtAge.DataBindings.Clear();
            txtAge.DataBindings.Add(bm);

            pictureBox1.DataBindings.Clear();
            pictureBox1.DataBindings.Add(new Binding("Image", bsS, "image", true));

            checkBox1.DataBindings.Clear();
            checkBox1.DataBindings.Add("Checked", bsS, "IsActive", true);

            txtGender.DataBindings.Clear();
            txtGender.DataBindings.Add("Text", bsS, "Gender", true);

            txtAddress.DataBindings.Clear();
            txtAddress.DataBindings.Add("Text", bsS, "Address", true);

            txtContact.DataBindings.Clear();
            txtContact.DataBindings.Add("Text", bsS, "Contact", true);

            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", bsS, "Email", true);
        }

        private void Bm_Format(object sender, ConvertEventArgs e)
        {
            DateTime d = (DateTime)e.Value;
            e.Value = d.ToString("dd-MM-yyyy");
        }

        private void EmpEdit_Load_1(object sender, EventArgs e)
        {
            LoadDataBindingSource();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (bsS.Count > 0)
            {
                int v = int.Parse((bsS.Current as DataRowView).Row[0].ToString());
                new EditForm
                {
                    TheForm = this,
                    IdToEdit = v
                }.ShowDialog();
            }
            else
            {
                MessageBox.Show("No data available to edit.");
            }
        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            if (bsS.Position < bsS.Count - 1)
            {
                bsS.MoveNext();
            }
        }

        private void btnPre_Click_1(object sender, EventArgs e)
        {
            if (bsS.Position > 0)
            {
                bsS.MovePrevious();
            }
        }

        private void btnStart_Click_1(object sender, EventArgs e)
        {
            bsS.MoveFirst();
        }

        private void btnLast_Click_1(object sender, EventArgs e)
        {
            bsS.MoveLast();
        }
    }
}
