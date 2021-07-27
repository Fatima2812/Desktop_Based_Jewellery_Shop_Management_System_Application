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
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
            refreshdatagrid();
        }
        private void refreshdatagrid()
        {
            string str = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("select * from Product ", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            CompanyGridView.DataSource = dt;
            CompanyGridView.Columns[0].HeaderText = "ID";
            CompanyGridView.Columns[1].HeaderText = "Name";
            CompanyGridView.Columns[2].HeaderText = "Description";
            CompanyGridView.Columns[3].HeaderText = "Size";
            CompanyGridView.Columns[4].HeaderText = "Colors";
            CompanyGridView.Columns[5].HeaderText = "Quantity";
            CompanyGridView.Columns[6].HeaderText = "Product Category";
            CompanyGridView.Columns[7].HeaderText = "Product Type";
            CompanyGridView.Columns[8].HeaderText = "Division";
            CompanyGridView.Columns[9].HeaderText = "Unit Price";
            CompanyGridView.Columns[10].HeaderText = "Supplier";
            CompanyGridView.Columns[11].HeaderText = "Created";
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

        private void Products_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss");
            totalProductsValueLabel.Text = CompanyGridView.RowCount.ToString();
            string str = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("select * from Product ", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            CompanyGridView.DataSource = dt;
            con.Close();
        }

        private void ProductGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProductData stockData = new ProductData();
            stockData.SignupEmailTextbox.Text = this.CompanyGridView.CurrentRow.Cells[0].Value.ToString();
            stockData.guna2TextBox2.Text = this.CompanyGridView.CurrentRow.Cells[1].Value.ToString();
            stockData.guna2TextBox1.Text = this.CompanyGridView.CurrentRow.Cells[2].Value.ToString();
            stockData.guna2TextBox3.Text = this.CompanyGridView.CurrentRow.Cells[3].Value.ToString();
            stockData.guna2TextBox11.Text = this.CompanyGridView.CurrentRow.Cells[4].Value.ToString();
            stockData.guna2TextBox10.Text = this.CompanyGridView.CurrentRow.Cells[5].Value.ToString();
            stockData.SignupAccountTypeCombobox.SelectedValue = this.CompanyGridView.CurrentRow.Cells[6].Value.ToString();
            stockData.guna2ComboBox3.SelectedValue = this.CompanyGridView.CurrentRow.Cells[7].Value.ToString();
            stockData.guna2ComboBox1.Text = this.CompanyGridView.CurrentRow.Cells[8].Value.ToString();
            stockData.guna2TextBox8.Text = this.CompanyGridView.CurrentRow.Cells[9].Value.ToString();
            stockData.guna2ComboBox2.SelectedValue = this.CompanyGridView.CurrentRow.Cells[10].Value.ToString();
            stockData.guna2TextBox4.Text = this.CompanyGridView.CurrentRow.Cells[11].Value.ToString();
            stockData.ShowDialog();
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addProduct.ShowDialog();
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

        private void OrdersButton_Click(object sender, EventArgs e)
        {
            Orders orders = new Orders();
            orders.ShowDialog();
            this.Hide();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            string str = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("select * from Product where productName like '" + guna2TextBox1.Text + "%'", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            CompanyGridView.DataSource = dt;
            con.Close();
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            ProReportViewer proReportViewer = new ProReportViewer();
            proReportViewer.ShowDialog();
            this.Hide();
        }
    }
}
