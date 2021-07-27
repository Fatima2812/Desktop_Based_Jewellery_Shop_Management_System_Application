using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace JS
{
    public partial class AddExpense : Form
    {
        public AddExpense()
        {
            InitializeComponent();
            Employeedata();
            Autoprimarykey();
        }
        public void Autoprimarykey()
        {
            int a;
            string str = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            SqlConnection con = new SqlConnection(str);
            con.Open();
            string query = "Select Max(expense_id) from Daily_Expense";
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

            guna2ComboBox1.ValueMember = "E_id";

            guna2ComboBox1.DisplayMember = "Name";
            guna2ComboBox1.DataSource = dt;

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

            if (guna2TextBox26.Text != "" && guna2TextBox25.Text != "" && guna2TextBox20.Text != "" && guna2ComboBox1.Text != "")
            {
                cmd = new SqlCommand("insert into Daily_Expense (expense_id,expense_type,description,expense_amount,E_id,entry_datetime) values(@id,@type,@description,@amount,@empid,@datetime)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", guna2TextBox26.Text);
                cmd.Parameters.AddWithValue("@type", guna2TextBox25.Text);
                cmd.Parameters.AddWithValue("@description", guna2TextBox24.Text);
                cmd.Parameters.AddWithValue("@amount", guna2TextBox20.Text);
                cmd.Parameters.AddWithValue("@datetime", DateTime.Now.ToString("dddd , dd-MM-yyyy , hh:mm:ss"));
                int index = guna2ComboBox1.FindString(guna2ComboBox1.Text);
                if (index == 0)
                {
                    EmployeeNotFoundMessage ep = new EmployeeNotFoundMessage();
                    ep.ShowDialog();
                }
                else
                {
                    cmd.Parameters.AddWithValue("@empid", guna2ComboBox1.SelectedValue);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    AddExpenseMessage addExpenseMessage = new AddExpenseMessage();
                    addExpenseMessage.ShowDialog();
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

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
