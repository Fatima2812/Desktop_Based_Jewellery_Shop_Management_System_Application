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
    public partial class AddCustomer : Form
    {

        public AddCustomer()
        {
            InitializeComponent();
            Autoprimarykey();
        }
        public void Autoprimarykey()
        {
            int a;
            string str = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            SqlConnection con = new SqlConnection(str);
            con.Open();
            string query = "Select Max(cust_id) from Customer";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string val = dr[0].ToString();
                if (val == "")
                {
                    SignupEmailTextbox.Text = "1";
                }
                else
                {
                    a = Convert.ToInt32(dr[0].ToString());
                    a += 1;
                    SignupEmailTextbox.Text = a.ToString();
                }
            }
            con.Close();
        }
        private void CrossButton_Click(object sender, EventArgs e)
        {

            Customers customers = new Customers();
            customers.ShowDialog();
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

        private void DashboardPageButton_Click(object sender, EventArgs e)
        {
            MAIN main = new MAIN();
            main.ShowDialog();
            this.Hide();
        }

        private void logo_Click(object sender, EventArgs e)
        {

        }

        private void CustomersPageButton_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers();
            customers.ShowDialog();
            this.Hide();
        }

        private void AddCustBtnOnAddCustWindow_Click(object sender, EventArgs e)
        {
            string str = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd;

            if (SignupEmailTextbox.Text != "" && guna2TextBox1.Text != "" )
            {
                cmd = new SqlCommand("insert into Customer (cust_id,cust_name,cust_cnic,cust_contactNo,cust_whatsappNo,cust_email,entry_datetime) values(@id,@name,@cnic,@contact,@whatsapp,@email,@datetime)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", SignupEmailTextbox.Text);
                cmd.Parameters.AddWithValue("@name", guna2TextBox1.Text);
                cmd.Parameters.AddWithValue("@cnic", guna2TextBox2.Text);
                cmd.Parameters.AddWithValue("@contact", guna2TextBox3.Text);
                cmd.Parameters.AddWithValue("@whatsapp", guna2TextBox4.Text);
                cmd.Parameters.AddWithValue("@email", guna2TextBox5.Text);
                cmd.Parameters.AddWithValue("@datetime", DateTime.Now.ToString("dddd , dd-MM-yyyy , hh:mm:ss"));
                cmd.ExecuteNonQuery();
                con.Close();
                CustomerAddedMessageBox customerAddedMessageBox = new CustomerAddedMessageBox();
                customerAddedMessageBox.ShowDialog();
                this.Hide();

            }
            else
            {
                stockprovidedetails pd = new stockprovidedetails();
                pd.ShowDialog();
            }
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {

        }

        private void MakeOrderBtnOnAddCust_Click(object sender, EventArgs e)
        {
            CustomerOrderData customerOrderData = new CustomerOrderData();
            customerOrderData.ShowDialog();
            this.Hide();

        }

        private void SignupEmailTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            if (!Char.IsWhiteSpace(ch))
            {
                e.Handled = true;
                stocknotchangeable snc = new stocknotchangeable();
                snc.ShowDialog();
            }
        }

        private void guna2TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 45)
            {
                e.Handled = true;
                CnicFormatMessage c = new CnicFormatMessage();
                c.ShowDialog();
            }
        }

        private void guna2TextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                stockdigitsonly sd = new stockdigitsonly();
                sd.ShowDialog();
            }
        }

        private void guna2TextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                stockdigitsonly sd = new stockdigitsonly();
                sd.ShowDialog();
            }
        }

        private void guna2TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            if (!Char.IsLetter(ch) && ch != 8 && !Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                Stocklettermessage s = new Stocklettermessage();
                s.ShowDialog();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TextBox2_Leave(object sender, EventArgs e)
        {
            if (guna2TextBox2.Text == "")
            {
                guna2TextBox2.Text = "00000-0000000-0";
                guna2TextBox2.ForeColor = Color.Gray;
            }
        }

        private void guna2TextBox2_Enter(object sender, EventArgs e)
        {
            if (guna2TextBox2.Text == "00000-0000000-0")
            {
                guna2TextBox2.Text = null;
                guna2TextBox2.ForeColor = Color.Black;
            }
        }

        private void guna2TextBox3_Leave(object sender, EventArgs e)
        {
            if (guna2TextBox3.Text == "")
            {
                guna2TextBox3.Text = "03000000000";
                guna2TextBox3.ForeColor = Color.Gray;
            }
        }

        private void guna2TextBox3_Enter(object sender, EventArgs e)
        {
            if (guna2TextBox2.Text == "03000000000")
            {
                guna2TextBox2.Text = null;
                guna2TextBox2.ForeColor = Color.Black;
            }
        }

        private void guna2TextBox4_Leave(object sender, EventArgs e)
        {
            if (guna2TextBox4.Text == "")
            {
                guna2TextBox4.Text = "03000000000";
                guna2TextBox4.ForeColor = Color.Gray;
            }
        }

        private void guna2TextBox4_Enter(object sender, EventArgs e)
        {
            if (guna2TextBox4.Text == "03000000000")
            {
                guna2TextBox4.Text = null;
                guna2TextBox4.ForeColor = Color.Black;
            }
        }

        private void guna2TextBox5_Leave(object sender, EventArgs e)
        {
            if (guna2TextBox5.Text == "")
            {
                guna2TextBox5.Text = "abc123@gmail.com";
                guna2TextBox5.ForeColor = Color.Gray;
            }
        }

        private void guna2TextBox5_Enter(object sender, EventArgs e)
        {
            if (guna2TextBox5.Text == "abc123@gmail.com")
            {
                guna2TextBox5.Text = null;
                guna2TextBox5.ForeColor = Color.Black;
            }
        }
    }
}
