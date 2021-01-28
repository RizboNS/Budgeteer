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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.titlePanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.viewBy = new Budgeteer.ViewBy();
            this.addingExpense = new Budgeteer.AddingExpense();
            this.aboutBtn = new System.Windows.Forms.Button();
            this.titlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titlePanel
            // 
            this.titlePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(205)))), ((int)(((byte)(48)))));
            this.titlePanel.Controls.Add(this.aboutBtn);
            this.titlePanel.Controls.Add(this.titleLabel);
            this.titlePanel.Location = new System.Drawing.Point(-8, -1);
            this.titlePanel.Margin = new System.Windows.Forms.Padding(4);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(1217, 81);
            this.titlePanel.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.titleLabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(47, 20);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(377, 33);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Welcome to the Budgeteer";
            // 
            // viewBy
            // 
            this.viewBy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewBy.AutoScroll = true;
            this.viewBy.AutoSize = true;
            this.viewBy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(94)))), ((int)(((byte)(26)))));
            this.viewBy.Location = new System.Drawing.Point(5, 87);
            this.viewBy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.viewBy.Name = "viewBy";
            this.viewBy.Size = new System.Drawing.Size(1189, 630);
            this.viewBy.TabIndex = 1;
            // 
            // addingExpense
            // 
            this.addingExpense.AutoScroll = true;
            this.addingExpense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(94)))), ((int)(((byte)(26)))));
            this.addingExpense.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addingExpense.Location = new System.Drawing.Point(12, 87);
            this.addingExpense.Name = "addingExpense";
            this.addingExpense.Size = new System.Drawing.Size(540, 547);
            this.addingExpense.TabIndex = 2;
            // 
            // aboutBtn
            // 
            this.aboutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.aboutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(205)))), ((int)(((byte)(48)))));
            this.aboutBtn.FlatAppearance.BorderSize = 0;
            this.aboutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutBtn.ForeColor = System.Drawing.Color.White;
            this.aboutBtn.Location = new System.Drawing.Point(1103, 3);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(111, 75);
            this.aboutBtn.TabIndex = 11;
            this.aboutBtn.Text = "About";
            this.aboutBtn.UseVisualStyleBackColor = false;
            this.aboutBtn.Click += new System.EventHandler(this.aboutBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(94)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1207, 719);
            this.Controls.Add(this.addingExpense);
            this.Controls.Add(this.viewBy);
            this.Controls.Add(this.titlePanel);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Budgeteer";
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label titleLabel;
        private ViewBy viewBy;
        private AddingExpense addingExpense;
        private System.Windows.Forms.Button aboutBtn;
    }
}

