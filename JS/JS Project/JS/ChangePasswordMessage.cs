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
    public partial class ChangePasswordMessage : Form
    {
        public ChangePasswordMessage()
        {
            InitializeComponent();
        }

        private void AddCustBtnOnAddCustWindow_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.ShowDialog();
            this.Hide();
        }
    }
}
