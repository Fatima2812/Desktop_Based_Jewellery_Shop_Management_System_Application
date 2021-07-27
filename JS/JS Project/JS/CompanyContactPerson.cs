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
    public partial class CompanyContactPerson : Form
    {
        public CompanyContactPerson()
        {
            InitializeComponent();
            Supplierdata();
        }
        public void Supplierdata()
        {
            DataRow dr;

            string str = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            SqlConnection con = new SqlConnection(str);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Supplier", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            dr = dt.NewRow();
            dr.ItemArray = new object[] { 0, "--Select Supplier--" };
            dt.Rows.InsertAt(dr, 0);

            guna2ComboBox2.ValueMember = "Sup_id";

            guna2ComboBox2.DisplayMember = "Sup_name";
            guna2ComboBox2.DataSource = dt;

            con.Close();
        }
        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            CompanyData companyData = new CompanyData();
            companyData.ShowDialog();
            this.Hide();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            CompanyContactInformation companyContactInformation = new CompanyContactInformation();
            companyContactInformation.ShowDialog();
            this.Hide();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            CompanyContactPerson companyContactPerson = new CompanyContactPerson();
            companyContactPerson.ShowDialog();
            this.Hide();
        }

        private void CrossButton_Click(object sender, EventArgs e)
        {
            Company company = new Company();
            company.ShowDialog();
            this.Hide();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete record?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string str = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
                SqlConnection con = new SqlConnection(str);
                SqlCommand cmd;
                cmd = new SqlCommand("delete Supp_cont_person where SCP_id = '" + guna2TextBox26.Text + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                DeleteCompanyContactPerson deletedCompanyData = new DeleteCompanyContactPerson();
                deletedCompanyData.ShowDialog();
                this.Hide();
            }
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            string str = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd;

            if (guna2TextBox26.Text != "" && guna2TextBox25.Text != "" && guna2TextBox24.Text != "")
            {
                cmd = new SqlCommand("update Supp_cont_person set SCP_id=@id,SCP_name=@name,SCP_Mobileno1=@mobileno1,SCP_Mobileno2=@mobileno2,Sup_id=@supid,SCP_email=@email,entry_datetime=@datetime where SCP_id=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", guna2TextBox26.Text);
                cmd.Parameters.AddWithValue("@name", guna2TextBox25.Text);
                cmd.Parameters.AddWithValue("@mobileno1", guna2TextBox24.Text);
                cmd.Parameters.AddWithValue("@mobileno2", guna2TextBox23.Text);
                cmd.Parameters.AddWithValue("@email", guna2TextBox18.Text);
                cmd.Parameters.AddWithValue("@datetime", guna2TextBox21.Text);
                int index = guna2ComboBox2.FindString(guna2ComboBox2.Text);
                if (index == 0)
                {
                    stockselectsupplier sp = new stockselectsupplier();
                    sp.ShowDialog();
                }
                else
                {
                    cmd.Parameters.AddWithValue("@supid", guna2ComboBox2.SelectedValue);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    UpdateCompanyContactPerson updateCompanyMessageBox = new UpdateCompanyContactPerson();
                    updateCompanyMessageBox.ShowDialog();
                    this.Hide();
                }
            }
            else
            {
                stockprovidedetails pd = new stockprovidedetails();
                pd.ShowDialog();
            }
            
        }

        private void guna2TextBox26_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            if (!Char.IsWhiteSpace(ch))
            {
                e.Handled = true;
                stocknotchangeable snc = new stocknotchangeable();
                snc.ShowDialog();
            }
        }

        private void guna2TextBox25_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            if (!Char.IsLetter(ch) && ch != 8 && !Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                Stocklettermessage s = new Stocklettermessage();
                s.ShowDialog();
            }
        }

        private void guna2TextBox21_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            if (!Char.IsWhiteSpace(ch))
            {
                e.Handled = true;
                stocknotchangeable snc = new stocknotchangeable();
                snc.ShowDialog();
            }
        }

        private void guna2TextBox24_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                stockdigitsonly sd = new stockdigitsonly();
                sd.ShowDialog();
            }
        }

        private void guna2TextBox23_KeyPress(object sender, KeyPressEventArgs e)
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
