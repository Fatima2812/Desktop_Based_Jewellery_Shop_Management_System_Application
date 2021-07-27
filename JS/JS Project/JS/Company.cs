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
    public partial class Company : Form
    {
        public Company()
        {
            InitializeComponent();
            Datagrid();
        }
        private void Datagrid()
        {
            string str = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("select * from Supplier ", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            CompanyGridView.DataSource = dt;
            CompanyGridView.Columns[0].HeaderText = "ID";
            CompanyGridView.Columns[1].HeaderText = "Supplier Name";
            CompanyGridView.Columns[2].HeaderText = "Company";
            CompanyGridView.Columns[3].HeaderText = "Registration no.";
            CompanyGridView.Columns[4].HeaderText = "ISO no.";
            CompanyGridView.Columns[5].HeaderText = "Address";
            CompanyGridView.Columns[6].HeaderText = "City";
            CompanyGridView.Columns[7].HeaderText = "Country";
            CompanyGridView.Columns[8].HeaderText = "Created";
        }
        private void CompanyGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            CompanyData up = new CompanyData();
            up.SignupEmailTextbox.Text = this.CompanyGridView.CurrentRow.Cells[0].Value.ToString();
            up.guna2TextBox1.Text = this.CompanyGridView.CurrentRow.Cells[1].Value.ToString();
            up.guna2TextBox2.Text = this.CompanyGridView.CurrentRow.Cells[2].Value.ToString();
            up.guna2TextBox3.Text = this.CompanyGridView.CurrentRow.Cells[3].Value.ToString();
            up.guna2TextBox4.Text = this.CompanyGridView.CurrentRow.Cells[4].Value.ToString();
            up.guna2TextBox5.Text = this.CompanyGridView.CurrentRow.Cells[5].Value.ToString();
            up.guna2TextBox6.Text = this.CompanyGridView.CurrentRow.Cells[6].Value.ToString();
            up.guna2TextBox7.Text = this.CompanyGridView.CurrentRow.Cells[7].Value.ToString();
            up.guna2TextBox8.Text = this.CompanyGridView.CurrentRow.Cells[8].Value.ToString();
            up.ShowDialog();
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

        private void Company_Load(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss"); // for showing date on form.
            CustomerValueLabel.Text = CompanyGridView.RowCount.ToString();
            string str = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("select * from Supplier ", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            CompanyGridView.DataSource = dt;
            con.Close();
        }

        private void CompanyGridView_Click(object sender, EventArgs e)
        {
            
        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            AddCompanyData addcompanyData = new AddCompanyData();
            addcompanyData.ShowDialog();
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

        private void BrandsPageButton_Click(object sender, EventArgs e)
        {
            Brands brands = new Brands();
            brands.ShowDialog();
            this.Hide();
        }

        private void CategoryPageButton_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.ShowDialog();
            this.Hide();
        }

        private void OrdersButton_Click(object sender, EventArgs e)
        {
            Orders orders = new Orders(); orders.ShowDialog(); this.Hide();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Expenses expenses = new Expenses();
            expenses.ShowDialog(); this.Hide();
        }

        private void ProductsPageButton_Click(object sender, EventArgs e)
        {
            Products products = new Products();
            products.ShowDialog(); this.Hide();
        }


        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            string str = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("select * from Supplier where Org_name like '" + guna2TextBox1.Text + "%'", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            CompanyGridView.DataSource = dt;
            con.Close();
        }

        private void CompanyGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            CompanyReportViewer companyReportViewer = new CompanyReportViewer();
            companyReportViewer.ShowDialog();
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            companydetailsview cd = new companydetailsview();
            cd.ShowDialog();
            this.Hide();
        }
    }
}
