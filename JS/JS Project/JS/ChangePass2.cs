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
    public partial class ChangePass2 : Form
    {
        public ChangePass2()
        {
            InitializeComponent();
        }

        private void CrossButton_Click(object sender, EventArgs e)
        {
            MAIN main = new MAIN();
            main.ShowDialog();
            this.Hide();
        }

        private void UpdatebrandData_Click(object sender, EventArgs e)
        {
            string str = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd;
            if (SignupEmailTextbox.Text != "" && guna2TextBox1.Text != "")
            {
                cmd = new SqlCommand("update Signup set password=@id where password=@u", con);
                con.Open();
                cmd.Parameters.AddWithValue("@u", SignupEmailTextbox.Text);
                cmd.Parameters.AddWithValue("@id", guna2TextBox1.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                ChangePasswordMessage changePasswordMessage = new ChangePasswordMessage(); changePasswordMessage.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("User not Found");
            }
        }
    }
}
