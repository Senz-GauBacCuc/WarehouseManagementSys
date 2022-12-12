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
    public partial class Category : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source = .\SQLEXPRESS;Initial Catalog=WarehouseManagementDB;Integrated Security=True");
        public Category()
        {
            InitializeComponent();
            btnAddCat.Enabled = true;
            btnEditCat.Enabled = false;
            btnDelCat.Enabled = false;
        }

        private void Category_Load(object sender, EventArgs e)
        {
            populate();

        }
        private void populate()
        {
            conn.Open();
            String querry = "select * from Category";
            SqlDataAdapter adapter = new SqlDataAdapter(querry, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            dgvCategory.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void materialButton4_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                String querry = "insert into Category values(" + lbCatID.Text + ",'" + lbCatName.Text + "','" + lbCatDes.Text + "')";
                SqlCommand cmd = new SqlCommand(querry, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added new Category");
                conn.Close();
                populate();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            lbCatID.Clear();
            lbCatName.Clear();
            lbCatDes.Clear();
            lbCatID.Focus();
            

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgvCategory_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvCategory.SelectedRows.Count == 0)
            {
                return;
            }
            lbCatID.Text = (String) dgvCategory.SelectedRows[0].Cells[0].Value.ToString();
            lbCatName.Text = (String) dgvCategory.SelectedRows[0].Cells[1].Value.ToString();
            lbCatDes.Text = (String) dgvCategory.SelectedRows[0].Cells[2].Value.ToString();

            btnAddCat.Enabled = false;
            btnEditCat.Enabled = true;
            btnDelCat.Enabled = true;
        }

        private void materialButton6_Click(object sender, EventArgs e)
        {
            try
            {
                if(lbCatID.Text == "")
                {
                    MessageBox.Show("Please Select Category before Deleting");
                }
                else
                {
                    conn.Open();
                    string querry = "delete from Category where CategoryId =" + lbCatID.Text + "";
                    SqlCommand cmd = new SqlCommand(querry, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted Category Item");
                    conn.Close();
                    populate();
                    lbCatID.Clear();
                    lbCatName.Clear();
                    lbCatDes.Clear();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void materialButton5_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbCatID.Text == "" || lbCatName.Text == "" || lbCatDes.Text == "")
                {
                    MessageBox.Show("Missing Info Detected!!!\nPlease Select Row before Updating");
                }
                else
                {
                    conn.Open();
                    string querry = "update Category set CategoryName = '" + lbCatName.Text + "',CategoryDes = '" + lbCatDes.Text + "' where CategoryId = " + lbCatID.Text + ";";
                    SqlCommand cmd = new SqlCommand(querry, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated Category Item");
                    conn.Close();
                    populate();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lbCatID_TextChanged(object sender, EventArgs e)
        {
            btnAddCat.Enabled = true;
            btnEditCat.Enabled = false;
            btnDelCat.Enabled = false;
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Show();
            this.Hide();
        }
    }
}
