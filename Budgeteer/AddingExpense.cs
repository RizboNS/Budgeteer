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
        private string article = "Not Listed";
        private List<string> listBoxValues = new List<string>();
        private bool parseToDouble = false;
        private double amount;
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
            expense.amount = amount;
            expense.article = article;
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
            quantityTxtBox.Text = "1";
        }
        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            // Saving to the DB and Displaying added obj to the user.
            parseToDouble = double.TryParse(amountTxt.Text, out amount);
            if (parseToDouble)
            {
                for (int i = 0; i < Convert.ToInt32(quantityTxtBox.Text); i++)
                {
                    SqliteDataAccess.SaveExpence(DisplayExpenseAddedAndReturnExpenseObj());
                }
                ClearInputBoxes();
            }
            else
            {
                MessageBox.Show("Price input should be a number.", "Error");
            }
        }

        private void setCategoryAndArticle(string ctg, string artc)
        {
            category = ctg;
            article = artc;
            menuBtn.Text = artc;
        }
        private void showMenu(ContextMenuStrip menu, Button btn)
        {
            menu.Show(btn, new Point(0, btn.Height));
        }
        private void categoryMenuBtn_Click(object sender, EventArgs e)
        {
            showMenu(categoryMenu, menuBtn);
        }
        // MENU BUTTONS
        private void categoryMenuNotListedBtn_Click(object sender, EventArgs e)
        {
            setCategoryAndArticle("Not Listed","Not Listed");
        }

        private void electricityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setCategoryAndArticle("Utility", "Electricity");
        }

        private void waterGarbageEtcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setCategoryAndArticle("Utility", "Water and Garbage etc.");
        }

        private void cableAndInternetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setCategoryAndArticle("Utility", "Cable and Internet");
        }

        private void phoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setCategoryAndArticle("Utility", "Phone");
        }

        private void milkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setCategoryAndArticle("Food", "Milk");
        }

        private void breadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setCategoryAndArticle("Food", "Bread");
        }

        private void sunflowerOilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setCategoryAndArticle("Food", "Sunflower Oil");
        }

        private void oliveOilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setCategoryAndArticle("Food", "Olive Oil");
        }

        private void vegOilToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            setCategoryAndArticle("Food", "Veg Oil");
        }

        private void dogFoodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setCategoryAndArticle("Food", "Dog Food");
        }

        private void sugarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setCategoryAndArticle("Food", "Sugar");
        }

        private void wheatFlowerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setCategoryAndArticle("Food", "Wheat Flower");
        }

        private void cornFlowerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setCategoryAndArticle("Food", "Corn Flower");
        }

        private void gasolineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setCategoryAndArticle("Transportation", "Gasoline");
        }

        private void busFareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setCategoryAndArticle("Transportation", "Bus Fare");
        }

        private void otherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setCategoryAndArticle("Transportation", "Other");
        }
    }
}
