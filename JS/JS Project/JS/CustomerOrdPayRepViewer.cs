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
    public partial class CustomerOrdPayRepViewer : Form
    {
        public CustomerOrdPayRepViewer()
        {
            InitializeComponent();
        }

        private void CustomerOrdPayRepViewer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Jewelry_management_database_finalDataSet16.Cust_Order_payment' table. You can move, or remove it, as needed.
            this.Cust_Order_paymentTableAdapter.Fill(this.Jewelry_management_database_finalDataSet16.Cust_Order_payment);

            this.reportViewer1.RefreshReport();
        }

        private void CrossButton_Click(object sender, EventArgs e)
        {
           Orders orders = new Orders();
            orders.ShowDialog();
            this.Hide();
        }
    }
}
