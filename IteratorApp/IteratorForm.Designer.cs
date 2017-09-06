namespace IteratorApp
{
    partial class IteratorForm
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
            this.lbTotalIterator = new System.Windows.Forms.ListBox();
            this.lbLetterIterator = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLetterIterator = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTotalIterator
            // 
            this.lbTotalIterator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbTotalIterator.FormattingEnabled = true;
            this.lbTotalIterator.Location = new System.Drawing.Point(13, 52);
            this.lbTotalIterator.Name = "lbTotalIterator";
            this.lbTotalIterator.Size = new System.Drawing.Size(165, 381);
            this.lbTotalIterator.TabIndex = 0;
            // 
            // lbLetterIterator
            // 
            this.lbLetterIterator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbLetterIterator.FormattingEnabled = true;
            this.lbLetterIterator.Location = new System.Drawing.Point(307, 52);
            this.lbLetterIterator.Name = "lbLetterIterator";
            this.lbLetterIterator.Size = new System.Drawing.Size(165, 381);
            this.lbLetterIterator.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "All Names";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Names that contain \"A\"";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnLetterIterator
            // 
            this.btnLetterIterator.Location = new System.Drawing.Point(184, 206);
            this.btnLetterIterator.Name = "btnLetterIterator";
            this.btnLetterIterator.Size = new System.Drawing.Size(117, 40);
            this.btnLetterIterator.TabIndex = 4;
            this.btnLetterIterator.Text = "Find names with \"A\"";
            this.btnLetterIterator.UseVisualStyleBackColor = true;
            // 
            // IteratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.btnLetterIterator);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbLetterIterator);
            this.Controls.Add(this.lbTotalIterator);
            this.Name = "IteratorForm";
            this.Text = "Iterator App";
            this.Load += new System.EventHandler(this.IteratorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbTotalIterator;
        private System.Windows.Forms.ListBox lbLetterIterator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLetterIterator;
    }
}

