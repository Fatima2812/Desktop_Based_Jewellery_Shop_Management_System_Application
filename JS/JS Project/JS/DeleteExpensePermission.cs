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
    public partial class DeleteExpensePermission : Form
    {
        public DeleteExpensePermission()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DeleteExpense deleteExpense = new DeleteExpense();
            deleteExpense.ShowDialog();
            this.Hide();
        }

        private void AddCustBtnOnAddCustWindow_Click(object sender, EventArgs e)
        {
            ExpenseData expenseData = new ExpenseData();
            expenseData.ShowDialog();
            this.Hide();
        }
    }
}
