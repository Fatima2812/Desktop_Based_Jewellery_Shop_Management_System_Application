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
    public partial class UpdateCustOrder : Form
    {
        public UpdateCustOrder()
        {
            InitializeComponent();
        }

        private void CrossButton_Click(object sender, EventArgs e)
        {
            CustOrderProDetails custOrderProDetails = new CustOrderProDetails();
            custOrderProDetails.ShowDialog();
            this.Hide();
        }

        private void UpdateCusProDetailsBtn_Click(object sender, EventArgs e)
        {
            UpdateCustOrdProDetailsMessage updateCustOrdProDetailsMessage = new UpdateCustOrdProDetailsMessage();
            updateCustOrdProDetailsMessage.ShowDialog();
            this.Hide();

        }
    }
}
