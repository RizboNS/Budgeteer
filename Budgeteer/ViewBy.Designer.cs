namespace Budgeteer
{
    partial class ViewBy
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.loadByTime = new System.Windows.Forms.Button();
            this.fullLoadBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxSum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.clearTableBtn = new System.Windows.Forms.Button();
            this.deleteSelectedRowBtn = new System.Windows.Forms.Button();
            this.categoryMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.categoryMenuAll = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryMenuUtilBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryMenuFood = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryMenuTransportationBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryMenuKitchenProducts = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryMenuBodyFaceCare = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryMenuWardrobe = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryMenuLaundryProducts = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryMenuBabyCare = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryMenuKids = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryMenuPets = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryMenuGarden = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryMenuPharmacy = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryMenuNotListedBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtn = new System.Windows.Forms.Button();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expenseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.categoryMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expenseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(623, 20);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 0;
            // 
            // loadByTime
            // 
            this.loadByTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(67)))), ((int)(((byte)(20)))));
            this.loadByTime.FlatAppearance.BorderSize = 0;
            this.loadByTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadByTime.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadByTime.ForeColor = System.Drawing.Color.White;
            this.loadByTime.Location = new System.Drawing.Point(633, 46);
            this.loadByTime.Name = "loadByTime";
            this.loadByTime.Size = new System.Drawing.Size(179, 28);
            this.loadByTime.TabIndex = 2;
            this.loadByTime.Text = "Load by Month";
            this.loadByTime.UseVisualStyleBackColor = false;
            this.loadByTime.Click += new System.EventHandler(this.TestBtn_Click);
            // 
            // fullLoadBtn
            // 
            this.fullLoadBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(67)))), ((int)(((byte)(20)))));
            this.fullLoadBtn.FlatAppearance.BorderSize = 0;
            this.fullLoadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fullLoadBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullLoadBtn.ForeColor = System.Drawing.Color.White;
            this.fullLoadBtn.Location = new System.Drawing.Point(488, 46);
            this.fullLoadBtn.Name = "fullLoadBtn";
            this.fullLoadBtn.Size = new System.Drawing.Size(139, 28);
            this.fullLoadBtn.TabIndex = 1;
            this.fullLoadBtn.Text = "Load everything";
            this.fullLoadBtn.UseVisualStyleBackColor = false;
            this.fullLoadBtn.Click += new System.EventHandler(this.Button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(205)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(210)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(94)))), ((int)(((byte)(26)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.amountDataGridViewTextBoxColumn,
            this.monthDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.articleDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.expenseBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(94)))), ((int)(((byte)(26)))));
            this.dataGridView1.Location = new System.Drawing.Point(488, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(94)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(210)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(470, 292);
            this.dataGridView1.TabIndex = 3;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // textBoxSum
            // 
            this.textBoxSum.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSum.Location = new System.Drawing.Point(898, 412);
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.ReadOnly = true;
            this.textBoxSum.Size = new System.Drawing.Size(60, 23);
            this.textBoxSum.TabIndex = 2;
            this.textBoxSum.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(815, 415);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total sum";
            // 
            // textBoxCount
            // 
            this.textBoxCount.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCount.Location = new System.Drawing.Point(898, 436);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.ReadOnly = true;
            this.textBoxCount.Size = new System.Drawing.Size(60, 23);
            this.textBoxCount.TabIndex = 4;
            this.textBoxCount.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(815, 441);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Items";
            // 
            // clearTableBtn
            // 
            this.clearTableBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(67)))), ((int)(((byte)(20)))));
            this.clearTableBtn.FlatAppearance.BorderSize = 0;
            this.clearTableBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.clearTableBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.clearTableBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearTableBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearTableBtn.ForeColor = System.Drawing.Color.White;
            this.clearTableBtn.Location = new System.Drawing.Point(818, 80);
            this.clearTableBtn.Name = "clearTableBtn";
            this.clearTableBtn.Size = new System.Drawing.Size(140, 28);
            this.clearTableBtn.TabIndex = 6;
            this.clearTableBtn.TabStop = false;
            this.clearTableBtn.Text = "Delete all";
            this.clearTableBtn.UseVisualStyleBackColor = false;
            this.clearTableBtn.Click += new System.EventHandler(this.clearTableBtn_Click);
            // 
            // deleteSelectedRowBtn
            // 
            this.deleteSelectedRowBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(67)))), ((int)(((byte)(20)))));
            this.deleteSelectedRowBtn.FlatAppearance.BorderSize = 0;
            this.deleteSelectedRowBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.deleteSelectedRowBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.deleteSelectedRowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedRowBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteSelectedRowBtn.ForeColor = System.Drawing.Color.White;
            this.deleteSelectedRowBtn.Location = new System.Drawing.Point(818, 46);
            this.deleteSelectedRowBtn.Name = "deleteSelectedRowBtn";
            this.deleteSelectedRowBtn.Size = new System.Drawing.Size(140, 28);
            this.deleteSelectedRowBtn.TabIndex = 4;
            this.deleteSelectedRowBtn.TabStop = false;
            this.deleteSelectedRowBtn.Text = "Delete Selected Row";
            this.deleteSelectedRowBtn.UseVisualStyleBackColor = false;
            this.deleteSelectedRowBtn.Click += new System.EventHandler(this.deleteSelectedRowBtn_Click);
            // 
            // categoryMenu
            // 
            this.categoryMenu.BackColor = System.Drawing.Color.White;
            this.categoryMenu.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoryMenuAll,
            this.categoryMenuUtilBtn,
            this.categoryMenuFood,
            this.categoryMenuTransportationBtn,
            this.categoryMenuKitchenProducts,
            this.categoryMenuBodyFaceCare,
            this.categoryMenuWardrobe,
            this.categoryMenuLaundryProducts,
            this.categoryMenuBabyCare,
            this.categoryMenuKids,
            this.categoryMenuPets,
            this.categoryMenuGarden,
            this.categoryMenuPharmacy,
            this.categoryMenuNotListedBtn});
            this.categoryMenu.Name = "categoryMenu";
            this.categoryMenu.Size = new System.Drawing.Size(222, 312);
            // 
            // categoryMenuAll
            // 
            this.categoryMenuAll.Name = "categoryMenuAll";
            this.categoryMenuAll.Size = new System.Drawing.Size(221, 22);
            this.categoryMenuAll.Text = "All";
            this.categoryMenuAll.Click += new System.EventHandler(this.categoryMenuAll_Click);
            // 
            // categoryMenuUtilBtn
            // 
            this.categoryMenuUtilBtn.Name = "categoryMenuUtilBtn";
            this.categoryMenuUtilBtn.Size = new System.Drawing.Size(221, 22);
            this.categoryMenuUtilBtn.Text = "Utility";
            this.categoryMenuUtilBtn.Click += new System.EventHandler(this.categoryMenuUtilBtn_Click_1);
            // 
            // categoryMenuFood
            // 
            this.categoryMenuFood.Name = "categoryMenuFood";
            this.categoryMenuFood.Size = new System.Drawing.Size(221, 22);
            this.categoryMenuFood.Text = "Food";
            this.categoryMenuFood.Click += new System.EventHandler(this.categoryMenuFood_Click_1);
            // 
            // categoryMenuTransportationBtn
            // 
            this.categoryMenuTransportationBtn.Name = "categoryMenuTransportationBtn";
            this.categoryMenuTransportationBtn.Size = new System.Drawing.Size(221, 22);
            this.categoryMenuTransportationBtn.Text = "Transportation";
            this.categoryMenuTransportationBtn.Click += new System.EventHandler(this.categoryMenuTransportationBtn_Click_1);
            // 
            // categoryMenuKitchenProducts
            // 
            this.categoryMenuKitchenProducts.Name = "categoryMenuKitchenProducts";
            this.categoryMenuKitchenProducts.Size = new System.Drawing.Size(221, 22);
            this.categoryMenuKitchenProducts.Text = "Kitchen products";
            this.categoryMenuKitchenProducts.Click += new System.EventHandler(this.categoryMenuKitchenProducts_Click_1);
            // 
            // categoryMenuBodyFaceCare
            // 
            this.categoryMenuBodyFaceCare.Name = "categoryMenuBodyFaceCare";
            this.categoryMenuBodyFaceCare.Size = new System.Drawing.Size(221, 22);
            this.categoryMenuBodyFaceCare.Text = "Body Hair and Face care";
            this.categoryMenuBodyFaceCare.Click += new System.EventHandler(this.categoryMenuBodyFaceCare_Click_1);
            // 
            // categoryMenuWardrobe
            // 
            this.categoryMenuWardrobe.Name = "categoryMenuWardrobe";
            this.categoryMenuWardrobe.Size = new System.Drawing.Size(221, 22);
            this.categoryMenuWardrobe.Text = "Wardrobe";
            this.categoryMenuWardrobe.Click += new System.EventHandler(this.categoryMenuWardrobe_Click_1);
            // 
            // categoryMenuLaundryProducts
            // 
            this.categoryMenuLaundryProducts.Name = "categoryMenuLaundryProducts";
            this.categoryMenuLaundryProducts.Size = new System.Drawing.Size(221, 22);
            this.categoryMenuLaundryProducts.Text = "Laundry products";
            this.categoryMenuLaundryProducts.Click += new System.EventHandler(this.categoryMenuLaundryProducts_Click_1);
            // 
            // categoryMenuBabyCare
            // 
            this.categoryMenuBabyCare.Name = "categoryMenuBabyCare";
            this.categoryMenuBabyCare.Size = new System.Drawing.Size(221, 22);
            this.categoryMenuBabyCare.Text = "Baby Care";
            this.categoryMenuBabyCare.Click += new System.EventHandler(this.categoryMenuBabyCare_Click_1);
            // 
            // categoryMenuKids
            // 
            this.categoryMenuKids.Name = "categoryMenuKids";
            this.categoryMenuKids.Size = new System.Drawing.Size(221, 22);
            this.categoryMenuKids.Text = "Kids";
            this.categoryMenuKids.Click += new System.EventHandler(this.categoryMenuKids_Click_1);
            // 
            // categoryMenuPets
            // 
            this.categoryMenuPets.Name = "categoryMenuPets";
            this.categoryMenuPets.Size = new System.Drawing.Size(221, 22);
            this.categoryMenuPets.Text = "Pets";
            this.categoryMenuPets.Click += new System.EventHandler(this.categoryMenuPets_Click_1);
            // 
            // categoryMenuGarden
            // 
            this.categoryMenuGarden.Name = "categoryMenuGarden";
            this.categoryMenuGarden.Size = new System.Drawing.Size(221, 22);
            this.categoryMenuGarden.Text = "Garden";
            this.categoryMenuGarden.Click += new System.EventHandler(this.categoryMenuGarden_Click_1);
            // 
            // categoryMenuPharmacy
            // 
            this.categoryMenuPharmacy.Name = "categoryMenuPharmacy";
            this.categoryMenuPharmacy.Size = new System.Drawing.Size(221, 22);
            this.categoryMenuPharmacy.Text = "Pharmacy";
            this.categoryMenuPharmacy.Click += new System.EventHandler(this.categoryMenuPharmacy_Click_1);
            // 
            // categoryMenuNotListedBtn
            // 
            this.categoryMenuNotListedBtn.Name = "categoryMenuNotListedBtn";
            this.categoryMenuNotListedBtn.Size = new System.Drawing.Size(221, 22);
            this.categoryMenuNotListedBtn.Text = "Not Listed";
            this.categoryMenuNotListedBtn.Click += new System.EventHandler(this.categoryMenuNotListedBtn_Click_1);
            // 
            // menuBtn
            // 
            this.menuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(67)))), ((int)(((byte)(20)))));
            this.menuBtn.FlatAppearance.BorderSize = 0;
            this.menuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuBtn.ForeColor = System.Drawing.Color.White;
            this.menuBtn.Location = new System.Drawing.Point(488, 80);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Size = new System.Drawing.Size(324, 28);
            this.menuBtn.TabIndex = 9;
            this.menuBtn.Text = "Specify category";
            this.menuBtn.UseVisualStyleBackColor = false;
            this.menuBtn.Click += new System.EventHandler(this.menuBtn_Click);
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Price";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // monthDataGridViewTextBoxColumn
            // 
            this.monthDataGridViewTextBoxColumn.DataPropertyName = "month";
            this.monthDataGridViewTextBoxColumn.HeaderText = "Month";
            this.monthDataGridViewTextBoxColumn.Name = "monthDataGridViewTextBoxColumn";
            this.monthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            this.yearDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // articleDataGridViewTextBoxColumn
            // 
            this.articleDataGridViewTextBoxColumn.DataPropertyName = "article";
            this.articleDataGridViewTextBoxColumn.HeaderText = "Article";
            this.articleDataGridViewTextBoxColumn.Name = "articleDataGridViewTextBoxColumn";
            this.articleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expenseBindingSource
            // 
            this.expenseBindingSource.DataSource = typeof(Budgeteer.Classes.Expense.Expense);
            // 
            // ViewBy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(94)))), ((int)(((byte)(26)))));
            this.Controls.Add(this.menuBtn);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.clearTableBtn);
            this.Controls.Add(this.fullLoadBtn);
            this.Controls.Add(this.loadByTime);
            this.Controls.Add(this.deleteSelectedRowBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSum);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ViewBy";
            this.Size = new System.Drawing.Size(981, 523);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.categoryMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.expenseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button fullLoadBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource expenseBindingSource;
        private System.Windows.Forms.Button loadByTime;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox textBoxSum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button clearTableBtn;
        private System.Windows.Forms.Button deleteSelectedRowBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn articleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip categoryMenu;
        private System.Windows.Forms.ToolStripMenuItem categoryMenuUtilBtn;
        private System.Windows.Forms.ToolStripMenuItem categoryMenuFood;
        private System.Windows.Forms.ToolStripMenuItem categoryMenuTransportationBtn;
        private System.Windows.Forms.ToolStripMenuItem categoryMenuKitchenProducts;
        private System.Windows.Forms.ToolStripMenuItem categoryMenuBodyFaceCare;
        private System.Windows.Forms.ToolStripMenuItem categoryMenuWardrobe;
        private System.Windows.Forms.ToolStripMenuItem categoryMenuLaundryProducts;
        private System.Windows.Forms.ToolStripMenuItem categoryMenuBabyCare;
        private System.Windows.Forms.ToolStripMenuItem categoryMenuKids;
        private System.Windows.Forms.ToolStripMenuItem categoryMenuPets;
        private System.Windows.Forms.ToolStripMenuItem categoryMenuGarden;
        private System.Windows.Forms.ToolStripMenuItem categoryMenuPharmacy;
        private System.Windows.Forms.ToolStripMenuItem categoryMenuNotListedBtn;
        private System.Windows.Forms.Button menuBtn;
        private System.Windows.Forms.ToolStripMenuItem categoryMenuAll;
    }
}
