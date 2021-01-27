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
        private string month = "";
        private string year = "";
        private string lastExecutedCommand = "";
        public ViewBy()
        {
            InitializeComponent();
            SetMyCustomFormat();
        }
        #region Format Methods
        private void SetMyCustomFormat()
        {
            // Set the Format type and the CustomFormat string.
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "MMMM/yyyy";
            dateTimePicker.ShowUpDown = true;
        }
        #endregion
        #region Button Clicks
        private void Button1_Click(object sender, EventArgs e)
        {
            FullLoad();
            lastExecutedCommand = "FullLoad";
        }
        private void TestBtn_Click(object sender, EventArgs e)
        {
            LoadByMonthAndYear();
            lastExecutedCommand = "LoadByMonthAndYear";
        }
        private void deleteSelectedRowBtn_Click(object sender, EventArgs e)
        {
            DeleteSelectedRow();
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
        #region Deletion and Clear Methods
        private void clearTableBtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("This action will delete all DataTable entry.",
                      "Warning deleting all data from database", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes: SqliteDataAccess.deleteAllDataFromTable();
                    break;
                case DialogResult.No:
                    break;
            }
        }
        private void DeleteSelectedRow()
        {
            if (dataGridView1.Rows.Count > 0)
            {
                string selectedId = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                SqliteDataAccess.ExecuteSql($"delete from Expense where Id='{selectedId}'");
                if (lastExecutedCommand.Equals("FullLoad"))
                {
                    FullLoad();
                }
                else if (lastExecutedCommand.Equals("LoadByMonthAndYear"))
                {
                    LoadByMonthAndYear();
                }
            }
            else
            {
                MessageBox.Show("Please select row to delete it.", "Delete failed");
            }
        }
        #endregion
    }
}
