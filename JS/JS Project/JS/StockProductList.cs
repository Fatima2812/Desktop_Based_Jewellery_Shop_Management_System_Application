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
    public partial class StockProductList : Form
    {
        public StockProductList()
        {
            InitializeComponent();
        }

     

        private void DoneBtnOnPdtList_Click(object sender, EventArgs e)
        {
            ProductListAddedMessagebox productListAddedMessagebox = new ProductListAddedMessagebox();
            productListAddedMessagebox.ShowDialog();
            this.Hide();
        }

        private void CrossButton_Click(object sender, EventArgs e)
        {
            StockOrder stockOrder = new StockOrder();
            stockOrder.ShowDialog();
            this.Hide();

        }

      

    

        private void DoneBtnOnStkPdtList_Click(object sender, EventArgs e)
        {
            StockOrder stockorder = new StockOrder();
            stockorder.ShowDialog();
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DeleteProductListPermission deleteProductListPermission = new DeleteProductListPermission();
            deleteProductListPermission.ShowDialog();
            this.Hide();


        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void DoneBtnForStkOdr_Click(object sender, EventArgs e)
        {
            ProductListAddedMessagebox productListAddedMessagebox = new ProductListAddedMessagebox();
            productListAddedMessagebox.ShowDialog();
            this.Hide();
        }

        private void UpdateProductListBtn_Click(object sender, EventArgs e)
        {
            UpdateProductListMessageBox up = new UpdateProductListMessageBox();
            up.ShowDialog();
            this.Hide();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            DeleteProductListPermission deleteProductListPermission = new DeleteProductListPermission();
            deleteProductListPermission.ShowDialog();
            this.Hide();
        }
    }
}
