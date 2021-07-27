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
    public partial class ProductData : Form
    {
        public ProductData()
        {
            InitializeComponent();
            Categorydata();
            Typedata();
            Supplierdata();
            Divisionrdata();
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

            SignupAccountTypeCombobox.ValueMember = "proCat_id";

            SignupAccountTypeCombobox.DisplayMember = "proCatName";
            SignupAccountTypeCombobox.DataSource = dt;

            con.Close();
        }
        public void Typedata()
        {
            DataRow dr;

            string str = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            SqlConnection con = new SqlConnection(str);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Product_Type", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            dr = dt.NewRow();
            dr.ItemArray = new object[] { 0, "--Select Brand--" };
            dt.Rows.InsertAt(dr, 0);

            guna2ComboBox3.ValueMember = "proType_id";

            guna2ComboBox3.DisplayMember = "proTypeName";
            guna2ComboBox3.DataSource = dt;

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
        public void Divisionrdata()
        {
            guna2ComboBox1.Items.Add("Women");
            guna2ComboBox1.Items.Add("Children");
        }
        private void CrossButton_Click(object sender, EventArgs e)
        {
            Products products = new Products();
            products.ShowDialog();
            this.Hide();
        }

        private void UpdateStockBtn_Click(object sender, EventArgs e)
        {
            string str = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd;

            if (SignupEmailTextbox.Text != "" && guna2TextBox2.Text != "" && guna2TextBox10.Text != "" && guna2TextBox8.Text != "" && guna2TextBox11.Text != "" && guna2ComboBox1.Text != "")
            {
                cmd = new SqlCommand("Update Product set product_id=@id,productName=@name,Description=@description,pro_size=@size,pro_color=@color,pro_quantity=@quantity,proCat=@category,proType_id=@type,pro_divsion=@division,Sup_id=@supplier,pro_unitprice=@unitprice,entry_datetime=@datetime where product_id=@id",con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", SignupEmailTextbox.Text);
                cmd.Parameters.AddWithValue("@name", guna2TextBox2.Text);
                cmd.Parameters.AddWithValue("@description", guna2TextBox1.Text);
                cmd.Parameters.AddWithValue("@division", guna2ComboBox1.Text);
                cmd.Parameters.AddWithValue("@color", guna2TextBox11.Text);
                cmd.Parameters.AddWithValue("@quantity", guna2TextBox10.Text);
                cmd.Parameters.AddWithValue("@unitprice", guna2TextBox8.Text);
                cmd.Parameters.AddWithValue("@size", guna2TextBox3.Text);
                cmd.Parameters.AddWithValue("@datetime", guna2TextBox4.Text);
                int index = SignupAccountTypeCombobox.FindString(SignupAccountTypeCombobox.Text);
                if (index == 0)
                {
                    stockselectcategory st = new stockselectcategory();
                    st.ShowDialog();
                }
                else
                {
                    cmd.Parameters.AddWithValue("@category", SignupAccountTypeCombobox.SelectedValue);
                    index = guna2ComboBox2.FindString(guna2ComboBox2.Text);
                    if (index == 0)
                    {
                        stockselectsupplier sp = new stockselectsupplier();
                        sp.ShowDialog();
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@supplier", guna2ComboBox2.SelectedValue);
                        index = guna2ComboBox3.FindString(guna2ComboBox3.Text);
                        if (index == 0)
                        {
                            ProductTypeNotFoundMessage b = new ProductTypeNotFoundMessage();
                            b.ShowDialog();
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@type", guna2ComboBox3.SelectedValue);
                            cmd.ExecuteNonQuery();
                            con.Close();
                            UpdateProductMessage updateProductMessage = new UpdateProductMessage();
                            updateProductMessage.ShowDialog();
                            this.Hide();
                        }
                    }
                }
            }
            else
            {
                stockprovidedetails pd = new stockprovidedetails();
                pd.ShowDialog();
            }
            
        }

        private void DeleteStockBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete record?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string str = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
                SqlConnection con = new SqlConnection(str);
                SqlCommand cmd;
                cmd = new SqlCommand("delete Product where product_id = '" + SignupEmailTextbox.Text + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                DeleteProduct deleteProduct = new DeleteProduct();
                deleteProduct.ShowDialog();
                this.Hide();
            }
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
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

        private void guna2TextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            if (!Char.IsWhiteSpace(ch))
            {
                e.Handled = true;
                stocknotchangeable snc = new stocknotchangeable();
                snc.ShowDialog();
            }
        }

        private void guna2TextBox11_KeyPress(object sender, KeyPressEventArgs e)
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

        private void guna2TextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
                Stockfloateddigits af = new Stockfloateddigits();
                af.ShowDialog();
            }
        }

        private void guna2TextBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                stockdigitsonly sd = new stockdigitsonly();
                sd.ShowDialog();
            }
        }

        private void guna2TextBox8_KeyPress(object sender, KeyPressEventArgs e)
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
