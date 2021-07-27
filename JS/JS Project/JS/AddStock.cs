using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace JS
{
    public partial class AddStock : Form
    {
        public AddStock()
        {
            InitializeComponent();
            Categorydata();
            Typedata();
            Supplierdata();
            Productdata();
            Employeedata();
            Remainingpaymentdata();
            Autoprimarykey();
        }
        public void Autoprimarykey()
        {
            int a;
            string str = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            SqlConnection con = new SqlConnection(str);
            con.Open();
            string query = "Select Max(st_id) from STOCK";
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

            guna2ComboBox1.ValueMember = "proType_id";

            guna2ComboBox1.DisplayMember = "proTypeName";
            guna2ComboBox1.DataSource = dt;

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
        public void Productdata()
        {
            DataRow dr;

            string str = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            SqlConnection con = new SqlConnection(str);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Product", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            dr = dt.NewRow();
            dr.ItemArray = new object[] { 0, "--Select Product--" };
            dt.Rows.InsertAt(dr, 0);

            guna2ComboBox3.ValueMember = "product_id";

            guna2ComboBox3.DisplayMember = "productName";
            guna2ComboBox3.DataSource = dt;

            con.Close();
        }
        public void Employeedata()
        {
            DataRow dr;

            string str = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            SqlConnection con = new SqlConnection(str);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Employee", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            dr = dt.NewRow();
            dr.ItemArray = new object[] { 0, "--Select Employee--" };
            dt.Rows.InsertAt(dr, 0);

            guna2ComboBox4.ValueMember = "E_id";

            guna2ComboBox4.DisplayMember = "Name";
            guna2ComboBox4.DataSource = dt;

            con.Close();
        }
        public void Remainingpaymentdata()
        {
            guna2ComboBox5.Items.Add("Unfulfilled");
            guna2ComboBox5.Items.Add("Pending");
            guna2ComboBox5.Items.Add("Fulfilled");
        }
        private void AddCustBtnOnAddCustWindow_Click(object sender, EventArgs e)
        {
            string str = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd;

            if (SignupEmailTextbox.Text != "" && guna2TextBox1.Text != "" && guna2TextBox2.Text != "" && guna2ComboBox5.Text != "")
            {
                cmd = new SqlCommand("insert into STOCK (st_id,sup_id,st_quantity,st_price,stockin_by,product_name,pro_cat,pro_type,sku,discount,remaining_payment,entry_datetime) values(@id,@supplier,@quantity,@price,@employee,@product,@category,@type,@sku,@discount,@remaining,@datetime)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", SignupEmailTextbox.Text);
                cmd.Parameters.AddWithValue("@discount", guna2TextBox10.Text);
                cmd.Parameters.AddWithValue("@price", guna2TextBox1.Text);
                cmd.Parameters.AddWithValue("@remaining", guna2ComboBox5.Text);
                cmd.Parameters.AddWithValue("@sku", guna2TextBox11.Text);
                cmd.Parameters.AddWithValue("@quantity", guna2TextBox2.Text);
                cmd.Parameters.AddWithValue("@datetime", DateTime.Now.ToString("dddd , dd-MM-yyyy , hh:mm:ss"));
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
                        index = guna2ComboBox1.FindString(guna2ComboBox1.Text);
                        if (index == 0)
                        {
                            ProductTypeNotFoundMessage b = new ProductTypeNotFoundMessage();
                            b.ShowDialog();
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@type", guna2ComboBox1.SelectedValue);
                            index = guna2ComboBox3.FindString(guna2ComboBox3.Text);
                            if (index == 0)
                            {
                                SelectProductMessage p = new SelectProductMessage();
                                p.ShowDialog();
                            }
                            else
                            {
                                cmd.Parameters.AddWithValue("@product", guna2ComboBox3.Text);
                                index = guna2ComboBox4.FindString(guna2ComboBox4.Text);
                                if (index == 0)
                                {
                                    EmployeeNotFoundMessage ep = new EmployeeNotFoundMessage();
                                    ep.ShowDialog();
                                }
                                else
                                {
                                    cmd.Parameters.AddWithValue("@employee", guna2ComboBox4.SelectedValue);
                                    cmd.ExecuteNonQuery();
                                    con.Close();
                                    ProductAddedMesageBox productAddedMesageBox = new ProductAddedMesageBox();
                                    productAddedMesageBox.ShowDialog();
                                    this.Hide();
                                }
                            }
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

        private void CrossButton_Click(object sender, EventArgs e)
        {
            Stock stock = new Stock();
            stock.ShowDialog();
            this.Hide();
        }

        private void MakeOrderBtnOnAddCust_Click(object sender, EventArgs e)
        {
            StockOrder stockOrder = new StockOrder();
            stockOrder.ShowDialog();
            this.Hide();

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

        private void guna2TextBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
                Stockfloateddigits af = new Stockfloateddigits();
                af.ShowDialog();
            }
        }

        private void guna2TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                stockdigitsonly sd = new stockdigitsonly();
                sd.ShowDialog();
            }
        }

        private void guna2TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                stockdigitsonly sd = new stockdigitsonly();
                sd.ShowDialog();
            }
        }

        private void AddStock_Load(object sender, EventArgs e)
        {
            
        }
    }
}
