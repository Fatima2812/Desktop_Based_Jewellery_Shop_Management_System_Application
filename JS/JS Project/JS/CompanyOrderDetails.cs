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
    public partial class CompanyOrderDetails : Form
    {
        public CompanyOrderDetails()
        {
            InitializeComponent();
        }
        private void refreshdatagrid()
        {
            string str = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("select * from  Sup_Order_detail", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            ExpenseGridView.DataSource = dt;
            ExpenseGridView.Columns[0].HeaderText = "ID";
            ExpenseGridView.Columns[1].HeaderText = "Unit Price";
            ExpenseGridView.Columns[2].HeaderText = "Bulk Price";
            ExpenseGridView.Columns[3].HeaderText = "Quantity";
            ExpenseGridView.Columns[4].HeaderText = "Unit Sale Price";
            ExpenseGridView.Columns[5].HeaderText = "Bulk Sale Price";
            ExpenseGridView.Columns[6].HeaderText = "Packaging Details";
            ExpenseGridView.Columns[7].HeaderText = "Order ID";
            ExpenseGridView.Columns[8].HeaderText = "Invoice no.";
            ExpenseGridView.Columns[9].HeaderText = "Discount";
        }
        private void CustomerDataLabel_Click(object sender, EventArgs e)
        {

        }

        private void CrossButton_Click(object sender, EventArgs e)
        {
            Orders orders = new Orders();
            orders.ShowDialog();
            this.Hide();

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

        private void ExportButton_Click(object sender, EventArgs e)
        {
            CompanyOrderReportViewer companyOrderReportViewer = new CompanyOrderReportViewer();
            companyOrderReportViewer.ShowDialog();
            this.Hide();
        }

        private void CompanyOrderDetails_Load(object sender, EventArgs e)
        {
            refreshdatagrid();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            string str = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("select * from Sup_Order_detail where sup_order_invoiceno like '" + guna2TextBox1.Text + "%'", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            ExpenseGridView.DataSource = dt;
            con.Close();
        }
    }
}
