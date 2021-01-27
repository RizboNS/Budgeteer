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
        protected override bool ProcessTabKey(bool forward)
        {
            // For tab to stay in user control.
            return SelectNextControl(ActiveControl, true, true, true, true);
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // If enter is pressed, submit button will fire.
            if (keyData == Keys.Enter && !SubmitBtn.Focused)
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
            Expense expense = new Expense
            {
                amount = amount,
                article = article,
                month = dateTimePicker.Value.Date.ToString("MMMM"),
                year = dateTimePicker.Value.Date.ToString("yyyy"),
                category = category
            };

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
                    SqliteDataAccess.SaveToDb(DisplayExpenseAddedAndReturnExpenseObj());
                }
                ClearInputBoxes();
            }
            else
            {
                MessageBox.Show("Price input should be a number.", "Error");
            }
        }

        private void SetCategoryAndArticle(string ctg, string artc)
        {
            category = ctg;
            article = artc;
            menuBtn.Text = artc;
        }
        private void ShowMenu(ContextMenuStrip menu, Button btn)
        {
            menu.Show(btn, new Point(0, btn.Height));
        }
        private void CategoryMenuBtn_Click(object sender, EventArgs e)
        {
            ShowMenu(categoryMenu, menuBtn);
        }
        #region Menu Buttons Clicks
        private void categoryMenuNotListedBtn_Click(object sender, EventArgs e)
        {
            SetCategoryAndArticle("Not Listed","Not Listed");
        }
        #region Utility
        private void electricityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetCategoryAndArticle("Utility", "Electricity");
        }

        private void waterGarbageEtcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetCategoryAndArticle("Utility", "Water and Garbage etc.");
        }

        private void cableAndInternetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetCategoryAndArticle("Utility", "Cable and Internet");
        }

        private void phoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetCategoryAndArticle("Utility", "Phone");
        }
        #endregion
        #region Food
        private void milkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetCategoryAndArticle("Food", "Milk");
        }

        private void breadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetCategoryAndArticle("Food", "Bread");
        }

        private void sunflowerOilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetCategoryAndArticle("Food", "Sunflower Oil");
        }

        private void oliveOilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetCategoryAndArticle("Food", "Olive Oil");
        }

        private void vegOilToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SetCategoryAndArticle("Food", "Veg Oil");
        }

        private void dogFoodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetCategoryAndArticle("Food", "Dog Food");
        }

        private void sugarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetCategoryAndArticle("Food", "Sugar");
        }

        private void wheatFlowerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetCategoryAndArticle("Food", "Wheat Flower");
        }

        private void cornFlowerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetCategoryAndArticle("Food", "Corn Flower");
        }
        #endregion
        #region Transportation
        private void gasolineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetCategoryAndArticle("Transportation", "Gasoline");
        }

        private void busFareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetCategoryAndArticle("Transportation", "Bus Fare");
        }

        private void otherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetCategoryAndArticle("Transportation", "Other");
        }
        #endregion
        #endregion
    }
}
