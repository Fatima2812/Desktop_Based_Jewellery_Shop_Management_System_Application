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
    public partial class deleteuserpermission : Form
    {
        public deleteuserpermission()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DeleteUser deleteUser = new DeleteUser();
            deleteUser.ShowDialog();
            this.Hide();
        }

        private void AddCustBtnOnAddCustWindow_Click(object sender, EventArgs e)
        {
            ManageUsers manageUsers = new ManageUsers();
            manageUsers.ShowDialog();
            this.Hide();
        }

        private void AddedLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
