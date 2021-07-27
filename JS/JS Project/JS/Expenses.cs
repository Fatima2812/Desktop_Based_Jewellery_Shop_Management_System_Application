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
    public partial class Expenses : Form
    {
        public Expenses()
        {
            InitializeComponent();
            refreshdatagrid();
        }
        private void refreshdatagrid()
        {
            string str = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("select * from Daily_Expense ", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            ExpenseGridView.DataSource = dt;
            ExpenseGridView.Columns[0].HeaderText = "ID";
            ExpenseGridView.Columns[1].HeaderText = "Type";
            ExpenseGridView.Columns[2].HeaderText = "Description";
            ExpenseGridView.Columns[3].HeaderText = "Amount";
            ExpenseGridView.Columns[4].HeaderText = "Entered by";
            ExpenseGridView.Columns[5].HeaderText = "Created";
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

        private void ExpenseGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ExpenseData stockData = new ExpenseData();
            stockData.guna2TextBox26.Text = this.ExpenseGridView.CurrentRow.Cells[0].Value.ToString();
            stockData.guna2TextBox25.Text = this.ExpenseGridView.CurrentRow.Cells[1].Value.ToString();
            stockData.guna2TextBox24.Text = this.ExpenseGridView.CurrentRow.Cells[2].Value.ToString();
            stockData.guna2TextBox20.Text = this.ExpenseGridView.CurrentRow.Cells[3].Value.ToString();
            stockData.guna2ComboBox2.SelectedValue = this.ExpenseGridView.CurrentRow.Cells[4].Value.ToString();
            stockData.guna2TextBox1.Text = this.ExpenseGridView.CurrentRow.Cells[5].Value.ToString();
            stockData.ShowDialog();
        }

        private void AddExpenseButton_Click(object sender, EventArgs e)
        {
            AddExpense addExpense = new AddExpense();
            addExpense.ShowDialog();
            this.Hide();
        }

        private void Expenses_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss");
            totalExpenseValueLabel.Text = ExpenseGridView.RowCount.ToString();
            string str = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("select * from Daily_Expense ", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            ExpenseGridView.DataSource = dt;
            con.Close();
        }

        private void OrdersButton_Click(object sender, EventArgs e)
        {
            Orders orders = new Orders();
            orders.ShowDialog();
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

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            string str = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("select * from Daily_Expense where expense_type like '" + guna2TextBox1.Text + "%'", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            ExpenseGridView.DataSource = dt;
            con.Close();
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            ExpenseViewer expenseViewer = new ExpenseViewer();
            expenseViewer.ShowDialog();
            this.Hide();

        }
    }
}
