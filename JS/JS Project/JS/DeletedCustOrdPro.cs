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
    public partial class DeletedCustOrdPro : Form
    {
        public DeletedCustOrdPro()
        {
            InitializeComponent();
        }

        private void AddCustBtnOnAddCustWindow_Click(object sender, EventArgs e)
        {
            CustomerOrderData customerOrderData = new CustomerOrderData();
            customerOrderData.ShowDialog();
            this.Hide();
        }
    }
}
