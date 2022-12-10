namespace WindowsFormsApp5_pd
{
    partial class Form1
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
            this.chbDigits = new System.Windows.Forms.CheckedListBox();
            this.txbDigits = new System.Windows.Forms.TextBox();
            this.lblSum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chbDigits
            // 
            this.chbDigits.CheckOnClick = true;
            this.chbDigits.FormattingEnabled = true;
            this.chbDigits.Items.AddRange(new object[] {
            "25",
            "27",
            "3",
            "12",
            "6",
            "16",
            "9",
            "30",
            "21",
            "19"});
            this.chbDigits.Location = new System.Drawing.Point(28, 23);
            this.chbDigits.Name = "chbDigits";
            this.chbDigits.Size = new System.Drawing.Size(90, 191);
            this.chbDigits.TabIndex = 0;
            this.chbDigits.SelectedIndexChanged += new System.EventHandler(this.chbDigits_SelectedIndexChanged);
            // 
            // txbDigits
            // 
            this.txbDigits.Location = new System.Drawing.Point(178, 23);
            this.txbDigits.Multiline = true;
            this.txbDigits.Name = "txbDigits";
            this.txbDigits.ReadOnly = true;
            this.txbDigits.Size = new System.Drawing.Size(102, 144);
            this.txbDigits.TabIndex = 1;
            this.txbDigits.Text = "Подбери числа";
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(175, 182);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(53, 16);
            this.lblSum.TabIndex = 2;
            this.lblSum.Text = "Сумма:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 321);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.txbDigits);
            this.Controls.Add(this.chbDigits);
            this.Name = "Form1";
            this.Text = "Собери полтос";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chbDigits;
        private System.Windows.Forms.TextBox txbDigits;
        private System.Windows.Forms.Label lblSum;
    }
}

