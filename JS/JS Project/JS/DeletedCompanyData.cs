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
    public partial class DeletedCompanyData : Form
    {
        public DeletedCompanyData()
        {
            InitializeComponent();
        }

        private void AddCustBtnOnAddCustWindow_Click(object sender, EventArgs e)
        {
            Category company = new Category();
            company.ShowDialog();
            this.Hide();
        }

        private void deletepermissionlabel_Click(object sender, EventArgs e)
        {

        }
    }
}
