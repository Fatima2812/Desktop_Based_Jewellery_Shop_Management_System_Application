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
    public partial class ForgotPassMessage : Form
    {
        public ForgotPassMessage()
        {
            InitializeComponent();
        }

        private void AddCustBtnOnAddCustWindow_Click(object sender, EventArgs e)
        {
            ForgotPassword passwordCodeForm = new ForgotPassword();
            passwordCodeForm.ShowDialog(); 
            this.Hide();
        }
    }
}
