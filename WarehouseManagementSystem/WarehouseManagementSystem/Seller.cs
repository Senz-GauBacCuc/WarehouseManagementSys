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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WarehouseManagementSystem
{
    public partial class Seller : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source = .\SQLEXPRESS;Initial Catalog=WarehouseManagementDB;Integrated Security=True");
        public Seller()
        {
            InitializeComponent();
            btnAddSel.Enabled = true;
            btnEditSel.Enabled = false;
            btnDelSel.Enabled = false;
        }
        private void Seller_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void populate()
        {
            conn.Open();
            String querry = "select * from Seller";
            SqlDataAdapter adapter = new SqlDataAdapter(querry, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            dgvSeller.DataSource = ds.Tables[0];
            conn.Close();
        }
        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgvSeller_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSeller.SelectedRows.Count == 0)
            {
                return;
            }
            lbSellerId.Text = (String)dgvSeller.SelectedRows[0].Cells[0].Value.ToString();
            lbSellerName.Text = (String)dgvSeller.SelectedRows[0].Cells[1].Value.ToString();
            lbSellerAge.Text = (String)dgvSeller.SelectedRows[0].Cells[2].Value.ToString();
            lbSellerPhone.Text = (String)dgvSeller.SelectedRows[0].Cells[3].Value.ToString();
            lbSellerPass.Text = (String)dgvSeller.SelectedRows[0].Cells[4].Value.ToString();

            btnAddSel.Enabled = false;
            btnEditSel.Enabled = true;
            btnDelSel.Enabled = true;
        }

        private void btnAddSel_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                String querry = "insert into Seller values(" + lbSellerId.Text + ",'" + lbSellerName.Text + "'," + lbSellerAge.Text + ",'" + lbSellerPhone.Text + "','" + lbSellerPass.Text+ "')";
                SqlCommand cmd = new SqlCommand(querry, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added new Seller");
                conn.Close();
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            lbSellerId.Clear();
            lbSellerName.Clear();
            lbSellerAge.Clear();
            lbSellerPhone.Clear();
            lbSellerPass.Clear();
            lbSellerId.Focus();
        }

        private void btnEditSel_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbSellerId.Text == "" || lbSellerName.Text == "" || lbSellerAge.Text == "" || lbSellerPhone.Text == "" || lbSellerPass.Text == "")
                {
                    MessageBox.Show("Missing Info Detected!!!\nPlease Select Row before Updating");
                }
                else
                {
                    conn.Open();
                    string querry = "update Seller set SellerName = '" + lbSellerName.Text + "',SellerAge = " + lbSellerAge.Text + ", SellerPhone = '" + lbSellerPhone.Text + "', SellerPass = '" + lbSellerPass + "' where SellerId = " + lbSellerId.Text + ";";
                    SqlCommand cmd = new SqlCommand(querry, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated Seller Info");
                    conn.Close();
                    populate();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelSel_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbSellerId.Text == "")
                {
                    MessageBox.Show("Please Select Seller before Deleting");
                }
                else
                {
                    conn.Open();
                    string querry = "delete from Seller where SellerId =" + lbSellerId.Text + "";
                    SqlCommand cmd = new SqlCommand(querry, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted the Seller");
                    conn.Close();
                    populate();
                    lbSellerId.Clear();
                    lbSellerName.Clear();
                    lbSellerAge.Clear();
                    lbSellerPhone.Clear();
                    lbSellerPass.Clear();
                    lbSellerId.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lbSellerId_TextChanged(object sender, EventArgs e)
        {
            btnAddSel.Enabled = true;
            btnEditSel.Enabled = false;
            btnDelSel.Enabled = false;
        }
    }
}
