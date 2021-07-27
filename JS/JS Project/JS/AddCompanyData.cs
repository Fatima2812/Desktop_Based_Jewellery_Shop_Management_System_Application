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
    public partial class AddCompanyData : Form
    {
        public AddCompanyData()
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
            string query = "Select Max(Sup_id) from Supplier";
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
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            AddCompanyData addcompanyData = new AddCompanyData();
            addcompanyData.ShowDialog();
            this.Hide();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            AddCompanyContactDetails addcompanyContactDetails = new AddCompanyContactDetails();
            addcompanyContactDetails.ShowDialog();
            this.Hide();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            AddContactPerson addContactPerson = new AddContactPerson();
            addContactPerson.ShowDialog();
            this.Hide();
        }

        private void CrossButton_Click(object sender, EventArgs e)
        {
            Company company = new Company();
            company.ShowDialog();
            this.Hide();
        }

        private void AddCustBtnOnAddCustWindow_Click(object sender, EventArgs e)
        {
            string str = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd;

            if (SignupEmailTextbox.Text != "" && guna2TextBox1.Text != "" && guna2TextBox2.Text != "" && guna2TextBox5.Text != "" && guna2TextBox6.Text != "" && guna2TextBox7.Text != "")
            {
                cmd = new SqlCommand("insert into Supplier (Sup_id,Sup_name,Org_name,Reg_no,ISO_no,Sup_add,city,country,entry_datetime) values(@id,@name,@orgno,@Regno,@isono,@address,@city,@country,@datetime)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", SignupEmailTextbox.Text);
                cmd.Parameters.AddWithValue("@name", guna2TextBox1.Text);
                cmd.Parameters.AddWithValue("@orgno", guna2TextBox2.Text);
                cmd.Parameters.AddWithValue("@regno", guna2TextBox3.Text);
                cmd.Parameters.AddWithValue("@isono", guna2TextBox4.Text);
                cmd.Parameters.AddWithValue("@address", guna2TextBox5.Text);
                cmd.Parameters.AddWithValue("@city", guna2TextBox6.Text);
                cmd.Parameters.AddWithValue("@country", guna2TextBox7.Text);
                cmd.Parameters.AddWithValue("@datetime", DateTime.Now.ToString("dddd , dd-MM-yyyy , hh:mm:ss"));
                cmd.ExecuteNonQuery();
                con.Close();
                CompanyAddedMessagebox companyAddedMessagebox = new CompanyAddedMessagebox();
                companyAddedMessagebox.ShowDialog();
                this.Hide();

            }
            else
            {
                stockprovidedetails pd = new stockprovidedetails();
                pd.ShowDialog();
            }
            
        }

        private void AddCompanyData_Load(object sender, EventArgs e)
        {
          
        }

        private void SignupEmailTextbox_TextChanged(object sender, EventArgs e)
        {
            
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

        private void guna2TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            if (!Char.IsLetter(ch) && ch != 8 && !Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                Stocklettermessage s = new Stocklettermessage();
                s.ShowDialog();
            }
        }

        private void guna2TextBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            if (!Char.IsLetter(ch) && ch != 8 && !Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                Stocklettermessage s = new Stocklettermessage();
                s.ShowDialog();
            }
        }

        private void guna2TextBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            if (!Char.IsLetter(ch) && ch != 8 && !Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                Stocklettermessage s = new Stocklettermessage();
                s.ShowDialog();
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
    }
}
