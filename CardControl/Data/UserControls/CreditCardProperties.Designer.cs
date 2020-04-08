namespace CardControl.Data.UserControls
{
    partial class CreditCardProperties
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreditCardProperties));
            this.label1 = new System.Windows.Forms.Label();
            this.creditMonthComboBox = new System.Windows.Forms.ComboBox();
            this.creditYearComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.creditCardTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cvvTextBox = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Expiry";
            // 
            // creditMonthComboBox
            // 
            this.creditMonthComboBox.FormattingEnabled = true;
            this.creditMonthComboBox.Location = new System.Drawing.Point(118, 39);
            this.creditMonthComboBox.Name = "creditMonthComboBox";
            this.creditMonthComboBox.Size = new System.Drawing.Size(53, 21);
            this.creditMonthComboBox.TabIndex = 1;
            // 
            // creditYearComboBox
            // 
            this.creditYearComboBox.FormattingEnabled = true;
            this.creditYearComboBox.Location = new System.Drawing.Point(194, 39);
            this.creditYearComboBox.Name = "creditYearComboBox";
            this.creditYearComboBox.Size = new System.Drawing.Size(99, 21);
            this.creditYearComboBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "CCV";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(118, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 20);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Credit Card Number";
            // 
            // creditCardTextBox
            // 
            this.creditCardTextBox.Location = new System.Drawing.Point(151, 13);
            this.creditCardTextBox.Mask = "0000000000000000";
            this.creditCardTextBox.Name = "creditCardTextBox";
            this.creditCardTextBox.Size = new System.Drawing.Size(235, 20);
            this.creditCardTextBox.TabIndex = 8;
            this.creditCardTextBox.ValidatingType = typeof(int);
            this.creditCardTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.creditCardTextBox_KeyPress);
            // 
            // cvvTextBox
            // 
            this.cvvTextBox.Location = new System.Drawing.Point(347, 39);
            this.cvvTextBox.Mask = "000";
            this.cvvTextBox.Name = "cvvTextBox";
            this.cvvTextBox.Size = new System.Drawing.Size(39, 20);
            this.cvvTextBox.TabIndex = 9;
            this.cvvTextBox.ValidatingType = typeof(int);
            // 
            // CreditCardProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cvvTextBox);
            this.Controls.Add(this.creditCardTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.creditYearComboBox);
            this.Controls.Add(this.creditMonthComboBox);
            this.Controls.Add(this.label1);
            this.Name = "CreditCardProperties";
            this.Size = new System.Drawing.Size(413, 81);
            this.Load += new System.EventHandler(this.creditCardProperties_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox creditMonthComboBox;
        private System.Windows.Forms.ComboBox creditYearComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox creditCardTextBox;
        private System.Windows.Forms.MaskedTextBox cvvTextBox;
    }
}
