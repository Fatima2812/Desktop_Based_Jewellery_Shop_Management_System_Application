using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Threading;

namespace JS
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            Thread t = new Thread(new ThreadStart(splash));
            t.Start();
            Thread.Sleep(7000);

            InitializeComponent();

            

        t.Abort();
            
        }

        public void splash()
        {
            Application.Run(new SplashScreen());
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {

            try
            {
                if (!(loginEmailTextbox.Text == string.Empty))
                {
                    if (!(loginPasswordTextBox.Text == string.Empty))
                    {
                        string str = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
                        SqlConnection con = new SqlConnection(str);
                        String query = "select * from Signup where username = '" + loginEmailTextbox.Text + "'and password = '" + loginPasswordTextBox.Text + "'";
                        SqlCommand cmd = new SqlCommand(query, con);
                        SqlDataReader dbr;
                        DataTable dt = new DataTable();
                        con.Open();
                        dbr = cmd.ExecuteReader();
                        int count = 0;
                        while (dbr.Read())
                        {
                            count += 1;
                        }
                        if (count == 1)
                        {
                            con.Close();
                            cmd = new SqlCommand("insert into use_login (Username,entry_datetime) values(@name,@datetime)", con);
                            con.Open();
                            cmd.Parameters.AddWithValue("@name", loginEmailTextbox.Text);
                            cmd.Parameters.AddWithValue("@datetime", DateTime.Now.ToString("dddd , dd-MM-yyyy , hh:mm:ss"));
                            cmd.ExecuteNonQuery();
                            con.Close();
                            session.username = loginEmailTextbox.Text;
                            MAIN main = new MAIN();
                            main.ShowDialog();
                            this.Hide();
                        }
                        else if (count > 1)
                        {
                            MessageBox.Show("Duplicate username or password", "login page");
                        }
                        else
                        {
                            MessageBox.Show(" username or password incorrect", "login page");
                        }
                    }
                    else
                    {
                        MessageBox.Show(" password empty", "login page");
                    }
                }
                else
                {
                    MessageBox.Show(" username empty", "login page");
                }
                // con.Close();  
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }







        private void LogIn_Load(object sender, EventArgs e)
        { 
            loginEmailTextbox.Text = "Username";
            loginPasswordTextBox.Text = "Password";

        }

        private void loginEmailTextbox_TextChanged(object sender, EventArgs e)
        {



        }

        private void loginPasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        // The code written in leave and enter functions below is for Hint text 
        private void loginEmailTextbox_Leave(object sender, EventArgs e)
        {
            if (loginEmailTextbox.Text == "")
            {
                loginEmailTextbox.Text = "Username";
                loginEmailTextbox.ForeColor = Color.Gray;
            }
        }

        private void loginPasswordTextBox_Leave(object sender, EventArgs e)
        {
            if (loginPasswordTextBox.Text == "")
            {
                loginPasswordTextBox.Text = "Password";
                loginPasswordTextBox.ForeColor = Color.Gray;
            }
        }

        private void loginEmailTextbox_Enter(object sender, EventArgs e)
        {
            if (loginEmailTextbox.Text == "Username")
            {
                loginEmailTextbox.Text = null;
                loginEmailTextbox.ForeColor = Color.Black;
            }
        }

        private void loginPasswordTextBox_Enter(object sender, EventArgs e)
        {
            if (loginPasswordTextBox.Text == "Password")
            {
                loginPasswordTextBox.Text = null;
                loginPasswordTextBox.ForeColor = Color.Black;
            }
        }
        // till here.
        private void Signuplink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.ShowDialog();
            this.Hide();
        }

        private void loginEmailTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            if (!Char.IsLetter(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Letters only!");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword forgotPassword = new ForgotPassword();
            forgotPassword.ShowDialog();
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

