using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NkbWork
{
    public partial class SP_Curd : Form
    {
        string conString = "Data Source=NKB;Initial Catalog=VSTDB;Integrated Security=True";
        SqlConnection sqlCon;
        SqlCommand cmd;
        string productId = "";
        public SP_Curd()
        {
            InitializeComponent();
            sqlCon = new SqlConnection(conString);
            sqlCon.Open();
        }

        private void SP_Curd_Load(object sender, EventArgs e)
        {

        }
            private void btnSave_Click_1(object sender, EventArgs e)
            {
                if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    MessageBox.Show("Enter product name!!");
                    txtName.Select();
                }
                else if (string.IsNullOrWhiteSpace(txtCategory.Text))
                {
                    MessageBox.Show("Enter category!!");
                    txtCategory.Select();
                }
                else if (string.IsNullOrWhiteSpace(txtPrice.Text))
                {
                    MessageBox.Show("Enter price!!");
                    txtPrice.Select();
                }
                else if (string.IsNullOrWhiteSpace(txtQuantity.Text))
                {
                    MessageBox.Show("Enter quantity!!");
                    txtQuantity.Select();
                }
                else
                {
                    try
                    {
                        if (sqlCon.State == ConnectionState.Closed)
                        {
                            sqlCon.Open();
                        }
                        DataTable dtData = new DataTable();
                        cmd = new SqlCommand("spProduct", sqlCon); // Updated stored procedure name to spProduct
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@actionType", "SaveData");
                        cmd.Parameters.AddWithValue("@ProdId", productId); // Updated parameter name
                        cmd.Parameters.AddWithValue("@Name", txtName.Text); // Updated parameter names
                        cmd.Parameters.AddWithValue("@Category", txtCategory.Text); // Updated parameter names
                        cmd.Parameters.AddWithValue("@Price", Convert.ToDecimal(txtPrice.Text)); // Price should be decimal
                        cmd.Parameters.AddWithValue("@Quantity", Convert.ToInt32(txtQuantity.Text)); // Quantity should be int

                        int numRes = cmd.ExecuteNonQuery();
                        if (numRes > 0)
                        {
                            MessageBox.Show("Data saved successfully!!!");
                            LoadGrid();
                            ClearAll();
                        }

                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }

            private DataTable ShowAllProductData()
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }
                DataTable dtData = new DataTable();
                cmd = new SqlCommand("spProduct", sqlCon); // Updated stored procedure name to spProduct
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@actionType", "ShowAllData");
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dtData);
                return dtData;
            }

            private void ClearAll()
            {
                btnSave.Text = "Save";
                txtName.Clear();
                txtCategory.Clear();
                txtPrice.Clear();
                txtQuantity.Clear();
                productId = "";
                LoadGrid();
            }

            private void frmCRUD_withSP_Load(object sender, EventArgs e)
            {
                LoadGrid();
            }

            private void LoadGrid()
            {
                dataGridView1.DataSource = ShowAllProductData(); // Loading products data
            }

            private DataTable ShowProductRecordById(string prodId)
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }
                DataTable dtData = new DataTable();
                cmd = new SqlCommand("spProduct", sqlCon); // Updated stored procedure name to spProduct
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@actionType", "ShowAllDataById");
                cmd.Parameters.AddWithValue("@ProdId", prodId); // Updated parameter name
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dtData);
                return dtData;
            }

            private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
                if (e.RowIndex >= 0)
                {
                    btnSave.Text = "Update";
                    productId = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(); // Updated to use productId
                    DataTable dtData = ShowProductRecordById(productId); // Updated to show product by ID
                    if (dtData.Rows.Count > 0)
                    {
                        productId = dtData.Rows[0][0].ToString();
                        txtName.Text = dtData.Rows[0][1].ToString();
                        txtCategory.Text = dtData.Rows[0][2].ToString();
                        txtPrice.Text = dtData.Rows[0][3].ToString();
                        txtQuantity.Text = dtData.Rows[0][4].ToString();
                    }
                }
            }

            private void btnClear_Click_1(object sender, EventArgs e)
            {
                ClearAll();
            }

            private void btnDelete_Click_1(object sender, EventArgs e)
            {
                if (!string.IsNullOrEmpty(productId))
                {
                    try
                    {
                        if (sqlCon.State == ConnectionState.Closed)
                        {
                            sqlCon.Open();
                        }
                        cmd = new SqlCommand("spProduct", sqlCon); // Updated stored procedure name to spProduct
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@actionType", "DeleteData");
                        cmd.Parameters.AddWithValue("@ProdId", productId); // Updated parameter name
                        int numRes = cmd.ExecuteNonQuery();
                        if (numRes > 0)
                        {
                            MessageBox.Show("Data deleted successfully!!!");
                            LoadGrid();
                            ClearAll();
                        }
                        else
                        {
                            MessageBox.Show("Please try again!!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: - " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a record!!");
                }
            }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}

        //private void btnDelete_Click_1(object sender, EventArgs e)
        //{

        //}

        //private void btnClear_Click_1(object sender, EventArgs e)
        //{

        //}

        //private void btnSave_Click_1(object sender, EventArgs e)
        //{

        //}
    }
    }
