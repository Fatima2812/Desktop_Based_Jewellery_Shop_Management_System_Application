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
    public partial class DeleteCompanyDataPermission : Form
    {
        public DeleteCompanyDataPermission()
        {
            InitializeComponent();
        }

        private void AddCustBtnOnAddCustWindow_Click(object sender, EventArgs e)
        {
            DeletedCompanyData deletedCompanyData = new DeletedCompanyData();
            deletedCompanyData.ShowDialog();
            this.Hide();
        }
    }
}
