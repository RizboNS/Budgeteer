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
            this.menuPanel = new System.Windows.Forms.Panel();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.loadByTime = new System.Windows.Forms.Button();
            this.fullLoadBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxSum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUtilitySum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxUtilityCount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFoodSum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxFoodCount = new System.Windows.Forms.TextBox();
            this.labelItemsCount = new System.Windows.Forms.Label();
            this.textBoxTranspSum = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxTranspCount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNotListSum = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxNotListCount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.clearTableBtn = new System.Windows.Forms.Button();
            this.deleteSelectedRowBtn = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expenseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(67)))), ((int)(((byte)(20)))));
            this.menuPanel.Controls.Add(this.clearTableBtn);
            this.menuPanel.Controls.Add(this.dateTimePicker);
            this.menuPanel.Controls.Add(this.loadByTime);
            this.menuPanel.Controls.Add(this.fullLoadBtn);
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(203, 629);
            this.menuPanel.TabIndex = 0;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(4, 68);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 2;
            // 
            // loadByTime
            // 
            this.loadByTime.FlatAppearance.BorderSize = 0;
            this.loadByTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadByTime.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadByTime.ForeColor = System.Drawing.Color.White;
            this.loadByTime.Location = new System.Drawing.Point(0, 101);
            this.loadByTime.Name = "loadByTime";
            this.loadByTime.Size = new System.Drawing.Size(203, 61);
            this.loadByTime.TabIndex = 1;
            this.loadByTime.Text = "Load Table by Month";
            this.loadByTime.UseVisualStyleBackColor = true;
            this.loadByTime.Click += new System.EventHandler(this.TestBtn_Click);
            // 
            // fullLoadBtn
            // 
            this.fullLoadBtn.FlatAppearance.BorderSize = 0;
            this.fullLoadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fullLoadBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullLoadBtn.ForeColor = System.Drawing.Color.White;
            this.fullLoadBtn.Location = new System.Drawing.Point(0, 0);
            this.fullLoadBtn.Name = "fullLoadBtn";
            this.fullLoadBtn.Size = new System.Drawing.Size(203, 61);
            this.fullLoadBtn.TabIndex = 0;
            this.fullLoadBtn.Text = "Full Load";
            this.fullLoadBtn.UseVisualStyleBackColor = true;
            this.fullLoadBtn.Click += new System.EventHandler(this.Button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(205)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(210)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
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
            this.dataGridView1.Location = new System.Drawing.Point(247, 72);
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
            this.dataGridView1.Size = new System.Drawing.Size(296, 292);
            this.dataGridView1.TabIndex = 1;
            // 
            // textBoxSum
            // 
            this.textBoxSum.Location = new System.Drawing.Point(581, 72);
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.ReadOnly = true;
            this.textBoxSum.Size = new System.Drawing.Size(77, 20);
            this.textBoxSum.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(663, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total Sum";
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(787, 72);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.ReadOnly = true;
            this.textBoxCount.Size = new System.Drawing.Size(77, 20);
            this.textBoxCount.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(884, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Items Count";
            // 
            // textBoxUtilitySum
            // 
            this.textBoxUtilitySum.Location = new System.Drawing.Point(581, 124);
            this.textBoxUtilitySum.Name = "textBoxUtilitySum";
            this.textBoxUtilitySum.ReadOnly = true;
            this.textBoxUtilitySum.Size = new System.Drawing.Size(77, 20);
            this.textBoxUtilitySum.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(663, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sum Utility";
            // 
            // textBoxUtilityCount
            // 
            this.textBoxUtilityCount.Location = new System.Drawing.Point(787, 124);
            this.textBoxUtilityCount.Name = "textBoxUtilityCount";
            this.textBoxUtilityCount.ReadOnly = true;
            this.textBoxUtilityCount.Size = new System.Drawing.Size(77, 20);
            this.textBoxUtilityCount.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(884, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Items Count";
            // 
            // textBoxFoodSum
            // 
            this.textBoxFoodSum.Location = new System.Drawing.Point(581, 176);
            this.textBoxFoodSum.Name = "textBoxFoodSum";
            this.textBoxFoodSum.ReadOnly = true;
            this.textBoxFoodSum.Size = new System.Drawing.Size(77, 20);
            this.textBoxFoodSum.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(664, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Sum Food";
            // 
            // textBoxFoodCount
            // 
            this.textBoxFoodCount.Location = new System.Drawing.Point(787, 177);
            this.textBoxFoodCount.Name = "textBoxFoodCount";
            this.textBoxFoodCount.ReadOnly = true;
            this.textBoxFoodCount.Size = new System.Drawing.Size(77, 20);
            this.textBoxFoodCount.TabIndex = 12;
            // 
            // labelItemsCount
            // 
            this.labelItemsCount.AutoSize = true;
            this.labelItemsCount.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItemsCount.ForeColor = System.Drawing.Color.White;
            this.labelItemsCount.Location = new System.Drawing.Point(884, 172);
            this.labelItemsCount.Name = "labelItemsCount";
            this.labelItemsCount.Size = new System.Drawing.Size(73, 16);
            this.labelItemsCount.TabIndex = 13;
            this.labelItemsCount.Text = "Items Count";
            // 
            // textBoxTranspSum
            // 
            this.textBoxTranspSum.Location = new System.Drawing.Point(581, 228);
            this.textBoxTranspSum.Name = "textBoxTranspSum";
            this.textBoxTranspSum.ReadOnly = true;
            this.textBoxTranspSum.Size = new System.Drawing.Size(77, 20);
            this.textBoxTranspSum.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(664, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Sum Transportation";
            // 
            // textBoxTranspCount
            // 
            this.textBoxTranspCount.Location = new System.Drawing.Point(787, 226);
            this.textBoxTranspCount.Name = "textBoxTranspCount";
            this.textBoxTranspCount.ReadOnly = true;
            this.textBoxTranspCount.Size = new System.Drawing.Size(77, 20);
            this.textBoxTranspCount.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(884, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Items Count";
            // 
            // textBoxNotListSum
            // 
            this.textBoxNotListSum.Location = new System.Drawing.Point(581, 280);
            this.textBoxNotListSum.Name = "textBoxNotListSum";
            this.textBoxNotListSum.ReadOnly = true;
            this.textBoxNotListSum.Size = new System.Drawing.Size(77, 20);
            this.textBoxNotListSum.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(661, 280);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Sum Not listed";
            // 
            // textBoxNotListCount
            // 
            this.textBoxNotListCount.Location = new System.Drawing.Point(787, 278);
            this.textBoxNotListCount.Name = "textBoxNotListCount";
            this.textBoxNotListCount.ReadOnly = true;
            this.textBoxNotListCount.Size = new System.Drawing.Size(77, 20);
            this.textBoxNotListCount.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(884, 278);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Items Count";
            // 
            // clearTableBtn
            // 
            this.clearTableBtn.FlatAppearance.BorderSize = 0;
            this.clearTableBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearTableBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearTableBtn.ForeColor = System.Drawing.Color.White;
            this.clearTableBtn.Location = new System.Drawing.Point(0, 168);
            this.clearTableBtn.Name = "clearTableBtn";
            this.clearTableBtn.Size = new System.Drawing.Size(203, 61);
            this.clearTableBtn.TabIndex = 3;
            this.clearTableBtn.Text = "Delete all data";
            this.clearTableBtn.UseVisualStyleBackColor = true;
            this.clearTableBtn.Click += new System.EventHandler(this.clearTableBtn_Click);
            // 
            // deleteSelectedRowBtn
            // 
            this.deleteSelectedRowBtn.FlatAppearance.BorderSize = 0;
            this.deleteSelectedRowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedRowBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteSelectedRowBtn.ForeColor = System.Drawing.Color.White;
            this.deleteSelectedRowBtn.Location = new System.Drawing.Point(247, 23);
            this.deleteSelectedRowBtn.Name = "deleteSelectedRowBtn";
            this.deleteSelectedRowBtn.Size = new System.Drawing.Size(296, 43);
            this.deleteSelectedRowBtn.TabIndex = 4;
            this.deleteSelectedRowBtn.Text = "Delete Selected Row";
            this.deleteSelectedRowBtn.UseVisualStyleBackColor = true;
            this.deleteSelectedRowBtn.Click += new System.EventHandler(this.deleteSelectedRowBtn_Click);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            this.Id.Width = 26;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Price";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            this.amountDataGridViewTextBoxColumn.Width = 68;
            // 
            // monthDataGridViewTextBoxColumn
            // 
            this.monthDataGridViewTextBoxColumn.DataPropertyName = "month";
            this.monthDataGridViewTextBoxColumn.HeaderText = "Month";
            this.monthDataGridViewTextBoxColumn.Name = "monthDataGridViewTextBoxColumn";
            this.monthDataGridViewTextBoxColumn.ReadOnly = true;
            this.monthDataGridViewTextBoxColumn.Width = 77;
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            this.yearDataGridViewTextBoxColumn.ReadOnly = true;
            this.yearDataGridViewTextBoxColumn.Width = 65;
            // 
            // articleDataGridViewTextBoxColumn
            // 
            this.articleDataGridViewTextBoxColumn.DataPropertyName = "article";
            this.articleDataGridViewTextBoxColumn.HeaderText = "Article";
            this.articleDataGridViewTextBoxColumn.Name = "articleDataGridViewTextBoxColumn";
            this.articleDataGridViewTextBoxColumn.ReadOnly = true;
            this.articleDataGridViewTextBoxColumn.Width = 79;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            this.categoryDataGridViewTextBoxColumn.Width = 101;
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
            this.Controls.Add(this.deleteSelectedRowBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxNotListCount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxNotListSum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxTranspCount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxTranspSum);
            this.Controls.Add(this.labelItemsCount);
            this.Controls.Add(this.textBoxFoodCount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxFoodSum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxUtilityCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxUtilitySum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSum);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuPanel);
            this.Name = "ViewBy";
            this.Size = new System.Drawing.Size(1188, 629);
            this.menuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button fullLoadBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource expenseBindingSource;
        private System.Windows.Forms.Button loadByTime;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox textBoxSum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxUtilitySum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxUtilityCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxFoodSum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxFoodCount;
        private System.Windows.Forms.Label labelItemsCount;
        private System.Windows.Forms.TextBox textBoxTranspSum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxTranspCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxNotListSum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxNotListCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button clearTableBtn;
        private System.Windows.Forms.Button deleteSelectedRowBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn articleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
    }
}
