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
    public partial class DeleteCustOrdProPermission : Form
    {
        public DeleteCustOrdProPermission()
        {
            InitializeComponent();
        }

        private void AddCustBtnOnAddCustWindow_Click(object sender, EventArgs e)
        {
            CustOrderProDetails custOrderProDetails = new CustOrderProDetails();
            custOrderProDetails.ShowDialog();
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DeletedCustOrdPro deletedCustOrdPro = new DeletedCustOrdPro();
            deletedCustOrdPro.ShowDialog();
            this.Hide();
        }
    }
}
