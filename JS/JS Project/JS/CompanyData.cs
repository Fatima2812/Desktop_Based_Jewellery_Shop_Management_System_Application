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
    public partial class CompanyData : Form
    {
        public CompanyData()
        {
            InitializeComponent();
        }

        private void CrossButton_Click(object sender, EventArgs e)
        {
            Company company = new Company();
            company.ShowDialog();
            this.Hide();

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            CompanyData companyData = new CompanyData();
            companyData.ShowDialog();
            this.Hide();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            CompanyContactInformation companyContactInformation = new CompanyContactInformation();
            companyContactInformation.ShowDialog();
            this.Hide();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            CompanyContactPerson companyContactPerson = new CompanyContactPerson();
            companyContactPerson.ShowDialog();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddCustBtnOnAddCustWindow_Click(object sender, EventArgs e)
        {
           
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string str = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd;

            if (SignupEmailTextbox.Text != "" && guna2TextBox1.Text != "" && guna2TextBox2.Text != ""  && guna2TextBox5.Text != "" && guna2TextBox6.Text != "" && guna2TextBox7.Text != "")
            {
                cmd = new SqlCommand("Update Supplier set Sup_name=@name,Org_name=@orgno,Reg_no=@regno,ISO_no=@isono,Sup_add=@address,city=@city,country=@country,entry_datetime=@datetime where Sup_id=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", SignupEmailTextbox.Text);
                cmd.Parameters.AddWithValue("@name", guna2TextBox1.Text);
                cmd.Parameters.AddWithValue("@orgno", guna2TextBox2.Text);
                cmd.Parameters.AddWithValue("@regno", guna2TextBox3.Text);
                cmd.Parameters.AddWithValue("@isono", guna2TextBox4.Text);
                cmd.Parameters.AddWithValue("@address", guna2TextBox5.Text);
                cmd.Parameters.AddWithValue("@city", guna2TextBox6.Text);
                cmd.Parameters.AddWithValue("@country", guna2TextBox7.Text);
                cmd.Parameters.AddWithValue("@datetime", guna2TextBox8.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                UpdateCompanyMessageBox updateCompanyMessageBox = new UpdateCompanyMessageBox();
                updateCompanyMessageBox.ShowDialog();
                this.Hide();
            }
        }

        private void MakeOrderBtnOnAddCust_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete record?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string str = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
                SqlConnection con = new SqlConnection(str);
                SqlCommand cmd;
                cmd = new SqlCommand("delete Supplier where Sup_id = '" + SignupEmailTextbox.Text + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                DeletedCompanyData deletedCompanyData = new DeletedCompanyData();
                deletedCompanyData.ShowDialog();
                this.Hide();
            }
        }

        private void CompanyData_Load(object sender, EventArgs e)
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

        private void guna2TextBox8_KeyPress(object sender, KeyPressEventArgs e)
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
