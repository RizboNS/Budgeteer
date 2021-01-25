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
        public ViewBy()
        {
            InitializeComponent();
        }
        private void loadFullTable()
        {
            displayList = SqliteDataAccess.LoadExpence();
            loadDataToListBox(displayList, textBox1);
        }

        private void loadDataToListBox(List<Expense> list, TextBox listBox)
        {
            foreach (var item in list)
            {
                listBox.AppendText(item.FullExpense + "\n");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadFullTable();
        }
    }
}
