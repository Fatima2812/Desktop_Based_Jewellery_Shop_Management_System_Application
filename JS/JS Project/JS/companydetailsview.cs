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
    public partial class companydetailsview : Form
    {
        public companydetailsview()
        {
            InitializeComponent();
        }
        private void Datagrid()
        {
            string str = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("select * from Supp_cont_details ", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            ExpenseGridView.DataSource = dt;
            ExpenseGridView.Columns[0].HeaderText = "ID";
            ExpenseGridView.Columns[1].HeaderText = "Tollfree No.";
            ExpenseGridView.Columns[2].HeaderText = "Mobile No. 1";
            ExpenseGridView.Columns[3].HeaderText = "Mobile No. 2";
            ExpenseGridView.Columns[4].HeaderText = "Landline No.";
            ExpenseGridView.Columns[5].HeaderText = "Email";
            ExpenseGridView.Columns[6].HeaderText = "Postal Code";
            ExpenseGridView.Columns[7].HeaderText = "Supplier";
            ExpenseGridView.Columns[8].HeaderText = "Created";
        }
        private void CrossButton_Click(object sender, EventArgs e)
        {
            Company c = new Company();
            c.ShowDialog();
            this.Hide();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Companycontactpersonview cc = new Companycontactpersonview();
            cc.ShowDialog();
            this.Hide();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            string str = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("select * from Supp_cont_details where Sup_id like '" + guna2TextBox1.Text + "%'", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            ExpenseGridView.DataSource = dt;
            con.Close();
        }

        private void companydetailsview_Load(object sender, EventArgs e)
        {
            Datagrid();
        }

        private void ExpenseGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CompanyContactInformation up = new CompanyContactInformation();
            up.guna2TextBox17.Text = this.ExpenseGridView.CurrentRow.Cells[0].Value.ToString();
            up.guna2TextBox16.Text = this.ExpenseGridView.CurrentRow.Cells[1].Value.ToString();
            up.guna2TextBox15.Text = this.ExpenseGridView.CurrentRow.Cells[2].Value.ToString();
            up.guna2TextBox14.Text = this.ExpenseGridView.CurrentRow.Cells[3].Value.ToString();
            up.guna2TextBox13.Text = this.ExpenseGridView.CurrentRow.Cells[4].Value.ToString();
            up.guna2TextBox10.Text = this.ExpenseGridView.CurrentRow.Cells[5].Value.ToString();
            up.guna2TextBox9.Text = this.ExpenseGridView.CurrentRow.Cells[6].Value.ToString();
            up.guna2ComboBox2.SelectedValue = this.ExpenseGridView.CurrentRow.Cells[7].Value.ToString();
            up.guna2TextBox12.Text = this.ExpenseGridView.CurrentRow.Cells[8].Value.ToString();
            up.ShowDialog();
        }
    }
}
