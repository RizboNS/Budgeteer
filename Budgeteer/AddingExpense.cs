using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Budgeteer.Classes.Expense;

namespace Budgeteer
{
    public partial class AddingExpense : UserControl
    {
        public AddingExpense()
        {
            InitializeComponent();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            Expense expense = new Expense();
            expense.amount = Convert.ToDouble(amountTxt.Text);
            expense.article = articleTxt.Text;
            expense.month = dateTimePicker.Value.Date.ToString("MMMM");
            expense.year = dateTimePicker.Value.Date.ToString("yyyy");
            expense.category = categoryTxt.Text;

            statusLbl.Text = expense.FullExpense;
        }

    }
}
