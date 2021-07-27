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
    public partial class CompanyReportViewer : Form
    {
        public CompanyReportViewer()
        {
            InitializeComponent();
            this.Controls.Add(this.reportViewer1);
        }

        private void CrossButton_Click(object sender, EventArgs e)
        {
            Company company = new Company();
            company.ShowDialog(); this.Hide();
        }

        private void CompanyReportViewer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Jewelry_management_database_finalDataSet4.Supplier' table. You can move, or remove it, as needed.
            this.SupplierTableAdapter.Fill(this.Jewelry_management_database_finalDataSet4.Supplier);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
