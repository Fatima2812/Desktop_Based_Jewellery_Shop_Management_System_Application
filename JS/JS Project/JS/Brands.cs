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
    public partial class Brands : Form
    {
        public Brands()
        {
            InitializeComponent();
            refreshdatagrid();
        }
        private void refreshdatagrid()
        {

            string str = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("select * from Product_Type ", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            BrandGridView.DataSource = dt;
            BrandGridView.Columns[0].HeaderText = "ID";
            BrandGridView.Columns[1].HeaderText = "Type Name";
            BrandGridView.Columns[2].HeaderText = "Description";
            BrandGridView.Columns[3].HeaderText = "No. of Available Size";
            BrandGridView.Columns[4].HeaderText = "Available Colours";
            BrandGridView.Columns[5].HeaderText = "Quantity";
            BrandGridView.Columns[6].HeaderText = "Catagory";
            BrandGridView.Columns[7].HeaderText = "Supplier";
            BrandGridView.Columns[8].HeaderText = "Created";
        }
        private void DashboardPageButton_Click(object sender, EventArgs e)
        {
            MAIN main = new MAIN();
            main.ShowDialog();
            this.Hide();
        }

        private void CustomersPageButton_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers();
            customers.ShowDialog();
            this.Hide();
        }

        private void StoresPageButton_Click(object sender, EventArgs e)
        {
            Stock stock = new Stock();
            stock.ShowDialog();
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
            this.Close();
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

        private void BrandGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateBrandData up = new UpdateBrandData();
            up.SignupEmailTextbox.Text = this.BrandGridView.CurrentRow.Cells[0].Value.ToString();
            up.guna2TextBox1.Text = this.BrandGridView.CurrentRow.Cells[1].Value.ToString();
            up.guna2TextBox2.Text = this.BrandGridView.CurrentRow.Cells[2].Value.ToString();
            up.guna2TextBox3.Text = this.BrandGridView.CurrentRow.Cells[3].Value.ToString();
            up.guna2TextBox4.Text = this.BrandGridView.CurrentRow.Cells[4].Value.ToString();
            up.guna2TextBox5.Text = this.BrandGridView.CurrentRow.Cells[5].Value.ToString();
            up.guna2ComboBox2.SelectedValue = this.BrandGridView.CurrentRow.Cells[6].Value.ToString();
            up.guna2ComboBox1.SelectedValue = this.BrandGridView.CurrentRow.Cells[7].Value.ToString();
            up.guna2TextBox6.Text = this.BrandGridView.CurrentRow.Cells[8].Value.ToString();
            up.ShowDialog();
        }

        private void Brands_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss");
            CustomerValueLabel.Text = BrandGridView.RowCount.ToString();
            string str = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("select * from Product_Type ", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            BrandGridView.DataSource = dt;
            con.Close();
        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            AddBrand addBrand = new AddBrand();
            addBrand.ShowDialog();
            this.Hide();
        }

        private void BrandGridView_Click(object sender, EventArgs e)
        {
           
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

        private void CustomerViewScrollBar_Scroll(object sender, ScrollEventArgs e)
        {

           
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            string str = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("select * from Product_Type where proTypeName like '" + guna2TextBox1.Text + "%'", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            BrandGridView.DataSource = dt;
            con.Close();
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            BrandReportViewer brandReportViewer = new BrandReportViewer();
            brandReportViewer.ShowDialog();
            this.Hide();
        }
    }
}
