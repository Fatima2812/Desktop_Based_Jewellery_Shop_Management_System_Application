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
    public partial class DeleteProductListPermission : Form
    {
        public DeleteProductListPermission()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DeleteProductList deleteProductList = new DeleteProductList();
            deleteProductList.ShowDialog();
            this.Hide();
        }

        private void AddCustBtnOnAddCustWindow_Click(object sender, EventArgs e)
        {
            StockProductList stockProductList = new StockProductList();
            stockProductList.ShowDialog();
            this.Hide();
        }

        private void DeleteProductListPermission_Load(object sender, EventArgs e)
        {

        }
    }
}
