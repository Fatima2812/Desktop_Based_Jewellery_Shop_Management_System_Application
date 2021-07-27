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
    public partial class ProReportViewer : Form
    {
        public ProReportViewer()
        {
            InitializeComponent();
        }

        private void CrossButton_Click(object sender, EventArgs e)
        {
            Products products = new Products();
            products.ShowDialog();
            this.Hide();
        }

        private void ProReportViewer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Jewelry_management_database_finalDataSet15.Product' table. You can move, or remove it, as needed.
            this.ProductTableAdapter.Fill(this.Jewelry_management_database_finalDataSet15.Product);

            this.reportViewer1.RefreshReport();
        }
    }
}
