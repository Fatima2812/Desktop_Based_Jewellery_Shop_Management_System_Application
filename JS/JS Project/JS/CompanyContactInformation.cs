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
    public partial class CompanyContactInformation : Form
    {
        public CompanyContactInformation()
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

        private void CrossButton_Click(object sender, EventArgs e)
        {
            Company company = new Company();
            company.ShowDialog();
            this.Hide();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete record?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string str = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
                SqlConnection con = new SqlConnection(str);
                SqlCommand cmd;
                cmd = new SqlCommand("delete Supp_cont_details where SC_id = '" + guna2TextBox17.Text + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Comanycontactdelete deletedCompanyData = new Comanycontactdelete();
                deletedCompanyData.ShowDialog();
                this.Hide();
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            string str = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd;

            if (guna2TextBox15.Text != "")
            {
                cmd = new SqlCommand("update Supp_cont_details set SC_id=@id,SC_Tollfree_no=@tollfree,SC_Mobileno1=@mobileno1,SC_Mobileno2=@mobileno2,SC_landlineno=@landlineno,SC_email=@email,postalcode=@postal,Sup_id=@supid,entry_datetime=@datetime where SC_id=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", guna2TextBox17.Text);
                cmd.Parameters.AddWithValue("@tollfree", guna2TextBox16.Text);
                cmd.Parameters.AddWithValue("@mobileno1", guna2TextBox15.Text);
                cmd.Parameters.AddWithValue("@mobileno2", guna2TextBox14.Text);
                cmd.Parameters.AddWithValue("@landlineno", guna2TextBox13.Text);
                cmd.Parameters.AddWithValue("@email", guna2TextBox10.Text);
                cmd.Parameters.AddWithValue("@postal", guna2TextBox9.Text);
                cmd.Parameters.AddWithValue("@datetime", guna2TextBox12.Text);
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
                    Companycontactupdate updateCompanyMessageBox = new Companycontactupdate();
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

        private void guna2TextBox17_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            if (!Char.IsWhiteSpace(ch))
            {
                e.Handled = true;
                stocknotchangeable snc = new stocknotchangeable();
                snc.ShowDialog();
            }
        }

        private void guna2TextBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            if (!Char.IsWhiteSpace(ch))
            {
                e.Handled = true;
                stocknotchangeable snc = new stocknotchangeable();
                snc.ShowDialog();
            }
        }

        private void guna2TextBox16_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                stockdigitsonly sd = new stockdigitsonly();
                sd.ShowDialog();
            }
        }

        private void guna2TextBox15_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                stockdigitsonly sd = new stockdigitsonly();
                sd.ShowDialog();
            }
        }

        private void guna2TextBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox14_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                stockdigitsonly sd = new stockdigitsonly();
                sd.ShowDialog();
            }
        }

        private void guna2TextBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                stockdigitsonly sd = new stockdigitsonly();
                sd.ShowDialog();
            }
        }

        private void guna2TextBox9_KeyPress(object sender, KeyPressEventArgs e)
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
