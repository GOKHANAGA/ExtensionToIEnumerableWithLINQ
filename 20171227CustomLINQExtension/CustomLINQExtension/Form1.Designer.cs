namespace CustomLINQExtension
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
            this.btnMedian = new System.Windows.Forms.Button();
            this.lstMedian = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnMedian
            // 
            this.btnMedian.Location = new System.Drawing.Point(297, 25);
            this.btnMedian.Name = "btnMedian";
            this.btnMedian.Size = new System.Drawing.Size(144, 60);
            this.btnMedian.TabIndex = 0;
            this.btnMedian.Text = "SortedLSTMedian";
            this.btnMedian.UseVisualStyleBackColor = true;
            this.btnMedian.Click += new System.EventHandler(this.btnMedian_Click);
            // 
            // lstMedian
            // 
            this.lstMedian.FormattingEnabled = true;
            this.lstMedian.Location = new System.Drawing.Point(12, 12);
            this.lstMedian.Name = "lstMedian";
            this.lstMedian.Size = new System.Drawing.Size(251, 277);
            this.lstMedian.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 511);
            this.Controls.Add(this.lstMedian);
            this.Controls.Add(this.btnMedian);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMedian;
        private System.Windows.Forms.ListBox lstMedian;
    }
}

