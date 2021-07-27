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
    public partial class DeletedCategory : Form
    {
        public DeletedCategory()
        {
            InitializeComponent();
        }

        private void YesBtnDeleteCategory_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.ShowDialog();
            this.Hide();
        }
    }
}
