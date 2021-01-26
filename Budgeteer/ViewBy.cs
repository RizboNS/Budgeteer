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

        private void loadDataToDGV()
        {
            displayList = SqliteDataAccess.LoadExpence();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = displayList;
        }
        private void loadDataToDGVbyMonthAndYear()
        {
            displayList = SqliteDataAccess.LoadExpenceByMonthAndYear(month,year);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = displayList;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            loadDataToDGV();
        }

        private void testBtn_Click(object sender, EventArgs e)
        {
            month = dateTimePicker.Value.Date.ToString("MMMM");
            year = dateTimePicker.Value.Date.ToString("yyyy");
            loadDataToDGVbyMonthAndYear();
        }
    }
}
