using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JS
{
    public partial class CustomerOrderDetails : Form
    {
        public CustomerOrderDetails()
        {
            InitializeComponent();
        }
        private void refreshdatagrid()
        {
            string str = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("select * from  Cust_Order_detail", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            ExpenseGridView.DataSource = dt;
            ExpenseGridView.Columns[0].HeaderText = "ID";
            ExpenseGridView.Columns[1].HeaderText = "Price";
            ExpenseGridView.Columns[2].HeaderText = "Quantity";
            ExpenseGridView.Columns[3].HeaderText = "Sale Price";
            ExpenseGridView.Columns[4].HeaderText = "Order ID";
            ExpenseGridView.Columns[5].HeaderText = "Invoice no.";
            ExpenseGridView.Columns[6].HeaderText = "Purchase Price";
            ExpenseGridView.Columns[7].HeaderText = "Discount";
        }
        private void CrossButton_Click(object sender, EventArgs e)
        {
            Orders orders = new Orders();
            orders.ShowDialog();
            this.Hide();
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            OrderReportViewer orderReportViewer = new OrderReportViewer();
            orderReportViewer.ShowDialog();
            this.Hide();
        }

        private void ExpenseGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            CustomerOrderDetails customerOrderDetails = new CustomerOrderDetails();
            customerOrderDetails.ShowDialog();
            this.Hide();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            CompanyOrderDetails companyOrderDetails = new CompanyOrderDetails();
            companyOrderDetails.ShowDialog();
            this.Hide();
        }

        private void CustomerOrderDetails_Load(object sender, EventArgs e)
        {
            refreshdatagrid();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            string str = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("select * from Cust_Order_detail where cust_order_invoiceno like '" + guna2TextBox1.Text + "%'", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            ExpenseGridView.DataSource = dt;
            con.Close();
        }
    }
}
