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
    public partial class PurchasingForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source = .\SQLEXPRESS;Initial Catalog=WarehouseManagementDB;Integrated Security=True");
        public PurchasingForm()
        {

            InitializeComponent();
            btnAddBill.Enabled = false;
            btnPrintBill.Enabled = false;
            btnDelBill.Enabled = false;
            btnAddProdTemp.Enabled = false;
        }
        private void label4_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void PurchasingForm_Load(object sender, EventArgs e)
        {
            populate();
            loadPO();
            loadDataComboBox();
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
        private void populate()
        {
            conn.Open();
            String querry = "select ProductName, ProductQty, ProductPrice from Product";
            SqlDataAdapter adapter = new SqlDataAdapter(querry, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            dgvProdWarehouse.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void loadPO()
        {
            conn.Open();
            String querry = "select * from PO";
            SqlDataAdapter adapter = new SqlDataAdapter(querry, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            dgvPO.DataSource = ds.Tables[0];
            conn.Close();
        }
        private void dgvProdWarehouse_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dgvProdWarehouse.SelectedRows.Count == 0)
            {
                return;
            }
            lbProdName.Text = (String)dgvProdWarehouse.SelectedRows[0].Cells[0].Value.ToString();
            lbProdQty.Text = (String)dgvProdWarehouse.SelectedRows[0].Cells[1].Value.ToString();
            lbProdPrice.Text = (String)dgvProdWarehouse.SelectedRows[0].Cells[2].Value.ToString();
            btnAddProdTemp.Enabled = true;
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            lbDate.Text = DateTime.Now.ToShortDateString();
            //lbDate.Text = DateTime.Now.ToLongDateString();
        }

        public float totalPrice = 0;
        int i = 0;
        private void btnAddProdTemp_Click_1(object sender, EventArgs e)
        {
            if (lbProdName.Text == "" || lbProdQty.Text == "" || lbProdPrice.Text == "")
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                float rowTotalPrice = float.Parse(lbProdPrice.Text) * float.Parse(lbProdQty.Text);
                String PO_Id = "IP" + dgvPO.Rows.Count;
                String No = dgvTempOrder.Rows.Count + "_" + PO_Id;
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dgvTempOrder);
                newRow.Cells[0].Value = No;
                newRow.Cells[1].Value = lbProdName.Text;
                newRow.Cells[2].Value = lbProdQty.Text;
                newRow.Cells[3].Value = lbProdPrice.Text;
                newRow.Cells[4].Value = rowTotalPrice;
                newRow.Cells[5].Value = PO_Id;
                dgvTempOrder.Rows.Add(newRow);
                i++;
                totalPrice += rowTotalPrice;
                lbTotalPrice.Text = totalPrice + "";
                conn.Open();
                String querry = "insert into POInfo values('" + No + "','" + lbProdName.Text + "'," + lbProdQty.Text + "," + lbProdPrice.Text + "," + rowTotalPrice + ",'" + PO_Id + "')";
                SqlCommand cmd = new SqlCommand(querry, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added new Product into Wishlist");
                updateProductQty(lbProdName.Text, lbProdQty.Text, "+");
                conn.Close();
                btnAddBill.Enabled = true;
                populate();

            }
        }
        private void updateProductQty(String product, String qty, String flag)
        {
            string querryGetQtyDB = "Select ProductQty from Product where ProductName = '" + product + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(querryGetQtyDB, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DataRow dr = dt.Rows[0];
            int qtyInDB;
            if (flag == "-")
            {
                qtyInDB = Convert.ToInt32(dr["ProductQty"].ToString()) - Convert.ToInt32(qty);
            }
            else
            {
                qtyInDB = Convert.ToInt32(dr["ProductQty"].ToString()) + Convert.ToInt32(qty);
            }
            string querryUpdateQty = "Update Product set ProductQty = " + qtyInDB + " where ProductName = '" + product + "'";
            SqlCommand cmd = new SqlCommand(querryUpdateQty, conn);
            cmd.ExecuteNonQuery();
        }

        private void btnAddBill_Click_1(object sender, EventArgs e)
        {
            if (dgvTempOrder.Rows.Count == 0)
            {
                MessageBox.Show("No Item in Wishlist");
            }
            else
            {
                String POID = "IP" + dgvPO.Rows.Count;
                try
                {
                    conn.Open();
                    String querry = "insert into PO values('" + POID + "','" + lbSellerName.Text + "','" + lbDate.Text + "'," + lbTotalPrice.Text + ")";
                    SqlCommand cmd = new SqlCommand(querry, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Added new PO");
                    conn.Close();
                    populate();
                    loadPO();
                    totalPrice = 0;
                    dgvTempOrder.Rows.Clear();
                    dgvTempOrder.Refresh();
                    btnAddBill.Enabled = false;
                    btnDelBill.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                totalPrice = 0;
                lbTotalPrice.Text = totalPrice + "";
            }
        }
        private void materialButton7_Click_1(object sender, EventArgs e)
        {
            populate();
        }

        private void comboBox1_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            conn.Open();
            String querry = "select ProductName, ProductQty, ProductPrice from Product where ProductCategory = '" + comboBox1.SelectedValue.ToString() + "';";
            SqlDataAdapter adapter = new SqlDataAdapter(querry, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            dgvProdWarehouse.DataSource = ds.Tables[0];
            conn.Close();
        }
        private void label7_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Product product = new Product();
            product.Show();
        }
        private void dgvPO_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPO.SelectedRows.Count == 0)
            {
                return;
            }
            lbRecordIndex.Text = (String)dgvPO.SelectedRows[0].Cells[0].Value.ToString();
            btnDelBill.Enabled = true;
        }
        private void btnDelBill_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (lbRecordIndex.Text == "")
                {
                    MessageBox.Show("Please Select PO before Deleting");
                }
                else
                {
                    conn.Open();
                    string querry = "delete from PO where POId = '" + lbRecordIndex.Text + "';";
                    SqlCommand cmd = new SqlCommand(querry, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted PO Record");
                    UpdateQtyFromPODel(lbRecordIndex.Text);
                    UpdatePOInfo();
                    conn.Close();
                    btnDelBill.Enabled = false;
                    loadPO();
                    populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void UpdateQtyFromPODel(String billId)
        {
            string querry = "Select * from POInFo where PO_Id = '" + billId + "';";
            SqlDataAdapter adapter = new SqlDataAdapter(querry, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                String productName = dr["ProductName"].ToString();
                String Qty = dr["Qty"].ToString();
                updateProductQty(productName, Qty, "-");
            }
        }
        private void UpdatePOInfo()
        {
            string querry = "DELETE FROM POInfo WHERE PO_Id = '" + lbRecordIndex.Text + "';";
            SqlCommand cmd = new SqlCommand(querry, conn);
            cmd.ExecuteNonQuery();
        }


    }
}
