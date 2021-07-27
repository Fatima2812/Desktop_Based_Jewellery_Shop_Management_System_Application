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
    public partial class ExpenseViewer : Form
    {
        public ExpenseViewer()
        {
            InitializeComponent();
        }

        private void CrossButton_Click(object sender, EventArgs e)
        {
            Expenses expenses = new Expenses();
            expenses.ShowDialog();
            this.Hide();
        }

        private void ExpenseViewer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Jewelry_management_database_finalDataSet8.Daily_Expense' table. You can move, or remove it, as needed.
            this.Daily_ExpenseTableAdapter.Fill(this.Jewelry_management_database_finalDataSet8.Daily_Expense);

            this.reportViewer1.RefreshReport();
        }
    }
}
