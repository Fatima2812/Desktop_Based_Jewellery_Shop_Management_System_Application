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
    public partial class CompanyOrderReportViewer : Form
    {
        public CompanyOrderReportViewer()
        {
            InitializeComponent();
        }

        private void CrossButton_Click(object sender, EventArgs e)
        {
            StockOrder stockOrder = new StockOrder();
            stockOrder.ShowDialog();
            this.Hide();
        }

        private void CompanyOrderReportViewer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Jewelry_management_database_finalDataSet9.Sup_Order_detail' table. You can move, or remove it, as needed.
            this.Sup_Order_detailTableAdapter.Fill(this.Jewelry_management_database_finalDataSet9.Sup_Order_detail);

            this.reportViewer1.RefreshReport();
        }
    }
}
