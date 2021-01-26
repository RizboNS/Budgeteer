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
    public partial class ViewBy : UserControl
    {
        private List<Expense> displayList = new List<Expense>();
        string month = "";
        string year = "";
        public ViewBy()
        {
            InitializeComponent();
            SetMyCustomFormat();
        }
        private void SetMyCustomFormat()
        {
            // Set the Format type and the CustomFormat string.
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "MMMM/yyyy";
            dateTimePicker.ShowUpDown = true;
        }

        private void fullLoad()
        {
            displayList = SqliteDataAccess.LoadExpence();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = displayList;

            double sum = SqliteDataAccess.FullLoadExpenseSum();
            textBoxSum.Text = sum.ToString();
            textBoxCount.Text = displayList.Count().ToString();

            double sumByCategory = SqliteDataAccess.FullLoadExpenseSumByCategory("Utility");
            textBoxUtilitySum.Text = sumByCategory.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            fullLoad();
        }

        private void testBtn_Click(object sender, EventArgs e)
        {
            loadByMonthAndYear();
        }

        private void loadByMonthAndYear()
        {
            month = dateTimePicker.Value.Date.ToString("MMMM");
            year = dateTimePicker.Value.Date.ToString("yyyy");
            displayList = SqliteDataAccess.LoadExpenceByMonthAndYear(month, year);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = displayList;
            double sum = SqliteDataAccess.getExpenseSumByMonthAndYear(month, year);
            textBoxSum.Text = sum.ToString();
            textBoxCount.Text = displayList.Count().ToString();
        }
    }
}
