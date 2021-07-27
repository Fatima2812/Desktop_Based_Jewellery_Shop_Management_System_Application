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
    public partial class UpdatedBrandMessageBox : Form
    {
        public UpdatedBrandMessageBox()
        {
            InitializeComponent();
        }

        private void AddCustBtnOnAddCustWindow_Click(object sender, EventArgs e)
        {
            UpdateBrandData updateBrandData = new UpdateBrandData();
            updateBrandData.ShowDialog();
            this.Hide();
        }
    }
}
