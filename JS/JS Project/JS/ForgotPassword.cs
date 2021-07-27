using System;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace JS
{
    public partial class ForgotPassword : Form
    {
        string randomcode;
        public static string to;
        
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void UpdatebrandData_Click(object sender, EventArgs e)
        {
            string from, pass, messageeBody;
            Random rand = new Random();
            randomcode = (rand.Next(999999)).ToString();
            MailMessage message = new MailMessage();
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            to = SignupEmailTextbox.Text.Trim().ToString();
            from = "jawellaryshop15@gmail.com";
            pass = "";
            messageeBody = "Your reset code is " + randomcode;
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messageeBody;
            message.Subject = "Password reseting code";
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);

            try
            {
                smtp.Send(message);
                ForgotPassMessage forgotPassMessage = new ForgotPassMessage();
                forgotPassMessage.ShowDialog();
                this.Hide();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CrossButton_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.ShowDialog();
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(randomcode == (guna2TextBox1.Text).ToString())
            {
                to = SignupEmailTextbox.Text;
                ChangePassword changePassword = new ChangePassword();
                changePassword.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Code");
            }
        }
    }
}
