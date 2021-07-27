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
    public partial class StockReportViewer : Form
    {
        public StockReportViewer()
        {
            InitializeComponent();
            this.Controls.Add(this.reportViewer1);
        }

        private void StockReportViewer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Jewelry_management_database_finalDataSet13.STOCK' table. You can move, or remove it, as needed.
            this.STOCKTableAdapter.Fill(this.Jewelry_management_database_finalDataSet13.STOCK);
            // TODO: This line of code loads data into the 'DataSet1.STOCK' table. You can move, or remove it, as needed.


            this.reportViewer2.RefreshReport();
        }

        private void CrossButton_Click(object sender, EventArgs e)
        {
            Stock stock = new Stock();
            stock.ShowDialog();
            this.Hide();
        }

        private void reportViewer2_Load(object sender, EventArgs e)
        {

        }
    }
}
