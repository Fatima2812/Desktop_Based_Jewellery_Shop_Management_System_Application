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
    public partial class CustOrderProDetails : Form
    {
        public CustOrderProDetails()
        {
            InitializeComponent();
            Productdata();
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

            SignupAccountTypeCombobox.ValueMember = "product_id";

            SignupAccountTypeCombobox.DisplayMember = "productName";
            SignupAccountTypeCombobox.DataSource = dt;

            con.Close();
        }
        private void CustOrderProDetails_Load(object sender, EventArgs e)
        {

        }

        private void CrossButton_Click(object sender, EventArgs e)
        {
            CustomerOrderData customerOrderData = new CustomerOrderData();
            customerOrderData.ShowDialog();
            this.Hide();
        }

        private void DoneBtnForStkOdr_Click(object sender, EventArgs e)
        {
            string str = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd;

            if (guna2TextBox1.Text != "" && guna2TextBox15.Text != "" && guna2TextBox13.Text != "" && guna2TextBox12.Text != "" && guna2TextBox16.Text != "")
            {
                cmd = new SqlCommand("insert into Cust_Order_detail (product_id,product_price,product_quantity,cust_order_id,cust_order_invoiceno,pro_purchase_price,discount) " +
                "values(@product,@price,@quantity,@orderid,@invoice,@purchase,@discount)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@price", guna2TextBox13.Text);
                cmd.Parameters.AddWithValue("@orderid", guna2TextBox15.Text);
                cmd.Parameters.AddWithValue("@invoice", guna2TextBox1.Text);
                cmd.Parameters.AddWithValue("@purchase", guna2TextBox12.Text);
                cmd.Parameters.AddWithValue("@discount", guna2TextBox18.Text);
                cmd.Parameters.AddWithValue("@quantity", guna2TextBox16.Text);
                int index = SignupAccountTypeCombobox.FindString(SignupAccountTypeCombobox.Text);
                if (index == 0)
                {
                    MessageBox.Show("Product not found.");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@product", SignupAccountTypeCombobox.SelectedValue);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    AddProductinCusOrderMessage addProductinCusOrderMessage = new AddProductinCusOrderMessage();
                    addProductinCusOrderMessage.ShowDialog();
                    this.Hide();
                }
            }
        
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
        }

            
        

        private void UpdateProductListBtn_Click(object sender, EventArgs e)
        {
            UpdateProductListMessageBox updateProductListMessageBox = new UpdateProductListMessageBox();
            updateProductListMessageBox.ShowDialog(); this.Hide();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            DeleteCustOrdProPermission deleteCustOrdProPermission = new DeleteCustOrdProPermission();
            deleteCustOrdProPermission.ShowDialog();
            this.Hide();
        }
    }
}
