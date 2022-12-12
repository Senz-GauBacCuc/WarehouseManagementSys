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
    public partial class SoPo_Report : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source = .\SQLEXPRESS;Initial Catalog=WarehouseManagementDB;Integrated Security=True");
        public SoPo_Report()
        {
            InitializeComponent();
        }

        private void SoPo_Report_Load(object sender, EventArgs e)
        {
            LoadSODetail();
            LoadPODetails();
        }

        private void LoadPODetails()
        {
            conn.Open();
            String querry = "select * from BillInfo";
            SqlDataAdapter adapter = new SqlDataAdapter(querry, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            dgvSO.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void LoadSODetail()
        {
            conn.Open();
            String querry = "select * from POInfo";
            SqlDataAdapter adapter = new SqlDataAdapter(querry, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            dgvPO.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Product product = new Product();
            product.Show();
        }
    }
}
