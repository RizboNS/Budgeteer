namespace Budgeteer
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titlePanel = new System.Windows.Forms.Panel();
            this.navBtn3 = new System.Windows.Forms.Button();
            this.addExpenseNavBtn = new System.Windows.Forms.Button();
            this.navBtn1 = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.addingExpense = new Budgeteer.AddingExpense();
            this.titlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titlePanel
            // 
            this.titlePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(205)))), ((int)(((byte)(48)))));
            this.titlePanel.Controls.Add(this.navBtn3);
            this.titlePanel.Controls.Add(this.addExpenseNavBtn);
            this.titlePanel.Controls.Add(this.navBtn1);
            this.titlePanel.Controls.Add(this.titleLabel);
            this.titlePanel.Location = new System.Drawing.Point(-8, -1);
            this.titlePanel.Margin = new System.Windows.Forms.Padding(4);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(1192, 81);
            this.titlePanel.TabIndex = 0;
            // 
            // navBtn3
            // 
            this.navBtn3.FlatAppearance.BorderSize = 0;
            this.navBtn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navBtn3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBtn3.Location = new System.Drawing.Point(972, 0);
            this.navBtn3.Margin = new System.Windows.Forms.Padding(4);
            this.navBtn3.Name = "navBtn3";
            this.navBtn3.Size = new System.Drawing.Size(220, 81);
            this.navBtn3.TabIndex = 3;
            this.navBtn3.Text = "button3";
            this.navBtn3.UseVisualStyleBackColor = true;
            // 
            // addExpenseNavBtn
            // 
            this.addExpenseNavBtn.FlatAppearance.BorderSize = 0;
            this.addExpenseNavBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addExpenseNavBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addExpenseNavBtn.Location = new System.Drawing.Point(752, 0);
            this.addExpenseNavBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addExpenseNavBtn.Name = "addExpenseNavBtn";
            this.addExpenseNavBtn.Size = new System.Drawing.Size(220, 81);
            this.addExpenseNavBtn.TabIndex = 2;
            this.addExpenseNavBtn.Text = "Add new Expense";
            this.addExpenseNavBtn.UseVisualStyleBackColor = true;
            this.addExpenseNavBtn.Click += new System.EventHandler(this.addExpenseNavBtn_Click);
            // 
            // navBtn1
            // 
            this.navBtn1.FlatAppearance.BorderSize = 0;
            this.navBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navBtn1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBtn1.Location = new System.Drawing.Point(532, 0);
            this.navBtn1.Margin = new System.Windows.Forms.Padding(4);
            this.navBtn1.Name = "navBtn1";
            this.navBtn1.Size = new System.Drawing.Size(220, 81);
            this.navBtn1.TabIndex = 1;
            this.navBtn1.Text = "button1";
            this.navBtn1.UseVisualStyleBackColor = true;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.titleLabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(45, 27);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(377, 33);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Welcome to the Budgeteer";
            // 
            // addingExpense
            // 
            this.addingExpense.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addingExpense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(94)))), ((int)(((byte)(26)))));
            this.addingExpense.Location = new System.Drawing.Point(-4, 79);
            this.addingExpense.Margin = new System.Windows.Forms.Padding(4);
            this.addingExpense.Name = "addingExpense";
            this.addingExpense.Size = new System.Drawing.Size(1188, 629);
            this.addingExpense.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(94)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1182, 705);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.addingExpense);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Button navBtn3;
        private System.Windows.Forms.Button addExpenseNavBtn;
        private System.Windows.Forms.Button navBtn1;
        private System.Windows.Forms.Label titleLabel;
        private AddingExpense addingExpense;
    }
}

