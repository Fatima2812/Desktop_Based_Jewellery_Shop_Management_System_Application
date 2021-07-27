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
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
        }
        private void refreshdatagrid()
        {
            string str = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("select * from  Cust_Order_payment", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            ExpenseGridView1.DataSource = dt;
            ExpenseGridView1.Columns[0].HeaderText = "ID";
            ExpenseGridView1.Columns[1].HeaderText = "Payment Medium";
            ExpenseGridView1.Columns[2].HeaderText = "Added By";
            ExpenseGridView1.Columns[3].HeaderText = "Order ID";
            ExpenseGridView1.Columns[4].HeaderText = "Invoice no.";
            ExpenseGridView1.Columns[5].HeaderText = "Amount";
            ExpenseGridView1.Columns[6].HeaderText = "Created";
        }
        private void datagrid()
        {
            string str = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("select * from  Supp_Order_payment", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            guna2DataGridView1.DataSource = dt;
            guna2DataGridView1.Columns[0].HeaderText = "ID";
            guna2DataGridView1.Columns[1].HeaderText = "Payment Medium";
            guna2DataGridView1.Columns[2].HeaderText = "Added By";
            guna2DataGridView1.Columns[3].HeaderText = "Order ID";
            guna2DataGridView1.Columns[4].HeaderText = "Invoice no.";
            guna2DataGridView1.Columns[5].HeaderText = "Amount";
            guna2DataGridView1.Columns[6].HeaderText = "Created";
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (panel1.Width == 50)
            {
                //Expand the panel , width = 250 
                //Show logo

                panel1.Visible = false;
                panel1.Width = 260;
                PanelTransition.ShowSync(panel1);
                Logo1Transition.ShowSync(logo);

            }
            else
            {
                PanelTransition.Hide(logo);
                panel1.Visible = false;
                panel1.Width = 50;
                PanelTransition.ShowSync(panel1);
            }
        }

        private void CrossButton_Click(object sender, EventArgs e)
        {
            MAIN main = new MAIN();
            main.ShowDialog();
            this.Hide();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            CustomerOrderData customerOrderData = new CustomerOrderData();
            customerOrderData.ShowDialog();
            this.Hide();
        }

        private void OrdersButton_Click(object sender, EventArgs e)
        {
            Orders orders = new Orders();
            orders.ShowDialog();
            this.Hide();
        }

        private void OrderGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Expenses expenses = new Expenses();
            expenses.ShowDialog();
            this.Hide();
        }

        private void ProductsPageButton_Click(object sender, EventArgs e)
        {
            Products products = new Products();
            products.ShowDialog();
            this.Hide();
        }

        private void CategoryPageButton_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.ShowDialog();
            this.Hide();

        }

        private void BrandsPageButton_Click(object sender, EventArgs e)
        {
            Brands brands = new Brands();
            brands.ShowDialog();
            this.Hide();
        }

        private void ComapnyPageButton_Click(object sender, EventArgs e)
        {
            Company company = new Company();
            company.ShowDialog();
            this.Hide();
        }

        private void StoresPageButton_Click(object sender, EventArgs e)
        {
            Stock stock = new Stock();
            stock.ShowDialog();
            this.Hide();
        }

        private void CustomersPageButton_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers();
            customers.ShowDialog();
            this.Hide();
        }

        private void DashboardPageButton_Click(object sender, EventArgs e)
        {
            MAIN main = new MAIN();
            main.ShowDialog();
            this.Hide();
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            CustomerOrdPayRepViewer customerOrdPayRepViewer = new CustomerOrdPayRepViewer();
            customerOrdPayRepViewer.ShowDialog();
            this.Hide();
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss");
            refreshdatagrid();
            datagrid();
            totalExpenseValueLabel.Text = ExpenseGridView1.RowCount.ToString();
            label3.Text = guna2DataGridView1.RowCount.ToString();

        }
        
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            CustomerOrderDetails customerOrderDetails = new CustomerOrderDetails();
            customerOrderDetails.ShowDialog();
            this.Hide();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            string str = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("select * from Cust_Order_payment where cust_order_invoiceno like '" + guna2TextBox1.Text + "%'", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            ExpenseGridView1.DataSource = dt;
            con.Close();
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            string str = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("select * from Supp_Order_payment where sup_order_invoiceno like '" + guna2TextBox2.Text + "%'", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
