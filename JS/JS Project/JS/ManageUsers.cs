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
    public partial class ManageUsers : Form
    {
        public ManageUsers()
        {
            InitializeComponent();
        }

        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.ShowDialog();
            this.Hide();
        }

        private void DeleteUserBtn_Click(object sender, EventArgs e)
        {
            deleteuserpermission deleteuserpermission = new deleteuserpermission();
            deleteuserpermission.ShowDialog();
            this.Hide();
        }
        
        private void datagrid()
        {
            string str = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("select * from Signup ", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            guna2DataGridView1.DataSource = dt;
            guna2DataGridView1.Columns[0].HeaderText = "ID";
            guna2DataGridView1.Columns[1].HeaderText = "UserName";
            guna2DataGridView1.Columns[2].HeaderText = "Pasword";
            guna2DataGridView1.Columns[3].HeaderText = "Email";
            guna2DataGridView1.Columns[4].HeaderText = "Account Type";
            guna2DataGridView1.Columns[5].HeaderText = "Added by";
            guna2DataGridView1.Columns[6].HeaderText = "Phone No.";
            guna2DataGridView1.Columns[7].HeaderText = "Created";
        }
        private void CrossButton_Click(object sender, EventArgs e)
        {
            MAIN main = new MAIN();
            main.ShowDialog();
            this.Hide();
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            datagrid();
        }

        


        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            string str = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("select * from Signup where username like '" + guna2TextBox2.Text + "%'", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            con.Close();
        }


        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SignUp stockData = new SignUp();
            stockData.guna2TextBox1.Text = this.guna2DataGridView1.CurrentRow.Cells[0].Value.ToString();
            stockData.SignupUserNameTextBox.Text = this.guna2DataGridView1.CurrentRow.Cells[1].Value.ToString();
            stockData.SignupPasswordTextBox.Text = this.guna2DataGridView1.CurrentRow.Cells[2].Value.ToString();
            stockData.SignupEmailTextbox.Text = this.guna2DataGridView1.CurrentRow.Cells[3].Value.ToString();
            stockData.SignupAccountTypeCombobox.Text = this.guna2DataGridView1.CurrentRow.Cells[4].Value.ToString();
            stockData.guna2ComboBox1.SelectedValue = this.guna2DataGridView1.CurrentRow.Cells[5].Value.ToString();
            stockData.SignupPhoneNumberTextBox.Text = this.guna2DataGridView1.CurrentRow.Cells[6].Value.ToString();
            stockData.guna2TextBox2.Text = this.guna2DataGridView1.CurrentRow.Cells[7].Value.ToString();
            stockData.ShowDialog();
        }
    }
}
