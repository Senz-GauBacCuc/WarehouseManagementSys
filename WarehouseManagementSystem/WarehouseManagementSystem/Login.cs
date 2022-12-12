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
using MaterialSkin;

namespace WarehouseManagementSystem
{
    public partial class Login : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source = .\SQLEXPRESS;Initial Catalog=WarehouseManagementDB;Integrated Security=True");
        public static String sellerName = "";
        public Login()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lbUserName.Clear();
            lbUserPass.Clear();
            lbUserName.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (lbUserName.Text == "" || lbUserPass.Text == "" || cbRole.SelectedIndex == -1)
            {
                MessageBox.Show("Name, Password or role is empty.");
            }
            else
            {
                if(cbRole.SelectedItem.ToString() == "Admin")
                {
                    if(lbUserName.Text == "Admin" && lbUserPass.Text == "Admin")
                    {
                        sellerName = "Admin";
                        this.Hide();
                        Product product = new Product();
                        product.Show();
                        
                    }
                    else
                    {
                        MessageBox.Show("Wrong username or password at Admin Account.");
                    }
                }
                else
                {
                    conn.Open();
                    String querry = "Select top(1) * from Seller where SellerName ='" + lbUserName.Text + "' and SellerPass = '" + lbUserPass.Text + "';";
                    SqlDataAdapter adapter = new SqlDataAdapter(querry,conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        sellerName = lbUserName.Text;
                        this.Hide();
                        SellingForm sellingForm = new SellingForm();
                        sellingForm.Show();
                        
                        
                    }
                    else
                    {
                        MessageBox.Show("Wrong username or password at Seller Account.");
                    }
                   conn.Close();
                }
            }
        }
    }
}
