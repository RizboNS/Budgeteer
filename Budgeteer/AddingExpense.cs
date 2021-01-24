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
        private void DisplayExpenseAdded()
        {
            // Creating Expense object and Displaying added string to the user.
            Expense expense = new Expense();
            expense.amount = Convert.ToDouble(amountTxt.Text); // Need to add error mechanism
            expense.article = articleTxt.Text;
            expense.month = dateTimePicker.Value.Date.ToString("MMMM");
            expense.year = dateTimePicker.Value.Date.ToString("yyyy");
            expense.category = categoryTxt.Text;
            statusLbl.Text = $"Expense added {expense.FullExpense}";
        }
        private void ClearInputBoxes()
        {
            // Clear boxes so it is ready for next input.
            // TO DO implement choice so article and category remains saved, didn't clear time so it gets saved.
            amountTxt.Clear();
            articleTxt.Clear();
            categoryTxt.Clear();
        }
        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            DisplayExpenseAdded();
            ClearInputBoxes();
        }

    }
}
