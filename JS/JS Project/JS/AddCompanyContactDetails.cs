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
    public partial class AddCompanyContactDetails : Form
    {
        public AddCompanyContactDetails()
        {
            InitializeComponent();
            Supplierdata();
            Autoprimarykey();
        }
        public void Autoprimarykey()
        {
            int a;
            string str = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            SqlConnection con = new SqlConnection(str);
            con.Open();
            string query = "Select Max(SC_id) from Supp_cont_details";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string val = dr[0].ToString();
                if (val == "")
                {
                    guna2TextBox17.Text = "1";
                }
                else
                {
                    a = Convert.ToInt32(dr[0].ToString());
                    a += 1;
                    guna2TextBox17.Text = a.ToString();
                }
            }
            con.Close();
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

            guna2ComboBox2.DisplayMember = "Sup_id";
            guna2ComboBox2.DataSource = dt;

            con.Close();
        }
        private void AddCompanyContactDetials_Click(object sender, EventArgs e)
        {
            string str = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd;

            if (guna2TextBox15.Text != "" )
            {
                cmd = new SqlCommand("insert into Supp_cont_details (SC_id,SC_Tollfree_no,SC_Mobileno1,SC_Mobileno2,SC_landlineno,SC_email,postalcode,Sup_id,entry_datetime) values(@id,@tollfree,@mobileno1,@mobileno2,@landlineno,@email,@postal,@supid,@datetime)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", guna2TextBox17.Text);
                cmd.Parameters.AddWithValue("@tollfree", guna2TextBox16.Text);
                cmd.Parameters.AddWithValue("@mobileno1", guna2TextBox15.Text);
                cmd.Parameters.AddWithValue("@mobileno2", guna2TextBox14.Text);
                cmd.Parameters.AddWithValue("@landlineno", guna2TextBox13.Text);
                cmd.Parameters.AddWithValue("@email", guna2TextBox10.Text);
                cmd.Parameters.AddWithValue("@postal", guna2TextBox9.Text);
                cmd.Parameters.AddWithValue("@datetime", DateTime.Now.ToString("dddd , dd-MM-yyyy , hh:mm:ss"));
                int index = guna2ComboBox2.FindString(guna2ComboBox2.Text);
                if (index == 0)
                {
                    stockselectsupplier sp = new stockselectsupplier();
                    sp.ShowDialog();
                }
                else
                {
                    cmd.Parameters.AddWithValue("@supid", guna2ComboBox2.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    CompanyAddedMessagebox company = new CompanyAddedMessagebox();
                    company.ShowDialog();
                    this.Hide();
                }
            }
            else
            {
                stockprovidedetails pd = new stockprovidedetails();
                pd.ShowDialog();
            }
             
        }

        private void CrossButton_Click(object sender, EventArgs e)
        {
            Company company = new Company();
            company.ShowDialog();
            this.Hide();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            AddCompanyData addCompanyData = new AddCompanyData();
            addCompanyData.ShowDialog();
            this.Hide();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            AddCompanyContactDetails addCompanyContactDetails = new AddCompanyContactDetails();
            addCompanyContactDetails.ShowDialog();
            this.Hide();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            AddContactPerson addContactPerson = new AddContactPerson();
            addContactPerson.ShowDialog();
            this.Hide();

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

        private void guna2TextBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void Topbar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
