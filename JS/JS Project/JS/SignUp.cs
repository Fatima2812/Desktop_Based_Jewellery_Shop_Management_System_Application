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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
            Autoprimarykey();
            Divisionrdata();
            Employeedata();
        }
        public void Autoprimarykey()
        {
            int a;
            string str = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            SqlConnection con = new SqlConnection(str);
            con.Open();
            string query = "Select Max(userid) from Signup";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string val = dr[0].ToString();
                if (val == "")
                {
                    guna2TextBox1.Text = "1";
                }
                else
                {
                    a = Convert.ToInt32(dr[0].ToString());
                    a += 1;
                    guna2TextBox1.Text = a.ToString();
                }
            }
            con.Close();
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
        public void Divisionrdata()
        {
            SignupAccountTypeCombobox.Items.Add("Owner");
            SignupAccountTypeCombobox.Items.Add("Employee");
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            string str = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd;

            if (guna2TextBox1.Text != "" && SignupEmailTextbox.Text != "" && SignupPasswordTextBox.Text != "" && SignupUserNameTextBox.Text != "" && SignupPhoneNumberTextBox.Text != "" && SignupAccountTypeCombobox.Text != "")
            {
                cmd = new SqlCommand("insert into Signup (userid,username,password,email,is_owner,E_id,user_phone_number,entry_datetime) values(@id,@u,@p,@e,@i,@empid,@n,@datetime)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", guna2TextBox1.Text);
                cmd.Parameters.AddWithValue("@e", SignupEmailTextbox.Text);
                cmd.Parameters.AddWithValue("@p", SignupPasswordTextBox.Text);
                cmd.Parameters.AddWithValue("@u", SignupUserNameTextBox.Text);
                cmd.Parameters.AddWithValue("@n", SignupPhoneNumberTextBox.Text);
                cmd.Parameters.AddWithValue("@i", SignupAccountTypeCombobox.Text);
                cmd.Parameters.AddWithValue("@empid", guna2ComboBox1.SelectedValue);
                cmd.Parameters.AddWithValue("@datetime", DateTime.Now.ToString("dddd , dd-MM-yyyy , hh:mm:ss"));
                cmd.ExecuteNonQuery();
                con.Close();
                ManageUsers addExpenseMessage = new ManageUsers();
                addExpenseMessage.ShowDialog();
                this.Hide();
                
            }
            else
            {
                stockprovidedetails pd = new stockprovidedetails();
                pd.ShowDialog();
            } 
        }
         // The code written in leave and enter functions below is for Hint text 
        private void SignUp_Load(object sender, EventArgs e)
        {
            SignupEmailTextbox.Text = "Email";
           SignupPasswordTextBox.Text = "Password";
            SignupUserNameTextBox.Text = "Username";
            SignupPhoneNumberTextBox.Text = "Phone number";
        }

        private void Logo_Click(object sender, EventArgs e)
        {

        }

        private void SignupEmailTextbox_Enter(object sender, EventArgs e)
        {
            if (SignupEmailTextbox.Text == "Email")
            {
                SignupEmailTextbox.Text = null;
                SignupEmailTextbox.ForeColor = Color.Black;
            }
        }

        private void SignupEmailTextbox_Leave(object sender, EventArgs e)
        {
            if (SignupEmailTextbox.Text == "")
            {
                SignupEmailTextbox.Text = "Email";
                SignupEmailTextbox.ForeColor = Color.Gray;
            }
        }

        private void SignupPasswordTextBox_Enter(object sender, EventArgs e)
        {
            if (SignupPasswordTextBox.Text == "Password")
            {
                SignupPasswordTextBox.Text = null;
                SignupPasswordTextBox.ForeColor = Color.Black;
            }
        }

        private void SignupPasswordTextBox_Leave(object sender, EventArgs e)
        {

            if (SignupPasswordTextBox.Text == "")
            {
                SignupPasswordTextBox.Text = "Password";
                SignupPasswordTextBox.ForeColor = Color.Gray;
            }
        }
        // till here.
        private void Loginlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.ShowDialog();
            this.Hide();
        }

        private void SignupEmailTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignupUserNameTextBox_Leave(object sender, EventArgs e)
        {
            if (SignupUserNameTextBox.Text == "")
            {
                SignupUserNameTextBox.Text = "Username";
                SignupUserNameTextBox.ForeColor = Color.Gray;
            }
        }

        private void SignupUserNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignupUserNameTextBox_Enter(object sender, EventArgs e)
        {
            if (SignupUserNameTextBox.Text == "Username")
            {
                SignupUserNameTextBox.Text = null;
                SignupUserNameTextBox.ForeColor = Color.Black;
            }
        }

        private void SignupPhoneNumberTextBox_Leave(object sender, EventArgs e)
        {
            if (SignupPhoneNumberTextBox.Text == "")
            {
                SignupPhoneNumberTextBox.Text = "Phone number";
                SignupPhoneNumberTextBox.ForeColor = Color.Gray;
            }
        }

        private void SignupPhoneNumberTextBox_Enter(object sender, EventArgs e)
        {
            if (SignupPhoneNumberTextBox.Text == "Phone number")
            {
                SignupPhoneNumberTextBox.Text = null;
                SignupPhoneNumberTextBox.ForeColor = Color.Black;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string str = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd;

            if (guna2TextBox1.Text != "" && SignupEmailTextbox.Text != "" && SignupPasswordTextBox.Text != "" && SignupUserNameTextBox.Text != "" && SignupPhoneNumberTextBox.Text != "" && SignupAccountTypeCombobox.Text != "")
            {
                cmd = new SqlCommand("update Signup set userid=@id,username=@u,password=@p,E_id=@empid,email=@e,is_owner=@i,user_phone_number=@n,entry_datetime=@datetime where userid=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", guna2TextBox1.Text);
                cmd.Parameters.AddWithValue("@e", SignupEmailTextbox.Text);
                cmd.Parameters.AddWithValue("@p", SignupPasswordTextBox.Text);
                cmd.Parameters.AddWithValue("@u", SignupUserNameTextBox.Text);
                cmd.Parameters.AddWithValue("@n", SignupPhoneNumberTextBox.Text);
                cmd.Parameters.AddWithValue("@i", SignupAccountTypeCombobox.Text);
                cmd.Parameters.AddWithValue("@empid", guna2ComboBox1.SelectedValue);
                cmd.Parameters.AddWithValue("@datetime", guna2TextBox2.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                ManageUsers addExpenseMessage = new ManageUsers();
                addExpenseMessage.ShowDialog();
                this.Hide();

            }
            else
            {
                stockprovidedetails pd = new stockprovidedetails();
                pd.ShowDialog();
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete record?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string str = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
                SqlConnection con = new SqlConnection(str);
                SqlCommand cmd;
                cmd = new SqlCommand("delete Signup where userid = '" + guna2TextBox1.Text + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                ManageUsers addExpenseMessage = new ManageUsers();
                addExpenseMessage.ShowDialog();
                this.Hide();
            }
        }

        private void guna2TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            if (!Char.IsWhiteSpace(ch))
            {
                e.Handled = true;
                stocknotchangeable snc = new stocknotchangeable();
                snc.ShowDialog();
            }
        }

        private void SignupUserNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            if (!Char.IsLetter(ch) && ch != 8 && !Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                Stocklettermessage s = new Stocklettermessage();
                s.ShowDialog();
            }
        }

        private void SignupPhoneNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                stockdigitsonly sd = new stockdigitsonly();
                sd.ShowDialog();
            }
        }

        private void guna2TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            if (!Char.IsWhiteSpace(ch))
            {
                e.Handled = true;
                stocknotchangeable snc = new stocknotchangeable();
                snc.ShowDialog();
            }
        }

      

        private void CrossButton_Click_1(object sender, EventArgs e)
        {
            ManageUsers manageUsers = new ManageUsers();
            manageUsers.ShowDialog();
            this.Hide();

        }
    }
}
