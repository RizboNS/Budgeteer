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
using Budgeteer.Classes.SqliteDataAccess;

namespace Budgeteer
{
    public partial class AddingExpense : UserControl
    {
        private string category = "Not Listed";
        private List<string> listBoxValues = new List<string>();
        public AddingExpense()
        {
            InitializeComponent();
            SetMyCustomFormat();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                SubmitBtn.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void SetMyCustomFormat()
        {
            // Set the Format type and the CustomFormat string.
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "MMMM/yyyy";
            dateTimePicker.ShowUpDown = true;
        }
        private Expense DisplayExpenseAddedAndReturnExpenseObj()
        {
            // Creating Expense object and Displaying added string to the user.
            Expense expense = new Expense();
            expense.amount = Convert.ToDouble(amountTxt.Text); // Need to add error mechanism
            expense.article = articleTxt.Text;
            expense.month = dateTimePicker.Value.Date.ToString("MMMM");
            expense.year = dateTimePicker.Value.Date.ToString("yyyy");
            expense.category = category;

            listBoxValues.Add(expense.FullExpense);
            listBoxAddedValues.DataSource = null;
            listBoxAddedValues.DataSource = listBoxValues;

            return expense;
        }
        private void ClearInputBoxes()
        {
            // Clear boxes so it is ready for next input.
            amountTxt.Clear();
            articleTxt.Clear();
            quantityTxtBox.Text = "1";
        }
        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            // Saving to the DB and Displaying added obj to the user.
            for (int i = 0; i < Convert.ToInt32(quantityTxtBox.Text); i++)
            {
                SqliteDataAccess.SaveExpence(DisplayExpenseAddedAndReturnExpenseObj());
            }
            ClearInputBoxes();
        }

        private void setCategory(string value)
        {
            category = value;
            categoryMenuBtn.Text = value;
        }
        private void showMenu(ContextMenuStrip menu, Button btn)
        {
            menu.Show(btn, new Point(0, btn.Height));
        }
        private void categoryMenuBtn_Click(object sender, EventArgs e)
        {
            showMenu(categoryMenu, categoryMenuBtn);
        }

        private void categoryMenuUtilBtn_Click(object sender, EventArgs e)
        {
            setCategory("Utility");
        }

        private void categoryMenuFood_Click(object sender, EventArgs e)
        {
            setCategory("Food");
        }

        private void categoryMenuNotListedBtn_Click(object sender, EventArgs e)
        {
            setCategory("Not Listed");
        }

        private void categoryMenuTransportationBtn_Click(object sender, EventArgs e)
        {
            setCategory("Transportation");
        }
    }
}
