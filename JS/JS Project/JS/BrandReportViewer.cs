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
    public partial class BrandReportViewer : Form
    {
        public BrandReportViewer()
        {
            InitializeComponent();
            this.Controls.Add(this.reportViewer1);
        }

        private void CrossButton_Click(object sender, EventArgs e)
        {
            Brands brands = new Brands();
            brands.ShowDialog();
            this.Hide();
        }

        private void BrandReportViewer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Jewelry_management_database_finalDataSet3.Product_Type' table. You can move, or remove it, as needed.
            this.Product_TypeTableAdapter.Fill(this.Jewelry_management_database_finalDataSet3.Product_Type);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
