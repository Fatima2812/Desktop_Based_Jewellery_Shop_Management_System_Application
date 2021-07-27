using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JS
{
    public partial class CustomerReportViewer : Form
    {
        public CustomerReportViewer()
        {
            InitializeComponent();
        }

        private void CrossButton_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers();
            customers.ShowDialog();
            this.Hide();
        }

        private void CustomerReportViewer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Jewelry_management_database_finalDataSet5.Customer' table. You can move, or remove it, as needed.
            this.CustomerTableAdapter.Fill(this.Jewelry_management_database_finalDataSet5.Customer);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

     
        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
