namespace Budgeteer
{
    partial class AddingExpense
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
            this.amountTxt = new System.Windows.Forms.TextBox();
            this.articleTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.categoryMenuBtn = new System.Windows.Forms.Button();
            this.listBoxAddedValues = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.quantityTxtBox = new System.Windows.Forms.TextBox();
            this.categoryMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.categoryMenuTransportationBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryMenuNotListedBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryMenuFood = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryMenuUtilBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.electricityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.waterGarbageEtcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cableAndInternetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // amountTxt
            // 
            this.amountTxt.BackColor = System.Drawing.Color.White;
            this.amountTxt.Location = new System.Drawing.Point(379, 156);
            this.amountTxt.Name = "amountTxt";
            this.amountTxt.Size = new System.Drawing.Size(100, 20);
            this.amountTxt.TabIndex = 0;
            // 
            // articleTxt
            // 
            this.articleTxt.BackColor = System.Drawing.Color.White;
            this.articleTxt.Location = new System.Drawing.Point(379, 192);
            this.articleTxt.Name = "articleTxt";
            this.articleTxt.Size = new System.Drawing.Size(100, 20);
            this.articleTxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(485, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(485, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Article";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(210)))), ((int)(((byte)(164)))));
            this.dateTimePicker.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(210)))), ((int)(((byte)(164)))));
            this.dateTimePicker.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(210)))), ((int)(((byte)(164)))));
            this.dateTimePicker.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Location = new System.Drawing.Point(379, 120);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(154, 21);
            this.dateTimePicker.TabIndex = 6;
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(67)))), ((int)(((byte)(20)))));
            this.SubmitBtn.FlatAppearance.BorderSize = 0;
            this.SubmitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitBtn.ForeColor = System.Drawing.Color.White;
            this.SubmitBtn.Location = new System.Drawing.Point(650, 230);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(160, 39);
            this.SubmitBtn.TabIndex = 7;
            this.SubmitBtn.Text = "Submit Expense";
            this.SubmitBtn.UseVisualStyleBackColor = false;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // categoryMenuBtn
            // 
            this.categoryMenuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(67)))), ((int)(((byte)(20)))));
            this.categoryMenuBtn.FlatAppearance.BorderSize = 0;
            this.categoryMenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoryMenuBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryMenuBtn.ForeColor = System.Drawing.Color.White;
            this.categoryMenuBtn.Location = new System.Drawing.Point(379, 237);
            this.categoryMenuBtn.Name = "categoryMenuBtn";
            this.categoryMenuBtn.Size = new System.Drawing.Size(110, 26);
            this.categoryMenuBtn.TabIndex = 10;
            this.categoryMenuBtn.Text = "Category";
            this.categoryMenuBtn.UseVisualStyleBackColor = false;
            this.categoryMenuBtn.Click += new System.EventHandler(this.categoryMenuBtn_Click);
            // 
            // listBoxAddedValues
            // 
            this.listBoxAddedValues.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxAddedValues.FormattingEnabled = true;
            this.listBoxAddedValues.ItemHeight = 17;
            this.listBoxAddedValues.Location = new System.Drawing.Point(379, 292);
            this.listBoxAddedValues.Name = "listBoxAddedValues";
            this.listBoxAddedValues.Size = new System.Drawing.Size(431, 208);
            this.listBoxAddedValues.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(539, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Quantity";
            // 
            // quantityTxtBox
            // 
            this.quantityTxtBox.BackColor = System.Drawing.Color.White;
            this.quantityTxtBox.Location = new System.Drawing.Point(503, 237);
            this.quantityTxtBox.Name = "quantityTxtBox";
            this.quantityTxtBox.Size = new System.Drawing.Size(30, 20);
            this.quantityTxtBox.TabIndex = 12;
            this.quantityTxtBox.Text = "1";
            // 
            // categoryMenu
            // 
            this.categoryMenu.BackColor = System.Drawing.Color.White;
            this.categoryMenu.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoryMenuUtilBtn,
            this.categoryMenuFood,
            this.categoryMenuTransportationBtn,
            this.categoryMenuNotListedBtn});
            this.categoryMenu.Name = "categoryMenu";
            this.categoryMenu.Size = new System.Drawing.Size(181, 114);
            // 
            // categoryMenuTransportationBtn
            // 
            this.categoryMenuTransportationBtn.Name = "categoryMenuTransportationBtn";
            this.categoryMenuTransportationBtn.Size = new System.Drawing.Size(161, 22);
            this.categoryMenuTransportationBtn.Text = "Transportation";
            this.categoryMenuTransportationBtn.Click += new System.EventHandler(this.categoryMenuTransportationBtn_Click);
            // 
            // categoryMenuNotListedBtn
            // 
            this.categoryMenuNotListedBtn.Name = "categoryMenuNotListedBtn";
            this.categoryMenuNotListedBtn.Size = new System.Drawing.Size(161, 22);
            this.categoryMenuNotListedBtn.Text = "Not Listed";
            this.categoryMenuNotListedBtn.Click += new System.EventHandler(this.categoryMenuNotListedBtn_Click);
            // 
            // categoryMenuFood
            // 
            this.categoryMenuFood.Name = "categoryMenuFood";
            this.categoryMenuFood.Size = new System.Drawing.Size(161, 22);
            this.categoryMenuFood.Text = "Food";
            this.categoryMenuFood.Click += new System.EventHandler(this.categoryMenuFood_Click);
            // 
            // categoryMenuUtilBtn
            // 
            this.categoryMenuUtilBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.electricityToolStripMenuItem,
            this.waterGarbageEtcToolStripMenuItem,
            this.cableAndInternetToolStripMenuItem,
            this.phoneToolStripMenuItem});
            this.categoryMenuUtilBtn.Name = "categoryMenuUtilBtn";
            this.categoryMenuUtilBtn.Size = new System.Drawing.Size(180, 22);
            this.categoryMenuUtilBtn.Text = "Utility";
            this.categoryMenuUtilBtn.Click += new System.EventHandler(this.categoryMenuUtilBtn_Click);
            // 
            // electricityToolStripMenuItem
            // 
            this.electricityToolStripMenuItem.Name = "electricityToolStripMenuItem";
            this.electricityToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.electricityToolStripMenuItem.Text = "Electricity";
            // 
            // waterGarbageEtcToolStripMenuItem
            // 
            this.waterGarbageEtcToolStripMenuItem.Name = "waterGarbageEtcToolStripMenuItem";
            this.waterGarbageEtcToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.waterGarbageEtcToolStripMenuItem.Text = "Water Garbage etc.";
            // 
            // cableAndInternetToolStripMenuItem
            // 
            this.cableAndInternetToolStripMenuItem.Name = "cableAndInternetToolStripMenuItem";
            this.cableAndInternetToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.cableAndInternetToolStripMenuItem.Text = "Cable and Internet";
            // 
            // phoneToolStripMenuItem
            // 
            this.phoneToolStripMenuItem.Name = "phoneToolStripMenuItem";
            this.phoneToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.phoneToolStripMenuItem.Text = "Phone";
            // 
            // AddingExpense
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(94)))), ((int)(((byte)(26)))));
            this.Controls.Add(this.label3);
            this.Controls.Add(this.quantityTxtBox);
            this.Controls.Add(this.listBoxAddedValues);
            this.Controls.Add(this.categoryMenuBtn);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.articleTxt);
            this.Controls.Add(this.amountTxt);
            this.Name = "AddingExpense";
            this.Size = new System.Drawing.Size(1188, 629);
            this.categoryMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox amountTxt;
        private System.Windows.Forms.TextBox articleTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.Button categoryMenuBtn;
        private System.Windows.Forms.ListBox listBoxAddedValues;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox quantityTxtBox;
        private System.Windows.Forms.ContextMenuStrip categoryMenu;
        private System.Windows.Forms.ToolStripMenuItem categoryMenuUtilBtn;
        private System.Windows.Forms.ToolStripMenuItem categoryMenuFood;
        private System.Windows.Forms.ToolStripMenuItem categoryMenuNotListedBtn;
        private System.Windows.Forms.ToolStripMenuItem categoryMenuTransportationBtn;
        private System.Windows.Forms.ToolStripMenuItem electricityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem waterGarbageEtcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cableAndInternetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phoneToolStripMenuItem;
    }
}
