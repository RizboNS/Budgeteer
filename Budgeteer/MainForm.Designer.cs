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
            this.navBtn2 = new System.Windows.Forms.Button();
            this.navBtn1 = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.addingExpense1 = new Budgeteer.AddingExpense();
            this.titlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titlePanel
            // 
            this.titlePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titlePanel.Controls.Add(this.navBtn3);
            this.titlePanel.Controls.Add(this.navBtn2);
            this.titlePanel.Controls.Add(this.navBtn1);
            this.titlePanel.Controls.Add(this.titleLabel);
            this.titlePanel.Location = new System.Drawing.Point(-7, -1);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(1206, 66);
            this.titlePanel.TabIndex = 0;
            // 
            // navBtn3
            // 
            this.navBtn3.Location = new System.Drawing.Point(1002, 20);
            this.navBtn3.Name = "navBtn3";
            this.navBtn3.Size = new System.Drawing.Size(75, 23);
            this.navBtn3.TabIndex = 3;
            this.navBtn3.Text = "button3";
            this.navBtn3.UseVisualStyleBackColor = true;
            // 
            // navBtn2
            // 
            this.navBtn2.Location = new System.Drawing.Point(907, 20);
            this.navBtn2.Name = "navBtn2";
            this.navBtn2.Size = new System.Drawing.Size(75, 23);
            this.navBtn2.TabIndex = 2;
            this.navBtn2.Text = "button2";
            this.navBtn2.UseVisualStyleBackColor = true;
            // 
            // navBtn1
            // 
            this.navBtn1.Location = new System.Drawing.Point(809, 20);
            this.navBtn1.Name = "navBtn1";
            this.navBtn1.Size = new System.Drawing.Size(75, 23);
            this.navBtn1.TabIndex = 1;
            this.navBtn1.Text = "button1";
            this.navBtn1.UseVisualStyleBackColor = true;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(38, 22);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(222, 21);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Welcome to the Budgeteer";
            // 
            // addingExpense1
            // 
            this.addingExpense1.Location = new System.Drawing.Point(288, 71);
            this.addingExpense1.Name = "addingExpense1";
            this.addingExpense1.Size = new System.Drawing.Size(636, 611);
            this.addingExpense1.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 685);
            this.Controls.Add(this.addingExpense1);
            this.Controls.Add(this.titlePanel);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Button navBtn3;
        private System.Windows.Forms.Button navBtn2;
        private System.Windows.Forms.Button navBtn1;
        private System.Windows.Forms.Label titleLabel;
        private AddingExpense addingExpense1;
    }
}

