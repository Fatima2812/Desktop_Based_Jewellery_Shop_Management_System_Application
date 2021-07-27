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
    public partial class CategoryReportViewer : Form
    {
        public CategoryReportViewer()
        {
            InitializeComponent();
            this.Controls.Add(this.reportViewer2);
        }

        private void CrossButton_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.ShowDialog();
            this.Hide();
        }

        private void CategoryReportViewer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Jewelry_management_database_finalDataSet1.Product_Category' table. You can move, or remove it, as needed.
            this.Product_CategoryTableAdapter.Fill(this.Jewelry_management_database_finalDataSet1.Product_Category);
            this.reportViewer2.RefreshReport();

        }

        private void reportViewer2_Load(object sender, EventArgs e)
        {

        }
    }
}
