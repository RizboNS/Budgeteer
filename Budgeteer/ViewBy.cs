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
        #region Button Clicks
        private void Button1_Click(object sender, EventArgs e)
        {
            FullLoad();
        }
        private void TestBtn_Click(object sender, EventArgs e)
        {
            LoadByMonthAndYear();
        }
        #endregion

        #region Loading Data from DB Methods
        private void FullLoad()
        {
            //  Load whole table from DB and load values like sum count etc.
            displayList = SqliteDataAccess.LoadFromDbToList("select * from Expense");
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = displayList;

            double sum = SqliteDataAccess.LoadFromDbToDouble("SELECT sum(Amount) FROM Expense");
            textBoxSum.Text = sum.ToString();
            textBoxCount.Text = displayList.Count().ToString();

            SumAndCountByCategoryFullLoad("Utility", textBoxUtilitySum,textBoxUtilityCount);
            SumAndCountByCategoryFullLoad("Food", textBoxFoodSum, textBoxFoodCount);
            SumAndCountByCategoryFullLoad("Transportation", textBoxTranspSum, textBoxTranspCount);
            SumAndCountByCategoryFullLoad("Not Listed", textBoxNotListSum, textBoxNotListCount);
        }
        private void LoadByMonthAndYear()
        {
            // Load from DB by Month and Year category and load values like sum count etc.
            month = dateTimePicker.Value.Date.ToString("MMMM");
            year = dateTimePicker.Value.Date.ToString("yyyy");
            displayList = SqliteDataAccess.LoadFromDbToList($"select * from Expense where Month = '{month}' and Year = '{year}'");
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = displayList;

            double sum = SqliteDataAccess.LoadFromDbToDouble($"select sum(Amount) from Expense where Month = '{month}' and Year = '{year}'");
            textBoxSum.Text = sum.ToString();
            textBoxCount.Text = displayList.Count().ToString();

            SumAndCountByCategoryMonthAndYear("Utility",textBoxUtilitySum ,textBoxUtilityCount);
            SumAndCountByCategoryMonthAndYear("Food", textBoxFoodSum, textBoxFoodCount);
            SumAndCountByCategoryMonthAndYear("Transportation", textBoxTranspSum, textBoxTranspCount);
            SumAndCountByCategoryMonthAndYear("Not Listed", textBoxNotListSum, textBoxNotListCount);
        }

        private void SumAndCountByCategoryMonthAndYear(string category, TextBox textBoxSum, TextBox textBoxCount)
        {
            double sumByCategory = SqliteDataAccess.LoadFromDbToDouble($"SELECT sum(Amount) FROM Expense Where Category = '{category}' and Month = '{month}' and Year = '{year}'");
            textBoxSum.Text = sumByCategory.ToString();
            textBoxCount.Text = displayList.Count(exp => exp.category.Equals(category)).ToString();
        }
        private void SumAndCountByCategoryFullLoad(string category, TextBox textBoxSum,TextBox textBoxCount)
        {
            double sumByCategory = SqliteDataAccess.LoadFromDbToDouble($"SELECT sum(Amount) FROM Expense Where Category = '{category}'");
            textBoxSum.Text = sumByCategory.ToString();
            textBoxCount.Text = displayList.Count(exp => exp.category.Equals(category)).ToString();
        }
        #endregion
    }
}
