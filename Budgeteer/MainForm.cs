﻿using System;
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

        private void aboutBtn_Click(object sender, EventArgs e)
        {
            Form aboutForm = new AboutBox();
            aboutForm.Show();
        }
    }
}
