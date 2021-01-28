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
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.menuBtn = new System.Windows.Forms.Button();
            this.listBoxAddedValues = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.quantityTxtBox = new System.Windows.Forms.TextBox();
            this.categoryMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.categoryMenuUtilBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryMenuFood = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryMenuTransportationBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryMenuKitchenProducts = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryMenuBodyFaceCare = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryMenuWardrobe = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryMenuNotListedBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryMenuLaundryProducts = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryMenuBabyCare = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryMenuKids = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryMenuPets = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryMenuGarden = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryMenuPharmacy = new System.Windows.Forms.ToolStripMenuItem();
            this.itemTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.clearBoxBtn = new System.Windows.Forms.Button();
            this.categoryMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // amountTxt
            // 
            this.amountTxt.BackColor = System.Drawing.Color.White;
            this.amountTxt.Location = new System.Drawing.Point(17, 16);
            this.amountTxt.Name = "amountTxt";
            this.amountTxt.Size = new System.Drawing.Size(112, 20);
            this.amountTxt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(135, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Price";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(210)))), ((int)(((byte)(164)))));
            this.dateTimePicker.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(210)))), ((int)(((byte)(164)))));
            this.dateTimePicker.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(210)))), ((int)(((byte)(164)))));
            this.dateTimePicker.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Location = new System.Drawing.Point(369, 12);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(154, 21);
            this.dateTimePicker.TabIndex = 1;
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(67)))), ((int)(((byte)(20)))));
            this.SubmitBtn.FlatAppearance.BorderSize = 0;
            this.SubmitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitBtn.ForeColor = System.Drawing.Color.White;
            this.SubmitBtn.Location = new System.Drawing.Point(17, 84);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(506, 39);
            this.SubmitBtn.TabIndex = 4;
            this.SubmitBtn.Text = "Submit Expense";
            this.SubmitBtn.UseVisualStyleBackColor = false;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // menuBtn
            // 
            this.menuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(67)))), ((int)(((byte)(20)))));
            this.menuBtn.FlatAppearance.BorderSize = 0;
            this.menuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuBtn.ForeColor = System.Drawing.Color.White;
            this.menuBtn.Location = new System.Drawing.Point(17, 48);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Size = new System.Drawing.Size(200, 26);
            this.menuBtn.TabIndex = 2;
            this.menuBtn.Text = "Category";
            this.menuBtn.UseVisualStyleBackColor = false;
            this.menuBtn.Click += new System.EventHandler(this.CategoryMenuBtn_Click);
            this.menuBtn.Enter += new System.EventHandler(this.CategoryMenuBtn_Click);
            // 
            // listBoxAddedValues
            // 
            this.listBoxAddedValues.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxAddedValues.FormattingEnabled = true;
            this.listBoxAddedValues.ItemHeight = 17;
            this.listBoxAddedValues.Location = new System.Drawing.Point(17, 143);
            this.listBoxAddedValues.Name = "listBoxAddedValues";
            this.listBoxAddedValues.Size = new System.Drawing.Size(505, 361);
            this.listBoxAddedValues.TabIndex = 7;
            this.listBoxAddedValues.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(269, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quantity";
            // 
            // quantityTxtBox
            // 
            this.quantityTxtBox.BackColor = System.Drawing.Color.White;
            this.quantityTxtBox.Location = new System.Drawing.Point(233, 52);
            this.quantityTxtBox.Name = "quantityTxtBox";
            this.quantityTxtBox.Size = new System.Drawing.Size(30, 20);
            this.quantityTxtBox.TabIndex = 3;
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
            this.categoryMenu.Size = new System.Drawing.Size(222, 290);
            // 
            // categoryMenuUtilBtn
            // 
            this.categoryMenuUtilBtn.Name = "categoryMenuUtilBtn";
            this.categoryMenuUtilBtn.Size = new System.Drawing.Size(221, 22);
            this.categoryMenuUtilBtn.Text = "Utility";
            this.categoryMenuUtilBtn.Click += new System.EventHandler(this.categoryMenuUtilBtn_Click);
            // 
            // categoryMenuFood
            // 
            this.categoryMenuFood.Name = "categoryMenuFood";
            this.categoryMenuFood.Size = new System.Drawing.Size(221, 22);
            this.categoryMenuFood.Text = "Food";
            this.categoryMenuFood.Click += new System.EventHandler(this.categoryMenuFood_Click);
            // 
            // categoryMenuTransportationBtn
            // 
            this.categoryMenuTransportationBtn.Name = "categoryMenuTransportationBtn";
            this.categoryMenuTransportationBtn.Size = new System.Drawing.Size(221, 22);
            this.categoryMenuTransportationBtn.Text = "Transportation";
            this.categoryMenuTransportationBtn.Click += new System.EventHandler(this.categoryMenuTransportationBtn_Click);
            // 
            // categoryMenuKitchenProducts
            // 
            this.categoryMenuKitchenProducts.Name = "categoryMenuKitchenProducts";
            this.categoryMenuKitchenProducts.Size = new System.Drawing.Size(221, 22);
            this.categoryMenuKitchenProducts.Text = "Kitchen products";
            this.categoryMenuKitchenProducts.Click += new System.EventHandler(this.categoryMenuKitchenProducts_Click);
            // 
            // categoryMenuBodyFaceCare
            // 
            this.categoryMenuBodyFaceCare.Name = "categoryMenuBodyFaceCare";
            this.categoryMenuBodyFaceCare.Size = new System.Drawing.Size(221, 22);
            this.categoryMenuBodyFaceCare.Text = "Body Hair and Face care";
            this.categoryMenuBodyFaceCare.Click += new System.EventHandler(this.categoryMenuBodyFaceCare_Click);
            // 
            // categoryMenuWardrobe
            // 
            this.categoryMenuWardrobe.Name = "categoryMenuWardrobe";
            this.categoryMenuWardrobe.Size = new System.Drawing.Size(221, 22);
            this.categoryMenuWardrobe.Text = "Wardrobe";
            this.categoryMenuWardrobe.Click += new System.EventHandler(this.categoryMenuWardrobe_Click);
            // 
            // categoryMenuNotListedBtn
            // 
            this.categoryMenuNotListedBtn.Name = "categoryMenuNotListedBtn";
            this.categoryMenuNotListedBtn.Size = new System.Drawing.Size(221, 22);
            this.categoryMenuNotListedBtn.Text = "Not Listed";
            this.categoryMenuNotListedBtn.Click += new System.EventHandler(this.categoryMenuNotListedBtn_Click);
            // 
            // categoryMenuLaundryProducts
            // 
            this.categoryMenuLaundryProducts.Name = "categoryMenuLaundryProducts";
            this.categoryMenuLaundryProducts.Size = new System.Drawing.Size(221, 22);
            this.categoryMenuLaundryProducts.Text = "Laundry products";
            this.categoryMenuLaundryProducts.Click += new System.EventHandler(this.categoryMenuLaundryProducts_Click);
            // 
            // categoryMenuBabyCare
            // 
            this.categoryMenuBabyCare.Name = "categoryMenuBabyCare";
            this.categoryMenuBabyCare.Size = new System.Drawing.Size(221, 22);
            this.categoryMenuBabyCare.Text = "Baby Care";
            this.categoryMenuBabyCare.Click += new System.EventHandler(this.categoryMenuBabyCare_Click);
            // 
            // categoryMenuKids
            // 
            this.categoryMenuKids.Name = "categoryMenuKids";
            this.categoryMenuKids.Size = new System.Drawing.Size(221, 22);
            this.categoryMenuKids.Text = "Kids";
            this.categoryMenuKids.Click += new System.EventHandler(this.categoryMenuKids_Click);
            // 
            // categoryMenuPets
            // 
            this.categoryMenuPets.Name = "categoryMenuPets";
            this.categoryMenuPets.Size = new System.Drawing.Size(221, 22);
            this.categoryMenuPets.Text = "Pets";
            this.categoryMenuPets.Click += new System.EventHandler(this.categoryMenuPets_Click);
            // 
            // categoryMenuGarden
            // 
            this.categoryMenuGarden.Name = "categoryMenuGarden";
            this.categoryMenuGarden.Size = new System.Drawing.Size(221, 22);
            this.categoryMenuGarden.Text = "Garden";
            this.categoryMenuGarden.Click += new System.EventHandler(this.categoryMenuGarden_Click);
            // 
            // categoryMenuPharmacy
            // 
            this.categoryMenuPharmacy.Name = "categoryMenuPharmacy";
            this.categoryMenuPharmacy.Size = new System.Drawing.Size(221, 22);
            this.categoryMenuPharmacy.Text = "Pharmacy";
            this.categoryMenuPharmacy.Click += new System.EventHandler(this.categoryMenuPharmacy_Click);
            // 
            // itemTextBox
            // 
            this.itemTextBox.BackColor = System.Drawing.Color.White;
            this.itemTextBox.Location = new System.Drawing.Point(175, 16);
            this.itemTextBox.Name = "itemTextBox";
            this.itemTextBox.Size = new System.Drawing.Size(112, 20);
            this.itemTextBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(293, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Article";
            // 
            // clearBoxBtn
            // 
            this.clearBoxBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(67)))), ((int)(((byte)(20)))));
            this.clearBoxBtn.FlatAppearance.BorderSize = 0;
            this.clearBoxBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBoxBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBoxBtn.ForeColor = System.Drawing.Color.White;
            this.clearBoxBtn.Location = new System.Drawing.Point(369, 510);
            this.clearBoxBtn.Name = "clearBoxBtn";
            this.clearBoxBtn.Size = new System.Drawing.Size(153, 26);
            this.clearBoxBtn.TabIndex = 10;
            this.clearBoxBtn.Text = "Clear Box";
            this.clearBoxBtn.UseVisualStyleBackColor = false;
            this.clearBoxBtn.Click += new System.EventHandler(this.clearBoxBtn_Click);
            // 
            // AddingExpense
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(94)))), ((int)(((byte)(26)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.clearBoxBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.itemTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.quantityTxtBox);
            this.Controls.Add(this.listBoxAddedValues);
            this.Controls.Add(this.menuBtn);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.amountTxt);
            this.Name = "AddingExpense";
            this.Size = new System.Drawing.Size(540, 542);
            this.categoryMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox amountTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.Button menuBtn;
        private System.Windows.Forms.ListBox listBoxAddedValues;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox quantityTxtBox;
        private System.Windows.Forms.ContextMenuStrip categoryMenu;
        private System.Windows.Forms.ToolStripMenuItem categoryMenuUtilBtn;
        private System.Windows.Forms.ToolStripMenuItem categoryMenuFood;
        private System.Windows.Forms.ToolStripMenuItem categoryMenuNotListedBtn;
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
        private System.Windows.Forms.TextBox itemTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button clearBoxBtn;
    }
}
