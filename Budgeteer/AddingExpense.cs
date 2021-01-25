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
            menuStripDisplay(contextMenuStrip1);
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
        private void menuStripDisplay(ContextMenuStrip contextMenuStrip)
        {
            contextMenuStrip.ForeColor = Color.Red;
            contextMenuStrip.BackColor = Color.SkyBlue;

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

        private void testBtn_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(testBtn, new Point(0, testBtn.Height));
        }

    }
}
