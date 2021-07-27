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
    public partial class UpdateProductMessage : Form
    {
        public UpdateProductMessage()
        {
            InitializeComponent();
        }

        private void OkayUpdateCategoryBtn_Click(object sender, EventArgs e)
        {
            ProductData productData = new ProductData();
            productData.ShowDialog();
            this.Hide();
        }
    }
}
