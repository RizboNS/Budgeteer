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
        private void showMenu(ContextMenuStrip menu, Button btn)
        {
            menu.Show(btn, new Point(0, btn.Height));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            loadDataToDGV();
        }

        private void testBtn_Click(object sender, EventArgs e)
        {
            showMenu(contextMenuStrip1, testBtn);
        }

        private void januaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            month = "January";
            year = "2021";
            loadDataToDGVbyMonthAndYear();
        }
    }
}
