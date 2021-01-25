using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Budgeteer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void addExpenseNavBtn_Click(object sender, EventArgs e)
        {
            addingExpense.BringToFront();
        }

        private void viewByBtn_Click(object sender, EventArgs e)
        {
            viewBy.BringToFront();
        }
    }
}
