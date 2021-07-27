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
    public partial class DeleteCompanyContactPerson : Form
    {
        public DeleteCompanyContactPerson()
        {
            InitializeComponent();
        }

        private void AddCustBtnOnAddCustWindow_Click(object sender, EventArgs e)
        {
            Companycontactpersonview n = new Companycontactpersonview();
            n.ShowDialog();
            this.Hide();
        }
    }
}
