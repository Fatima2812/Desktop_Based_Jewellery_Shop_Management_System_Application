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
    public partial class AddContactPerson : Form
    {
        public AddContactPerson()
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
            string query = "Select Max(SCP_id) from Supp_cont_person";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string val = dr[0].ToString();
                if (val == "")
                {
                    guna2TextBox26.Text = "1";
                }
                else
                {
                    a = Convert.ToInt32(dr[0].ToString());
                    a += 1;
                    guna2TextBox26.Text = a.ToString();
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

            guna2ComboBox2.DisplayMember = "Sup_name";
            guna2ComboBox2.DataSource = dt;

            con.Close();
        }
        private void guna2Button6_Click(object sender, EventArgs e)
        {
            string str = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd;

            if (guna2TextBox26.Text != "" && guna2TextBox25.Text != "" && guna2TextBox24.Text != "" && guna2ComboBox2.Text != "" )
            {
                cmd = new SqlCommand("insert into Supp_cont_person (SCP_id,SCP_name,SCP_Mobileno1,SCP_Mobileno2,Sup_id,SCP_email,entry_datetime) values(@id,@name,@mobileno1,@mobileno2,@supid,@email,@datetime)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", guna2TextBox26.Text);
                cmd.Parameters.AddWithValue("@name", guna2TextBox25.Text);
                cmd.Parameters.AddWithValue("@mobileno1", guna2TextBox24.Text);
                cmd.Parameters.AddWithValue("@mobileno2", guna2TextBox23.Text);
                cmd.Parameters.AddWithValue("@email", guna2TextBox18.Text);
                cmd.Parameters.AddWithValue("@datetime", DateTime.Now.ToString("dddd , dd-MM-yyyy , hh:mm:ss"));
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

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            AddCompanyData addCompanyData = new AddCompanyData();
            addCompanyData.ShowDialog();
            this.Hide();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            AddCompanyContactDetails addCompanyContactDetails = new AddCompanyContactDetails();
            addCompanyContactDetails.ShowDialog();
            this.Hide();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
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

        private void AddContactPerson_Load(object sender, EventArgs e)
        {

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
    }
}
