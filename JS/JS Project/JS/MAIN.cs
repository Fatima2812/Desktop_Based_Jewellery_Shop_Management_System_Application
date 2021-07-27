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
    public partial class MAIN : Form
    {
        public MAIN()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public class UserDisplayName
        {
            public static string displayName;
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

        private void CustomersPageButton_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers();
            customers.ShowDialog();
            this.Hide();
        }

        private void CrossButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void DashboardPageButton_Click(object sender, EventArgs e)
        {
            
            MAIN main = new MAIN();
            main.ShowDialog();
            this.Hide();
        }

        private void MAIN_Load(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToString("dddd , MMM dd yyyy , hh:mm:ss");
            UserLoggedInName.Text = session.username + " Logged In";
            Orders od = new Orders();
            label3.Text = od.ExpenseGridView1.RowCount.ToString();
            string str = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
                SqlConnection con = new SqlConnection(str);
                SqlCommand cmd = new SqlCommand("select * from use_login ", con);
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Close();
                ExpenseGridView.DataSource = dt;
                ExpenseGridView.Columns[0].HeaderText = "Name";
                ExpenseGridView.Columns[1].HeaderText = "Login Details";
            
            Products pro = new Products();
            ProductShowValueLabel.Text = pro.CompanyGridView.RowCount.ToString();
            Customers cust = new Customers();
            CustomerValueLabel.Text = cust.CustomerGridView.RowCount.ToString();
            
        }

        private void AddCustBtn_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.ShowDialog();
            this.Hide();
        }

        private void StoresPageButton_Click(object sender, EventArgs e)
        {
            Stock stock = new Stock();
            stock.ShowDialog();
            this.Hide();
      
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            ManageUsers manageUsers = new ManageUsers();
            manageUsers.ShowDialog();
            this.Hide();
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            ManageUsers manageUsers = new ManageUsers();
            manageUsers.ShowDialog();
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

        private void CategoryPageButton_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.ShowDialog();
            this.Hide();
        }

        private void ProductsPageButton_Click(object sender, EventArgs e)
        {
            Products products = new Products();
            products.ShowDialog();
            this.Hide();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Expenses expenses = new Expenses();
            expenses.ShowDialog();
            this.Hide();
        }

        private void OrdersButton_Click(object sender, EventArgs e)
        {
            Orders orders = new Orders();
            orders.ShowDialog();
            this.Hide();
        }

        private void CreateInvoiceBtn_Click(object sender, EventArgs e)
        {
            CustomerOrderData customerOrderData = new CustomerOrderData();
            customerOrderData.ShowDialog(); this.Hide();
        }

        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct(); addProduct.ShowDialog(); this.Hide();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn login = new LogIn();
            login.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword();
            changePassword.ShowDialog();
            this.Hide();
        }

        private void DatasbasePageButton_Click(object sender, EventArgs e)
        {
            ImportDatabase importDatabase = new ImportDatabase();
            importDatabase.ShowDialog();
            this.Hide();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers();
            customers.ShowDialog();
            this.Hide();
                
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            Orders orders = new Orders();
            orders.ShowDialog();
            this.Hide();
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            Products products = new Products();
            products.ShowDialog();
            this.Hide();

        }

        private void bunifuImageButton2_Click_1(object sender, EventArgs e)
        {
            ChangePass2 changePass2 = new ChangePass2();
            changePass2.ShowDialog();
            this.Hide();
        }
    }
}
