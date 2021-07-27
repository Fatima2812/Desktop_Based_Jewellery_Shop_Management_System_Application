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
    public partial class ExpenseData : Form
    {
        public ExpenseData()
        {
            InitializeComponent();
            Employeedata();
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

            guna2ComboBox2.ValueMember = "E_id";

            guna2ComboBox2.DisplayMember = "Name";
            guna2ComboBox2.DataSource = dt;

            con.Close();
        }
        private void CrossButton_Click(object sender, EventArgs e)
        {
            Expenses expenses = new Expenses();
            expenses.ShowDialog();
            this.Hide();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {

            string str = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd;

            if (guna2TextBox26.Text != "" && guna2TextBox25.Text != "" && guna2TextBox20.Text != "" && guna2ComboBox2.Text != "")
            {
                cmd = new SqlCommand("update Daily_Expense set expense_id=@id,expense_type=@type,description=@description,expense_amount=@amount,E_id=@empid,entry_datetime=@datetime where expense_id=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", guna2TextBox26.Text);
                cmd.Parameters.AddWithValue("@type", guna2TextBox25.Text);
                cmd.Parameters.AddWithValue("@description", guna2TextBox24.Text);
                cmd.Parameters.AddWithValue("@amount", guna2TextBox20.Text);
                cmd.Parameters.AddWithValue("@datetime", guna2TextBox1.Text);
                int index = guna2ComboBox2.FindString(guna2ComboBox2.Text);
                if (index == 0)
                {
                    EmployeeNotFoundMessage ep = new EmployeeNotFoundMessage();
                    ep.ShowDialog();
                }
                else
                {
                    cmd.Parameters.AddWithValue("@empid", guna2ComboBox2.SelectedValue);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    UpdatedExpenseMessage updateExpense = new UpdatedExpenseMessage();
                    updateExpense.ShowDialog();
                    this.Hide();
                }
            }
            else
            {
                stockprovidedetails pd = new stockprovidedetails();
                pd.ShowDialog();
            }
            
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete record?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string str = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
                SqlConnection con = new SqlConnection(str);
                SqlCommand cmd;
                cmd = new SqlCommand("delete Daily_Expense where expense_id = '" + guna2TextBox26.Text + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                DeleteExpense deleteExpense = new DeleteExpense();
                deleteExpense.ShowDialog();
                this.Hide();
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

        private void guna2TextBox1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void guna2TextBox24_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            if (!Char.IsLetter(ch) && ch != 8 && !Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                Stocklettermessage s = new Stocklettermessage();
                s.ShowDialog();
            }
        }

        private void guna2TextBox20_KeyPress(object sender, KeyPressEventArgs e)
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
