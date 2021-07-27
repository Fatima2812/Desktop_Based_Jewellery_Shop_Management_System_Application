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
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;

namespace JS
{
    public partial class Stock : Form
    {
        public Stock()
        {
            InitializeComponent();
            refreshdatagrid();
        }
        private void refreshdatagrid()
        {
            string str = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("select * from STOCK ", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            CustomerGridView.DataSource = dt;
            CustomerGridView.Columns[0].HeaderText = "ID";
            CustomerGridView.Columns[5].HeaderText = "Product";
            CustomerGridView.Columns[6].HeaderText = "Product Category";
            CustomerGridView.Columns[7].HeaderText = "Product Type";
            CustomerGridView.Columns[1].HeaderText = "Supplier";
            CustomerGridView.Columns[2].HeaderText = "Quantity";
            CustomerGridView.Columns[3].HeaderText = "Price";
            CustomerGridView.Columns[4].HeaderText = "Stock in by";
            CustomerGridView.Columns[8].HeaderText = "SKU";
            CustomerGridView.Columns[9].HeaderText = "Discount";
            CustomerGridView.Columns[10].HeaderText = "Payment";
            CustomerGridView.Columns[11].HeaderText = "Created";
        }
        private void Stock_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss");
            CustomerValueLabel.Text = CustomerGridView.RowCount.ToString();
            string str = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("select * from STOCK ", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            CustomerGridView.DataSource = dt;
            con.Close();
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
            MAIN m = new MAIN();
            m.ShowDialog();
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

        private void AddStockButton_Click(object sender, EventArgs e)
        {
            AddStock addStock = new AddStock();
            addStock.ShowDialog();
            this.Hide();
        }

        private void MakeOrderBtnOnAddCust_Click(object sender, EventArgs e)
        {
            StockOrder stockOrder = new StockOrder();
            stockOrder.ShowDialog();
            this.Hide();
        }

        private void ComapnyPageButton_Click(object sender, EventArgs e)
        {
            Company company = new Company();
            company.ShowDialog();
            this.Hide();
        }

        private void BrandsPageButton_Click(object sender, EventArgs e)
        {
            Brands brands = new Brands();
            brands.ShowDialog();
            this.Hide();
        }

        private void StoresPageButton_Click(object sender, EventArgs e)
        {
            Stock stock = new Stock();
            stock.ShowDialog();
            this.Hide();
        }

        private void CustomerGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            StockData stockData = new StockData();
            stockData.SignupEmailTextbox.Text = this.CustomerGridView.CurrentRow.Cells[0].Value.ToString();
            stockData.guna2ComboBox2.SelectedValue = this.CustomerGridView.CurrentRow.Cells[1].Value.ToString();
            stockData.guna2TextBox2.Text = this.CustomerGridView.CurrentRow.Cells[2].Value.ToString();
            stockData.guna2TextBox1.Text = this.CustomerGridView.CurrentRow.Cells[3].Value.ToString();
            stockData.guna2ComboBox5.SelectedValue = this.CustomerGridView.CurrentRow.Cells[4].Value.ToString();
            stockData.guna2ComboBox3.Text = this.CustomerGridView.CurrentRow.Cells[5].Value.ToString();
            stockData.SignupAccountTypeCombobox.SelectedValue = this.CustomerGridView.CurrentRow.Cells[6].Value.ToString();
            stockData.guna2ComboBox1.SelectedValue = this.CustomerGridView.CurrentRow.Cells[7].Value.ToString();
            stockData.guna2TextBox11.Text = this.CustomerGridView.CurrentRow.Cells[8].Value.ToString();
            stockData.guna2TextBox10.Text = this.CustomerGridView.CurrentRow.Cells[9].Value.ToString();
            stockData.guna2ComboBox4.Text = this.CustomerGridView.CurrentRow.Cells[10].Value.ToString();
            stockData.guna2TextBox8.Text = this.CustomerGridView.CurrentRow.Cells[11].Value.ToString();
            stockData.ShowDialog();
        }

        private void CategoryPageButton_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.ShowDialog();
            this.Hide();
        }

        private void OrdersButton_Click(object sender, EventArgs e)
        {
            Orders orders = new Orders();
            orders.ShowDialog();
            this.Hide();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Expenses expenses = new Expenses(); 
            expenses.ShowDialog(); 
            this.Hide();
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            string str = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("select * from STOCK where product_name like '" + guna2TextBox2.Text + "%'", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            CustomerGridView.DataSource = dt;
            con.Close();
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            StockReportViewer stockReportViewer = new StockReportViewer();
            stockReportViewer.ShowDialog();
            this.Hide();
        }

        private void ProductsPageButton_Click(object sender, EventArgs e)
        {
            Products p = new Products();
            p.ShowDialog();
            this.Hide();
        }
    }
}

