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
    public partial class DeleteCategoryPermission : Form
    {
        public DeleteCategoryPermission()
        {
            InitializeComponent();
        }

        private void AddCustBtnOnAddCustWindow_Click(object sender, EventArgs e)
        {
            DeletedCategory deletedCategory = new DeletedCategory();
            deletedCategory.ShowDialog();
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            CategoryData categoryData = new CategoryData();
            categoryData.ShowDialog();
            this.Hide();
        }
    }
}
