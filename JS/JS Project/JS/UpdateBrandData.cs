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
    public partial class UpdateBrandData : Form
    {
        public UpdateBrandData()
        {
            InitializeComponent();
            Categorydata();
            Supplierdata();
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
            dr.ItemArray = new object[] { 0, "--Select Supplier--" };
            dt.Rows.InsertAt(dr, 0);

            guna2ComboBox1.ValueMember = "Sup_id";

            guna2ComboBox1.DisplayMember = "Sup_name";
            guna2ComboBox1.DataSource = dt;

            con.Close();
        }
        private void CrossButton_Click(object sender, EventArgs e)
        {
            Brands brand = new Brands();
            brand.ShowDialog();
            this.Hide();
        }
        
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string str = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd;

            if (SignupEmailTextbox.Text != "" && guna2TextBox1.Text != "" && guna2TextBox3.Text != "" && guna2TextBox4.Text != "" && guna2TextBox5.Text != "" && guna2ComboBox2.Text != "" && guna2ComboBox1.Text != "")
            {
                cmd = new SqlCommand("Update Product_Type set proTypeName=@name,Description=@description,proTypeSizeAvailable=@size,proColorAvailable=@color,proTypeQuantity=@quantity,proCat=@category,Sup_id=@supplier,entry_datetime=@datetime where proType_id=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", SignupEmailTextbox.Text);
                cmd.Parameters.AddWithValue("@name", guna2TextBox1.Text);
                cmd.Parameters.AddWithValue("@description", guna2TextBox2.Text);
                cmd.Parameters.AddWithValue("@size", guna2TextBox3.Text);
                cmd.Parameters.AddWithValue("@color", guna2TextBox4.Text);
                cmd.Parameters.AddWithValue("@quantity", guna2TextBox5.Text);
                cmd.Parameters.AddWithValue("@datetime", guna2TextBox6.Text);
                int index = guna2ComboBox2.FindString(guna2ComboBox2.Text);
                if (index == 0)
                {
                    stockselectcategory st = new stockselectcategory();
                    st.ShowDialog();
                }
                else
                {
                    cmd.Parameters.AddWithValue("@category", guna2ComboBox2.SelectedValue);
                    index = guna2ComboBox1.FindString(guna2ComboBox1.Text);
                    if (index == 0)
                    {
                        stockselectsupplier sp = new stockselectsupplier();
                        sp.ShowDialog();
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@supplier", guna2ComboBox1.SelectedValue);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        UpdatedBrandMessageBox updatedBrandMessageBox = new UpdatedBrandMessageBox();
                        updatedBrandMessageBox.ShowDialog();
                        this.Hide();
                    }
                }
            }
            else
            {
                stockprovidedetails pd = new stockprovidedetails();
                pd.ShowDialog();
            }
            
        }

        private void UpdateBrandData_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete record?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string str = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
                SqlConnection con = new SqlConnection(str);
                SqlCommand cmd;
                cmd = new SqlCommand("DELETE Product_Type WHERE proType_id = '" + SignupEmailTextbox.Text + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                DeletedBrandMessagebox deletedBrandMessagebox = new DeletedBrandMessagebox();
                deletedBrandMessagebox.ShowDialog();
                this.Hide();
            }
        }

        private void SignupEmailTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            if (!Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                stocknotchangeable snc = new stocknotchangeable();
                snc.ShowDialog();
            }
        }

        private void guna2TextBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            if (!Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                stocknotchangeable snc = new stocknotchangeable();
                snc.ShowDialog();
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            
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

        private void guna2TextBox5_KeyPress(object sender, KeyPressEventArgs e)
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
