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
    public partial class Category : Form
    {
        public Category()
        {
            InitializeComponent();
            refreshdatagrid();
        }
        private void refreshdatagrid()
        {
            string str = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("select * from Product_Category ", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            CustomerGridView.DataSource = dt;
            CustomerGridView.Columns[0].HeaderText = "ID";
            CustomerGridView.Columns[1].HeaderText = "Name";
            CustomerGridView.Columns[2].HeaderText = "No. of Types";
            CustomerGridView.Columns[3].HeaderText = "Description";
            CustomerGridView.Columns[4].HeaderText = "Created";
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

        private void Category_Load(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss");
            label6.Text = CustomerGridView.RowCount.ToString();
            string str = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("select * from Product_Category ", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            CustomerGridView.DataSource = dt;
            con.Close();
        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            AddCategory addCategory = new AddCategory();
            addCategory.ShowDialog();
            this.Hide();
        }

        private void CategoryGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CategoryData categoryData = new CategoryData();
            categoryData.SignupEmailTextbox.Text = this.CustomerGridView.CurrentRow.Cells[0].Value.ToString();
            categoryData.guna2TextBox1.Text = this.CustomerGridView.CurrentRow.Cells[1].Value.ToString();
            categoryData.guna2TextBox2.Text = this.CustomerGridView.CurrentRow.Cells[2].Value.ToString();
            categoryData.guna2TextBox3.Text = this.CustomerGridView.CurrentRow.Cells[3].Value.ToString();
            categoryData.guna2TextBox4.Text = this.CustomerGridView.CurrentRow.Cells[4].Value.ToString();
            categoryData.ShowDialog();
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

        private void ProductsPageButton_Click(object sender, EventArgs e)
        {
            Products products = new Products();
            products.ShowDialog();
            this.Hide();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            string str = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("select * from Product_Category where proCatName like '" + guna2TextBox1.Text + "%'", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            CustomerGridView.DataSource = dt;
            con.Close();
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            CategoryReportViewer categoryReportViewer = new CategoryReportViewer();
            categoryReportViewer.ShowDialog();
            this.Hide();
        }
    }
}
