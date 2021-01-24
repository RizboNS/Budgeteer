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
        public AddingExpense()
        {
            InitializeComponent();
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
            statusLbl.Text = $"Expense added {expense.FullExpense}";
            return expense;
        }
        private void ClearInputBoxes()
        {
            // Clear boxes so it is ready for next input.
            // TO DO implement choice so article and category remains saved, didn't clear time so it gets saved.
            amountTxt.Clear();
            articleTxt.Clear();
        }
        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            // Saving to the DB and Displaying added obj to the user.
            SqliteDataAccess.SaveExpence(DisplayExpenseAddedAndReturnExpenseObj());
            ClearInputBoxes();
        }
        private void CategoryMenuOnOff()
        {
            if (categoryMenuPanel.Visible)
            {
                categoryMenuPanel.Visible = false;
            }
            else
            {
                categoryMenuPanel.Visible = true;
            }
        }
        private void setCategory(string value)
        {
            category = value;
            categoryMenuBtn.Text = value;
        }
        private void categoryMenuBtn_Click(object sender, EventArgs e)
        {
            CategoryMenuOnOff();
        }

        private void categoryMenuUtilBtn_Click(object sender, EventArgs e)
        {
            setCategory("Utility");
            CategoryMenuOnOff();
        }

        private void categoryMenuFoodBtn_Click(object sender, EventArgs e)
        {
            setCategory("Food");
            CategoryMenuOnOff();
        }

        private void categoryMenuWardrobeBtn_Click(object sender, EventArgs e)
        {
            setCategory("Wardrobe");
            CategoryMenuOnOff();
        }

        private void categoryMenuKidsBtn_Click(object sender, EventArgs e)
        {
            setCategory("Kids");
            CategoryMenuOnOff();
        }

        private void categoryMenuTransportationBtn_Click(object sender, EventArgs e)
        {
            setCategory("Transportation");
            CategoryMenuOnOff();
        }

        private void categoryMenuNonEssentialsBtn_Click(object sender, EventArgs e)
        {
            setCategory("Non Essentials");
            CategoryMenuOnOff();
        }

        private void categoryMenuCareProductsBtn_Click(object sender, EventArgs e)
        {
            setCategory("Care Products");
            CategoryMenuOnOff();
        }

        private void categoryMenuNotListed_Click(object sender, EventArgs e)
        {
            setCategory("Not Listed");
            CategoryMenuOnOff();
        }
    }
}
