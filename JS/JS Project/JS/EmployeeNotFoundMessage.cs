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
    public partial class EmployeeNotFoundMessage : Form
    {
        public EmployeeNotFoundMessage()
        {
            InitializeComponent();
        }

        private void AddCustBtnOnAddCustWindow_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}