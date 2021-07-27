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
    public partial class CustomerInvoice : Form
    {
        public CustomerInvoice()
        {
            InitializeComponent();
        }

        private void CrossButton_Click(object sender, EventArgs e)
        {
            CustomerOrderData customerOrderData = new CustomerOrderData();
            customerOrderData.ShowDialog();
            this.Hide();
        }

        private void CompanyInvoice_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Jewelry_management_database_finalDataSet10.Cust_Order_payment' table. You can move, or remove it, as needed.
            //this.Cust_Order_paymentTableAdapter.Fill(this.Jewelry_management_database_finalDataSet10.Cust_Order_payment);
            // TODO: This line of code loads data into the 'Jewelry_management_database_finalDataSet7.Cust_Order_detail' table. You can move, or remove it, as needed.
            //this.Cust_Order_detailTableAdapter.Fill(this.Jewelry_management_database_finalDataSet7.Cust_Order_detail);

            this.reportViewer1.RefreshReport();
        }
    }
}
