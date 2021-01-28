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
        private string category = "";
        private bool categorySelected = false;
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
        protected override bool ProcessTabKey(bool forward)
        {
            // For tab to stay in user control.
            return SelectNextControl(ActiveControl, true, true, true, true);
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
            if (!categorySelected)
            {
                displayList = SqliteDataAccess.LoadFromDbToList("select * from Expense");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = displayList;

                double sum = SqliteDataAccess.LoadFromDbToDouble("SELECT sum(Amount) FROM Expense");
                textBoxSum.Text = sum.ToString();
                textBoxCount.Text = displayList.Count().ToString();
            }
            else
            {
                displayList = SqliteDataAccess.LoadFromDbToList($"select * from Expense where Category = '{category}'");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = displayList;

                double sum = SqliteDataAccess.LoadFromDbToDouble($"SELECT sum(Amount) FROM Expense where Category = '{category}'");
                textBoxSum.Text = sum.ToString();
                textBoxCount.Text = displayList.Count().ToString();
            }
        }
        private void LoadByMonthAndYear()
        {
            // Load from DB by Month and Year category and load values like sum count etc.
            if (!categorySelected)
            {
                month = dateTimePicker.Value.Date.ToString("MMMM");
                year = dateTimePicker.Value.Date.ToString("yyyy");
                displayList = SqliteDataAccess.LoadFromDbToList($"select * from Expense where Month = '{month}' and Year = '{year}'");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = displayList;

                double sum = SqliteDataAccess.LoadFromDbToDouble($"select sum(Amount) from Expense where Month = '{month}' and Year = '{year}'");
                textBoxSum.Text = sum.ToString();
                textBoxCount.Text = displayList.Count.ToString();
            }
            else
            {
                month = dateTimePicker.Value.Date.ToString("MMMM");
                year = dateTimePicker.Value.Date.ToString("yyyy");
                displayList = SqliteDataAccess.LoadFromDbToList($"select * from Expense where Category = '{category}' and Month = '{month}' and Year = '{year}'");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = displayList;

                double sum = SqliteDataAccess.LoadFromDbToDouble($"select sum(Amount) from Expense where Category = '{category}' and Month = '{month}' and Year = '{year}'");
                textBoxSum.Text = sum.ToString();
                textBoxCount.Text = displayList.Count.ToString();
            }
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
        #region Menu Buttons Clicks
        private void SetCategoryAndArticle(string ctg)
        {
            category = ctg;
            menuBtn.Text = ctg;
            categorySelected = true;
        }
        private void ShowMenu(ContextMenuStrip menu, Button btn)
        {
            menu.Show(btn, new Point(0, btn.Height));
        }
        private void menuBtn_Click(object sender, EventArgs e)
        {
            ShowMenu(categoryMenu, menuBtn);
        }
        private void categoryMenuAll_Click(object sender, EventArgs e)
        {
            categorySelected = false;
            menuBtn.Text = "All";
        }
        private void categoryMenuUtilBtn_Click_1(object sender, EventArgs e)
        {
            SetCategoryAndArticle("Utility");
        }
        private void categoryMenuFood_Click_1(object sender, EventArgs e)
        {
            SetCategoryAndArticle("Food");
        }

        private void categoryMenuTransportationBtn_Click_1(object sender, EventArgs e)
        {
            SetCategoryAndArticle("Transport");
        }

        private void categoryMenuKitchenProducts_Click_1(object sender, EventArgs e)
        {
            SetCategoryAndArticle("Kitchen products");
        }

        private void categoryMenuBodyFaceCare_Click_1(object sender, EventArgs e)
        {
            SetCategoryAndArticle("Body Hair Face care");
        }

        private void categoryMenuWardrobe_Click_1(object sender, EventArgs e)
        {
            SetCategoryAndArticle("Wardrobe");
        }

        private void categoryMenuLaundryProducts_Click_1(object sender, EventArgs e)
        {
            SetCategoryAndArticle("Laundry products");
        }

        private void categoryMenuBabyCare_Click_1(object sender, EventArgs e)
        {
            SetCategoryAndArticle("Baby");
        }

        private void categoryMenuKids_Click_1(object sender, EventArgs e)
        {
            SetCategoryAndArticle("Kids");
        }

        private void categoryMenuPets_Click_1(object sender, EventArgs e)
        {
            SetCategoryAndArticle("Pets");
        }

        private void categoryMenuGarden_Click_1(object sender, EventArgs e)
        {
            SetCategoryAndArticle("Garden");
        }

        private void categoryMenuPharmacy_Click_1(object sender, EventArgs e)
        {
            SetCategoryAndArticle("Pharmacy");
        }

        private void categoryMenuNotListedBtn_Click_1(object sender, EventArgs e)
        {
            SetCategoryAndArticle("Not Listed");
        }
        #endregion
    }
}
