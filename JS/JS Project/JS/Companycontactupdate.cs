﻿using System;
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
    public partial class Companycontactupdate : Form
    {
        public Companycontactupdate()
        {
            InitializeComponent();
        }

        private void OkayUpdateCategoryBtn_Click(object sender, EventArgs e)
        {
            companydetailsview c = new companydetailsview();
            c.ShowDialog();
            this.Hide();
        }
    }
}
