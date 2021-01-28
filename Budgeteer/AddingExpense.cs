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
                article = CapitilzeFirtLeter(itemTextBox.Text),
                month = dateTimePicker.Value.Date.ToString("MMMM"),
                year = dateTimePicker.Value.Date.ToString("yyyy"),
                category = category
            };

            listBoxValues.Add(expense.FullExpense);
            listBoxAddedValues.DataSource = null;
            listBoxAddedValues.DataSource = listBoxValues;

            return expense;
        }
        private string CapitilzeFirtLeter(string input)
        {
            if (!string.IsNullOrEmpty(input))
            {
                return input[0].ToString().ToUpper() + input.Substring(1);
            }
            return "Not listed";
        }
        private void ClearInputBoxes()
        {
            // Clear boxes so it is ready for next input.
            amountTxt.Clear();
            itemTextBox.Clear();
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

        private void SetCategoryAndArticle(string ctg)
        {
            category = ctg;
            menuBtn.Text = ctg;
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
            SetCategoryAndArticle("Not Listed");
        }
        private void categoryMenuUtilBtn_Click(object sender, EventArgs e)
        {
            SetCategoryAndArticle("Utility");
        }

        private void categoryMenuFood_Click(object sender, EventArgs e)
        {
            SetCategoryAndArticle("Food");
        }

        private void categoryMenuTransportationBtn_Click(object sender, EventArgs e)
        {
            SetCategoryAndArticle("Transport");
        }

        private void categoryMenuKitchenProducts_Click(object sender, EventArgs e)
        {
            SetCategoryAndArticle("Kitchen products");
        }

        private void categoryMenuBodyFaceCare_Click(object sender, EventArgs e)
        {
            SetCategoryAndArticle("Body Hair Face care");
        }

        private void categoryMenuWardrobe_Click(object sender, EventArgs e)
        {
            SetCategoryAndArticle("Wardrobe");
        }

        private void categoryMenuLaundryProducts_Click(object sender, EventArgs e)
        {
            SetCategoryAndArticle("Laundry products");
        }

        private void categoryMenuBabyCare_Click(object sender, EventArgs e)
        {
            SetCategoryAndArticle("Baby");
        }

        private void categoryMenuKids_Click(object sender, EventArgs e)
        {
            SetCategoryAndArticle("Kids");
        }

        private void categoryMenuPets_Click(object sender, EventArgs e)
        {
            SetCategoryAndArticle("Pets");
        }

        private void categoryMenuGarden_Click(object sender, EventArgs e)
        {
            SetCategoryAndArticle("Garden");
        }

        private void categoryMenuPharmacy_Click(object sender, EventArgs e)
        {
            SetCategoryAndArticle("Pharmacy");
        }
        #endregion

        private void clearBoxBtn_Click(object sender, EventArgs e)
        {
            listBoxValues.Clear();
            listBoxAddedValues.DataSource = null;
        }
    }
}
