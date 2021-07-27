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
    public partial class CustomerOrderData : Form
    {
        public CustomerOrderData()
        {
            InitializeComponent();
            Employeedata();
            Customerdata();
            Empdata();
            datagrid();
        }
        private void datagrid()
        {

            string str = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            SqlConnection con = new SqlConnection(str);
            string query = "select * from Cust_OrderDetailsview";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            //ExpenseGridView.DataSource = dt;
           // ExpenseGridView.Columns[0].HeaderText = "ID";
           // ExpenseGridView.Columns[1].HeaderText = "Product Name";
           // ExpenseGridView.Columns[2].HeaderText = "Price";
          //  ExpenseGridView.Columns[3].HeaderText = "Quantity";
          //  ExpenseGridView.Columns[4].HeaderText = "Total Price";
        }
        public void Employeedata()
        {
            DataRow dr;

            string str = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            SqlConnection con = new SqlConnection(str);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Employee", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            dr = dt.NewRow();
            dr.ItemArray = new object[] { 0, "--Select Employee--" };
            dt.Rows.InsertAt(dr, 0);

            guna2ComboBox1.ValueMember = "E_id";

            guna2ComboBox1.DisplayMember = "Name";
            guna2ComboBox1.DataSource = dt;

            con.Close();
        }
        public void Empdata()
        {
            DataRow dr;

            string str = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            SqlConnection con = new SqlConnection(str);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Employee", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            dr = dt.NewRow();
            dr.ItemArray = new object[] { 0, "--Select Employee--" };
            dt.Rows.InsertAt(dr, 0);

            guna2ComboBox2.ValueMember = "E_id";

            guna2ComboBox2.DisplayMember = "Name";
            guna2ComboBox2.DataSource = dt;

            con.Close();
        }
        public void Customerdata()
        {
            DataRow dr;

            string str = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            SqlConnection con = new SqlConnection(str);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Customer", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            dr = dt.NewRow();
            dr.ItemArray = new object[] { 0, "--Select Customer--" };
            dt.Rows.InsertAt(dr, 0);

            guna2ComboBox4.ValueMember = "cust_id";

            guna2ComboBox4.DisplayMember = "cust_name";
            guna2ComboBox4.DataSource = dt;

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

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void LinkforProductList_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CustOrderProDetails custOrderProDetails = new CustOrderProDetails();
            custOrderProDetails.ShowDialog();
            this.Hide();
        }

        private void DoneBtnForStkOdr_Click(object sender, EventArgs e)
        {
            Orders orders = new Orders();
            orders.ShowDialog();
            this.Hide();
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string str = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd;

            if (SignupEmailTextbox.Text != "" && guna2TextBox1.Text != "" )
            {
                cmd = new SqlCommand("insert into Cust_Order_booking (cust_order_id,cust_order_invoiceno,cust_id,E_id,entry_datetime) values(@id,@invoice,@customer,@employee,@datetime)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@invoice", SignupEmailTextbox.Text);
                cmd.Parameters.AddWithValue("@id", guna2TextBox1.Text);
                cmd.Parameters.AddWithValue("@datetime", DateTime.Now.ToString("dddd , dd-MM-yyyy , hh:mm:ss"));
                int index = guna2ComboBox4.FindString(guna2ComboBox4.Text);
                if (index == 0)
                {
                    MessageBox.Show("Customer not found.");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@customer", guna2ComboBox4.SelectedValue);
                    index = guna2ComboBox1.FindString(guna2ComboBox1.Text);
                    if (index == 0)
                    {
                        MessageBox.Show("Employee not found.");
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@employee", guna2ComboBox1.SelectedValue);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Order Booking Details Added.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string str = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd;

            if (guna2TextBox4.Text != "" && guna2TextBox5.Text != "" && guna2TextBox19.Text != "")
            {
                cmd = new SqlCommand("insert into Cust_Order_payment (cust_pay_id,payment_medium,E_id,cust_order_invoiceno,cust_order_id,payment_amount,entry_datetime) values(@id,@medium,@employee,@invoice,@orderid,@amount,@datetime)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", guna2TextBox19.Text);
                cmd.Parameters.AddWithValue("@medium", guna2TextBox5.Text);
                cmd.Parameters.AddWithValue("@amount", guna2TextBox4.Text);
                cmd.Parameters.AddWithValue("@datetime", DateTime.Now.ToString("dddd , dd-MM-yyyy , hh:mm:ss"));
                cmd.Parameters.AddWithValue("@orderid", guna2TextBox2.Text);
                int index = guna2ComboBox2.FindString(guna2ComboBox2.Text);
                    if (index == 0)
                    {
                        MessageBox.Show("Employee not found.");
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@employee", guna2ComboBox2.SelectedValue);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Payment Details Added.");
                    
                    }
            }
            
        }

        private void guna2TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Digits only!");
            }
        }

        private void SignupEmailTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Digits only!");
            }
        }

        private void guna2TextBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Digits only!");
            }
        }

        private void guna2TextBox19_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Digits only!");
            }
        }

        private void guna2TextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Digits only!");
            }
        }

        private void guna2TextBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            if (!Char.IsLetter(ch) && ch != 8 && !Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Letters only!");
            }
        }

        private void OrdersButton_Click(object sender, EventArgs e)
        {

        }

        private void CustOrderViewGridinOrd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CustomerOrderData_Load(object sender, EventArgs e)
        {
            string str = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            SqlConnection con = new SqlConnection(str);
            con.Open();
            string query = "select * from Cust_OrderDetailsview";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            //ExpenseGridView.DataSource = dt;
            con.Close();
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            CustomerInvoice companyInvoice = new CustomerInvoice();
            companyInvoice.ShowDialog();
            this.Hide();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void ExpenseGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
           CustomerOrderData cd = new CustomerOrderData();
            cd.Refresh();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
