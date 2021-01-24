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
            this.amountTxt = new System.Windows.Forms.TextBox();
            this.articleTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.categoryMenuPanel = new System.Windows.Forms.Panel();
            this.categoryMenuNotListed = new System.Windows.Forms.Button();
            this.categoryMenuCareProductsBtn = new System.Windows.Forms.Button();
            this.categoryMenuKidsBtn = new System.Windows.Forms.Button();
            this.categoryMenuNonEssentialsBtn = new System.Windows.Forms.Button();
            this.categoryMenuTransportationBtn = new System.Windows.Forms.Button();
            this.categoryMenuWardrobeBtn = new System.Windows.Forms.Button();
            this.categoryMenuFoodBtn = new System.Windows.Forms.Button();
            this.categoryMenuUtilBtn = new System.Windows.Forms.Button();
            this.categoryMenuBtn = new System.Windows.Forms.Button();
            this.listBoxAddedValues = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.quantityTxtBox = new System.Windows.Forms.TextBox();
            this.categoryMenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // amountTxt
            // 
            this.amountTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(210)))), ((int)(((byte)(164)))));
            this.amountTxt.Location = new System.Drawing.Point(295, 155);
            this.amountTxt.Name = "amountTxt";
            this.amountTxt.Size = new System.Drawing.Size(100, 20);
            this.amountTxt.TabIndex = 0;
            // 
            // articleTxt
            // 
            this.articleTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(210)))), ((int)(((byte)(164)))));
            this.articleTxt.Location = new System.Drawing.Point(295, 194);
            this.articleTxt.Name = "articleTxt";
            this.articleTxt.Size = new System.Drawing.Size(100, 20);
            this.articleTxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(401, 157);
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
            this.label2.Location = new System.Drawing.Point(401, 198);
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
            this.dateTimePicker.Location = new System.Drawing.Point(295, 119);
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
            this.SubmitBtn.Location = new System.Drawing.Point(532, 236);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(160, 39);
            this.SubmitBtn.TabIndex = 7;
            this.SubmitBtn.Text = "Submit Expense";
            this.SubmitBtn.UseVisualStyleBackColor = false;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // categoryMenuPanel
            // 
            this.categoryMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(67)))), ((int)(((byte)(20)))));
            this.categoryMenuPanel.Controls.Add(this.categoryMenuNotListed);
            this.categoryMenuPanel.Controls.Add(this.categoryMenuCareProductsBtn);
            this.categoryMenuPanel.Controls.Add(this.categoryMenuKidsBtn);
            this.categoryMenuPanel.Controls.Add(this.categoryMenuNonEssentialsBtn);
            this.categoryMenuPanel.Controls.Add(this.categoryMenuTransportationBtn);
            this.categoryMenuPanel.Controls.Add(this.categoryMenuWardrobeBtn);
            this.categoryMenuPanel.Controls.Add(this.categoryMenuFoodBtn);
            this.categoryMenuPanel.Controls.Add(this.categoryMenuUtilBtn);
            this.categoryMenuPanel.Location = new System.Drawing.Point(295, 259);
            this.categoryMenuPanel.Name = "categoryMenuPanel";
            this.categoryMenuPanel.Size = new System.Drawing.Size(100, 212);
            this.categoryMenuPanel.TabIndex = 9;
            this.categoryMenuPanel.Visible = false;
            // 
            // categoryMenuNotListed
            // 
            this.categoryMenuNotListed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(67)))), ((int)(((byte)(20)))));
            this.categoryMenuNotListed.FlatAppearance.BorderSize = 0;
            this.categoryMenuNotListed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoryMenuNotListed.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryMenuNotListed.ForeColor = System.Drawing.Color.White;
            this.categoryMenuNotListed.Location = new System.Drawing.Point(0, 179);
            this.categoryMenuNotListed.Name = "categoryMenuNotListed";
            this.categoryMenuNotListed.Size = new System.Drawing.Size(100, 26);
            this.categoryMenuNotListed.TabIndex = 18;
            this.categoryMenuNotListed.Text = "Not Listed";
            this.categoryMenuNotListed.UseVisualStyleBackColor = false;
            this.categoryMenuNotListed.Click += new System.EventHandler(this.categoryMenuNotListed_Click);
            // 
            // categoryMenuCareProductsBtn
            // 
            this.categoryMenuCareProductsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(67)))), ((int)(((byte)(20)))));
            this.categoryMenuCareProductsBtn.FlatAppearance.BorderSize = 0;
            this.categoryMenuCareProductsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoryMenuCareProductsBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryMenuCareProductsBtn.ForeColor = System.Drawing.Color.White;
            this.categoryMenuCareProductsBtn.Location = new System.Drawing.Point(0, 156);
            this.categoryMenuCareProductsBtn.Name = "categoryMenuCareProductsBtn";
            this.categoryMenuCareProductsBtn.Size = new System.Drawing.Size(100, 26);
            this.categoryMenuCareProductsBtn.TabIndex = 17;
            this.categoryMenuCareProductsBtn.Text = "Care Products";
            this.categoryMenuCareProductsBtn.UseVisualStyleBackColor = false;
            this.categoryMenuCareProductsBtn.Click += new System.EventHandler(this.categoryMenuCareProductsBtn_Click);
            // 
            // categoryMenuKidsBtn
            // 
            this.categoryMenuKidsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(67)))), ((int)(((byte)(20)))));
            this.categoryMenuKidsBtn.FlatAppearance.BorderSize = 0;
            this.categoryMenuKidsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoryMenuKidsBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryMenuKidsBtn.ForeColor = System.Drawing.Color.White;
            this.categoryMenuKidsBtn.Location = new System.Drawing.Point(0, 78);
            this.categoryMenuKidsBtn.Name = "categoryMenuKidsBtn";
            this.categoryMenuKidsBtn.Size = new System.Drawing.Size(100, 26);
            this.categoryMenuKidsBtn.TabIndex = 16;
            this.categoryMenuKidsBtn.Text = "Kids";
            this.categoryMenuKidsBtn.UseVisualStyleBackColor = false;
            this.categoryMenuKidsBtn.Click += new System.EventHandler(this.categoryMenuKidsBtn_Click);
            // 
            // categoryMenuNonEssentialsBtn
            // 
            this.categoryMenuNonEssentialsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(67)))), ((int)(((byte)(20)))));
            this.categoryMenuNonEssentialsBtn.FlatAppearance.BorderSize = 0;
            this.categoryMenuNonEssentialsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoryMenuNonEssentialsBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryMenuNonEssentialsBtn.ForeColor = System.Drawing.Color.White;
            this.categoryMenuNonEssentialsBtn.Location = new System.Drawing.Point(0, 130);
            this.categoryMenuNonEssentialsBtn.Name = "categoryMenuNonEssentialsBtn";
            this.categoryMenuNonEssentialsBtn.Size = new System.Drawing.Size(100, 26);
            this.categoryMenuNonEssentialsBtn.TabIndex = 15;
            this.categoryMenuNonEssentialsBtn.Text = "Non essentials";
            this.categoryMenuNonEssentialsBtn.UseVisualStyleBackColor = false;
            this.categoryMenuNonEssentialsBtn.Click += new System.EventHandler(this.categoryMenuNonEssentialsBtn_Click);
            // 
            // categoryMenuTransportationBtn
            // 
            this.categoryMenuTransportationBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(67)))), ((int)(((byte)(20)))));
            this.categoryMenuTransportationBtn.FlatAppearance.BorderSize = 0;
            this.categoryMenuTransportationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoryMenuTransportationBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryMenuTransportationBtn.ForeColor = System.Drawing.Color.White;
            this.categoryMenuTransportationBtn.Location = new System.Drawing.Point(0, 104);
            this.categoryMenuTransportationBtn.Name = "categoryMenuTransportationBtn";
            this.categoryMenuTransportationBtn.Size = new System.Drawing.Size(100, 26);
            this.categoryMenuTransportationBtn.TabIndex = 14;
            this.categoryMenuTransportationBtn.Text = "Transportation";
            this.categoryMenuTransportationBtn.UseVisualStyleBackColor = false;
            this.categoryMenuTransportationBtn.Click += new System.EventHandler(this.categoryMenuTransportationBtn_Click);
            // 
            // categoryMenuWardrobeBtn
            // 
            this.categoryMenuWardrobeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(67)))), ((int)(((byte)(20)))));
            this.categoryMenuWardrobeBtn.FlatAppearance.BorderSize = 0;
            this.categoryMenuWardrobeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoryMenuWardrobeBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryMenuWardrobeBtn.ForeColor = System.Drawing.Color.White;
            this.categoryMenuWardrobeBtn.Location = new System.Drawing.Point(0, 52);
            this.categoryMenuWardrobeBtn.Name = "categoryMenuWardrobeBtn";
            this.categoryMenuWardrobeBtn.Size = new System.Drawing.Size(100, 26);
            this.categoryMenuWardrobeBtn.TabIndex = 13;
            this.categoryMenuWardrobeBtn.Text = "Wardrobe";
            this.categoryMenuWardrobeBtn.UseVisualStyleBackColor = false;
            this.categoryMenuWardrobeBtn.Click += new System.EventHandler(this.categoryMenuWardrobeBtn_Click);
            // 
            // categoryMenuFoodBtn
            // 
            this.categoryMenuFoodBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(67)))), ((int)(((byte)(20)))));
            this.categoryMenuFoodBtn.FlatAppearance.BorderSize = 0;
            this.categoryMenuFoodBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoryMenuFoodBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryMenuFoodBtn.ForeColor = System.Drawing.Color.White;
            this.categoryMenuFoodBtn.Location = new System.Drawing.Point(0, 26);
            this.categoryMenuFoodBtn.Name = "categoryMenuFoodBtn";
            this.categoryMenuFoodBtn.Size = new System.Drawing.Size(100, 26);
            this.categoryMenuFoodBtn.TabIndex = 12;
            this.categoryMenuFoodBtn.Text = "Food";
            this.categoryMenuFoodBtn.UseVisualStyleBackColor = false;
            this.categoryMenuFoodBtn.Click += new System.EventHandler(this.categoryMenuFoodBtn_Click);
            // 
            // categoryMenuUtilBtn
            // 
            this.categoryMenuUtilBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(67)))), ((int)(((byte)(20)))));
            this.categoryMenuUtilBtn.FlatAppearance.BorderSize = 0;
            this.categoryMenuUtilBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoryMenuUtilBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryMenuUtilBtn.ForeColor = System.Drawing.Color.White;
            this.categoryMenuUtilBtn.Location = new System.Drawing.Point(0, 0);
            this.categoryMenuUtilBtn.Name = "categoryMenuUtilBtn";
            this.categoryMenuUtilBtn.Size = new System.Drawing.Size(100, 26);
            this.categoryMenuUtilBtn.TabIndex = 11;
            this.categoryMenuUtilBtn.Text = "Utility";
            this.categoryMenuUtilBtn.UseVisualStyleBackColor = false;
            this.categoryMenuUtilBtn.Click += new System.EventHandler(this.categoryMenuUtilBtn_Click);
            // 
            // categoryMenuBtn
            // 
            this.categoryMenuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(67)))), ((int)(((byte)(20)))));
            this.categoryMenuBtn.FlatAppearance.BorderSize = 0;
            this.categoryMenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoryMenuBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryMenuBtn.ForeColor = System.Drawing.Color.White;
            this.categoryMenuBtn.Location = new System.Drawing.Point(295, 236);
            this.categoryMenuBtn.Name = "categoryMenuBtn";
            this.categoryMenuBtn.Size = new System.Drawing.Size(100, 26);
            this.categoryMenuBtn.TabIndex = 10;
            this.categoryMenuBtn.Text = "Category";
            this.categoryMenuBtn.UseVisualStyleBackColor = false;
            this.categoryMenuBtn.Click += new System.EventHandler(this.categoryMenuBtn_Click);
            // 
            // listBoxAddedValues
            // 
            this.listBoxAddedValues.FormattingEnabled = true;
            this.listBoxAddedValues.Location = new System.Drawing.Point(295, 291);
            this.listBoxAddedValues.Name = "listBoxAddedValues";
            this.listBoxAddedValues.Size = new System.Drawing.Size(397, 238);
            this.listBoxAddedValues.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(455, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Quantity";
            // 
            // quantityTxtBox
            // 
            this.quantityTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(210)))), ((int)(((byte)(164)))));
            this.quantityTxtBox.Location = new System.Drawing.Point(419, 236);
            this.quantityTxtBox.Name = "quantityTxtBox";
            this.quantityTxtBox.Size = new System.Drawing.Size(30, 20);
            this.quantityTxtBox.TabIndex = 12;
            this.quantityTxtBox.Text = "1";
            // 
            // AddingExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(94)))), ((int)(((byte)(26)))));
            this.Controls.Add(this.label3);
            this.Controls.Add(this.quantityTxtBox);
            this.Controls.Add(this.categoryMenuPanel);
            this.Controls.Add(this.listBoxAddedValues);
            this.Controls.Add(this.categoryMenuBtn);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.articleTxt);
            this.Controls.Add(this.amountTxt);
            this.Name = "AddingExpense";
            this.Size = new System.Drawing.Size(1033, 601);
            this.categoryMenuPanel.ResumeLayout(false);
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
        private System.Windows.Forms.Panel categoryMenuPanel;
        private System.Windows.Forms.Button categoryMenuCareProductsBtn;
        private System.Windows.Forms.Button categoryMenuKidsBtn;
        private System.Windows.Forms.Button categoryMenuNonEssentialsBtn;
        private System.Windows.Forms.Button categoryMenuTransportationBtn;
        private System.Windows.Forms.Button categoryMenuWardrobeBtn;
        private System.Windows.Forms.Button categoryMenuFoodBtn;
        private System.Windows.Forms.Button categoryMenuUtilBtn;
        private System.Windows.Forms.Button categoryMenuBtn;
        private System.Windows.Forms.Button categoryMenuNotListed;
        private System.Windows.Forms.ListBox listBoxAddedValues;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox quantityTxtBox;
    }
}
