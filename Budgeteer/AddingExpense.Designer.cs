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
            this.categoryTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.statusLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // amountTxt
            // 
            this.amountTxt.Location = new System.Drawing.Point(202, 134);
            this.amountTxt.Name = "amountTxt";
            this.amountTxt.Size = new System.Drawing.Size(100, 20);
            this.amountTxt.TabIndex = 0;
            // 
            // articleTxt
            // 
            this.articleTxt.Location = new System.Drawing.Point(202, 191);
            this.articleTxt.Name = "articleTxt";
            this.articleTxt.Size = new System.Drawing.Size(100, 20);
            this.articleTxt.TabIndex = 1;
            // 
            // categoryTxt
            // 
            this.categoryTxt.Location = new System.Drawing.Point(202, 241);
            this.categoryTxt.Name = "categoryTxt";
            this.categoryTxt.Size = new System.Drawing.Size(100, 20);
            this.categoryTxt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Article";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Category";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(368, 191);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 6;
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.FlatAppearance.BorderSize = 0;
            this.SubmitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitBtn.Location = new System.Drawing.Point(202, 410);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(366, 23);
            this.SubmitBtn.TabIndex = 7;
            this.SubmitBtn.Text = "Submit Expense";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // statusLbl
            // 
            this.statusLbl.AutoSize = true;
            this.statusLbl.Location = new System.Drawing.Point(211, 341);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(0, 13);
            this.statusLbl.TabIndex = 8;
            // 
            // AddingExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusLbl);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.categoryTxt);
            this.Controls.Add(this.articleTxt);
            this.Controls.Add(this.amountTxt);
            this.Name = "AddingExpense";
            this.Size = new System.Drawing.Size(732, 601);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox amountTxt;
        private System.Windows.Forms.TextBox articleTxt;
        private System.Windows.Forms.TextBox categoryTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.Label statusLbl;
    }
}
