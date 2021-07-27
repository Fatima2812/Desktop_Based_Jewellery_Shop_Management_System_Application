using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace JS
{
    public partial class AddBrand : Form
    {
        public AddBrand()
        {
            InitializeComponent();
            Categorydata();
            Supplierdata();
            Autoprimarykey();
        }
        public void Autoprimarykey()
        {
            int a;
            string str = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            SqlConnection con = new SqlConnection(str);
            con.Open();
            string query = "Select Max(proType_id) from Product_Type";
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
        public void Categorydata()
        {
            DataRow dr;

            string str = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            SqlConnection con = new SqlConnection(str);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Product_Category", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            dr = dt.NewRow();
            dr.ItemArray = new object[] { 0, "--Select Category--" };
            dt.Rows.InsertAt(dr, 0);

            guna2ComboBox2.ValueMember = "proCat_id";

            guna2ComboBox2.DisplayMember = "proCatName";
            guna2ComboBox2.DataSource = dt;

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
            dr.ItemArray = new object[] { 0, "--Select Company--" };
            dt.Rows.InsertAt(dr, 0);

            guna2ComboBox1.ValueMember = "Sup_id";

            guna2ComboBox1.DisplayMember = "Sup_name";
            guna2ComboBox1.DataSource = dt;

            con.Close();
        }

        private void UpdatebrandData_Click(object sender, EventArgs e)
        {
          
        }

        private void CrossButton_Click(object sender, EventArgs e)
        {
            Brands brands = new Brands();
            brands.ShowDialog();
            this.Hide();
        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void AddCustBtnOnAddCustWindow_Click(object sender, EventArgs e)
        {
            string str = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd;

            if (SignupEmailTextbox.Text != "" && guna2TextBox1.Text != "" && guna2TextBox3.Text != "" && guna2TextBox4.Text != "" && guna2TextBox5.Text != ""  && guna2ComboBox1.Text != "")
            {
                cmd = new SqlCommand("insert into Product_Type (proType_id,proTypeName,Description,proTypeSizeAvailable,proColorAvailable,proTypeQuantity,proCat,Sup_id,entry_datetime) " +
                    "values(@id,@name,@description,@size,@color,@quantity,@category,@supplier,@datetime)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", SignupEmailTextbox.Text);
                cmd.Parameters.AddWithValue("@name", guna2TextBox1.Text);
                cmd.Parameters.AddWithValue("@description", guna2TextBox2.Text);
                cmd.Parameters.AddWithValue("@size", guna2TextBox3.Text);
                cmd.Parameters.AddWithValue("@color", guna2TextBox4.Text);
                cmd.Parameters.AddWithValue("@quantity", guna2TextBox5.Text);
                cmd.Parameters.AddWithValue("@datetime", DateTime.Now.ToString("dddd , dd-MM-yyyy , hh:mm:ss"));
                int index = guna2ComboBox2.FindString(guna2ComboBox2.Text);
                if (index == 0)
                {
                    CategoryNotFoundMessage c = new CategoryNotFoundMessage();
                    c.ShowDialog();
                }
                else
                {
                    cmd.Parameters.AddWithValue("@category", guna2ComboBox2.SelectedValue);
                    index = guna2ComboBox1.FindString(guna2ComboBox1.Text);
                    if (index == 0)
                    {
                        SupplierNotFoundDetailsMesaage s = new SupplierNotFoundDetailsMesaage();
                        s.ShowDialog();
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@supplier", guna2ComboBox1.SelectedValue);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        BrandAddedMessage brandAdded = new BrandAddedMessage();
                        brandAdded.ShowDialog();
                    }
                }
            }
            else
            {
                ProvideDetailsMessage p = new ProvideDetailsMessage();
                p.ShowDialog();
            }
        }

        private void SignupEmailTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            if (!Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageboxID m = new MessageboxID();
                m.ShowDialog();
            }
        }

        private void guna2TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            if (!Char.IsLetter(ch) && ch != 8 && !Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                EnterLettersMessage l = new EnterLettersMessage();
                l.ShowDialog();
            }
        }

        private void guna2TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            if (!Char.IsLetter(ch) && ch != 8 && !Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                EnterLettersMessage l = new EnterLettersMessage();
                l.ShowDialog();
            }
        }

        private void guna2TextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                EnterDigitsOnlyMessage d = new EnterDigitsOnlyMessage();
                d.ShowDialog();
            }
        }

        private void guna2TextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                EnterDigitsOnlyMessage d = new EnterDigitsOnlyMessage();
                d.ShowDialog();
            }
        }

        private void guna2TextBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                EnterDigitsOnlyMessage d = new EnterDigitsOnlyMessage();
                d.ShowDialog();
            }
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddBrand_Load(object sender, EventArgs e)
        {

        }
    }
}
