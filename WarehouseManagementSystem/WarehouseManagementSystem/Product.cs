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

namespace WarehouseManagementSystem
{
    public partial class Product : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source = .\SQLEXPRESS;Initial Catalog=WarehouseManagementDB;Integrated Security=True");
        public Product()
        {
            InitializeComponent();
            btnAddProd.Enabled = true;
            btnEditProd.Enabled = false;
            btnDelProd.Enabled = false;
        }
        private void Product_Load(object sender, EventArgs e)
        {
            loadDataComboBox();
            loadDataCbSearch();
            populate();
        }
        private void populate()
        {
            conn.Open();
            String querry = "select * from Product";
            SqlDataAdapter adapter = new SqlDataAdapter(querry, conn);
            //SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            dgvProduct.DataSource = ds.Tables[0];
            conn.Close();
        }
        private void loadDataCbSearch()
        {
            conn.Open();
            String querry = "select CategoryName from Category";
            SqlCommand cmd = new SqlCommand(querry, conn);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CategoryName", typeof(string));
            dt.Load(reader);
            cbSearch.ValueMember = "CategoryName";
            cbSearch.DataSource = dt;
            conn.Close();
        }
        private void loadDataComboBox()
        {
            conn.Open();
            String querry = "select CategoryName from Category";
            SqlCommand cmd = new SqlCommand(querry, conn);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CategoryName", typeof(string));
            dt.Load(reader);
            comboBox1.ValueMember = "CategoryName";
            comboBox1.DataSource = dt;
            conn.Close();

        }
        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void materialButton2_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.Show();
            this.Hide();
        }

        private void materialButton4_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                String querry = "insert into Product values(" + lbProdId.Text + ",'" + lbProdName.Text + "'," + lbProdQty.Text + "," + lbProdPrice.Text + ",'" + comboBox1.SelectedValue.ToString() + "')";
                SqlCommand cmd = new SqlCommand(querry, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added new Product");
                conn.Close();
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            lbProdId.Clear();
            lbProdName.Clear();
            lbProdQty.Clear();
            lbProdPrice.Clear();
            lbProdId.Focus();
        }

        private void dgvProduct_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProduct.SelectedRows.Count == 0)
            {
                return;
            }
            lbProdId.Text = (String)dgvProduct.SelectedRows[0].Cells[0].Value.ToString();
            lbProdName.Text = (String)dgvProduct.SelectedRows[0].Cells[1].Value.ToString();
            lbProdQty.Text = (String)dgvProduct.SelectedRows[0].Cells[2].Value.ToString();
            lbProdPrice.Text = (String)dgvProduct.SelectedRows[0].Cells[3].Value.ToString();
            comboBox1.SelectedValue = (String)dgvProduct.SelectedRows[0].Cells[4].Value.ToString();

            btnAddProd.Enabled = false;
            btnEditProd.Enabled = true;
            btnDelProd.Enabled = true;

        }

        private void btnEditProd_Click(object sender, EventArgs e)
        {
            String cbContent = comboBox1.SelectedValue.ToString();
            try
            {
                if (lbProdId.Text == "" || lbProdName.Text == "" || lbProdQty.Text == "" || lbProdPrice.Text == "")
                {
                    MessageBox.Show("Missing Info Detected!!!\nPlease Select Row before Updating");
                }
                else
                {
                    conn.Open();
                    string querry = "update Product set ProductName = '" + lbProdName.Text + "',ProductQty = " + lbProdQty.Text + ", ProductPrice = " + lbProdPrice.Text + ", ProductCategory = '" + cbContent + "' where ProductId = " + lbProdId.Text + ";";
                    SqlCommand cmd = new SqlCommand(querry, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated Product Item");
                    conn.Close();
                    populate();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnDelProd_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbProdId.Text == "")
                {
                    MessageBox.Show("Please Select Product before Deleting");
                }
                else
                {
                    conn.Open();
                    string querry = "delete from Product where ProductId =" + lbProdId.Text + "";
                    SqlCommand cmd = new SqlCommand(querry, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted Product Item");
                    conn.Close();
                    populate();
                    lbProdId.Clear();
                    lbProdName.Clear();
                    lbProdQty.Clear();
                    lbProdPrice.Clear();
                    lbProdId.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lbProdId_TextChanged(object sender, EventArgs e)
        {
            btnAddProd.Enabled = true;
            btnEditProd.Enabled = false;
            btnDelProd.Enabled = false;
        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                String querry = "select * from Product where ProductCategory = '" + cbSearch.SelectedValue.ToString() + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(querry, conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                var ds = new DataSet();
                adapter.Fill(ds);
                dgvProduct.DataSource = ds.Tables[0];
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void materialButton7_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void materialButton4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            PurchasingForm purchasingForm = new PurchasingForm();
            purchasingForm.Show();

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            SellingForm sellingForm = new SellingForm();
            sellingForm.Show();
        }

        private void btnProdMoves_Click(object sender, EventArgs e)
        {
            
            SoPo_Report soPo_Report = new SoPo_Report();
            this.Hide();
            soPo_Report.ShowDialog();
            this.Show();
        }
    }
}
