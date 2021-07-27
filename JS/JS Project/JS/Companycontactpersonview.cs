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
    public partial class Companycontactpersonview : Form
    {
        public Companycontactpersonview()
        {
            InitializeComponent();
        }
        private void Datagrid()
        {
            string str = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("select * from Supp_cont_person", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            GridView.DataSource = dt;
            GridView.Columns[0].HeaderText = "ID";
            GridView.Columns[1].HeaderText = "Mobile No. 1";
            GridView.Columns[2].HeaderText = "Mobile No. 2";
            GridView.Columns[3].HeaderText = "Name";
            GridView.Columns[4].HeaderText = "Email";
            GridView.Columns[5].HeaderText = "Supplier";
            GridView.Columns[6].HeaderText = "Created";
        }
        private void CrossButton_Click(object sender, EventArgs e)
        {
            Company c = new Company();
            c.ShowDialog();
            this.Hide();
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            companydetailsview cd = new companydetailsview();
            cd.ShowDialog();
            this.Hide();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            string str = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("select * from Supp_cont_person where Sup_id like '" + guna2TextBox1.Text + "%'", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            GridView.DataSource = dt;
            con.Close();
        }

        private void ExpenseGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CompanyContactPerson up = new CompanyContactPerson();
            up.guna2TextBox26.Text = this.GridView.CurrentRow.Cells[0].Value.ToString();
            up.guna2TextBox24.Text = this.GridView.CurrentRow.Cells[1].Value.ToString();
            up.guna2TextBox23.Text = this.GridView.CurrentRow.Cells[2].Value.ToString();
            up.guna2TextBox25.Text = this.GridView.CurrentRow.Cells[3].Value.ToString();
            up.guna2TextBox18.Text = this.GridView.CurrentRow.Cells[4].Value.ToString();
            up.guna2TextBox21.Text = this.GridView.CurrentRow.Cells[6].Value.ToString();
            up.guna2ComboBox2.SelectedValue = this.GridView.CurrentRow.Cells[5].Value.ToString();
            up.ShowDialog();
        }

        private void Companycontactpersonview_Load(object sender, EventArgs e)
        {
            Datagrid();
        }
    }
}
