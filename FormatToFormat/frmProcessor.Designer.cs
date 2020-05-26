namespace FormatToFormat
{
    partial class frmProcessor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProcessor));
            this.txtPdfToWord = new System.Windows.Forms.TextBox();
            this.txtWordToPdf = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBrowsePdf = new System.Windows.Forms.Button();
            this.btnPdf = new System.Windows.Forms.Button();
            this.btnWord = new System.Windows.Forms.Button();
            this.btnBrowseWord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPdfToWord
            // 
            this.txtPdfToWord.Location = new System.Drawing.Point(125, 13);
            this.txtPdfToWord.Name = "txtPdfToWord";
            this.txtPdfToWord.Size = new System.Drawing.Size(263, 20);
            this.txtPdfToWord.TabIndex = 0;
            // 
            // txtWordToPdf
            // 
            this.txtWordToPdf.Location = new System.Drawing.Point(125, 57);
            this.txtWordToPdf.Name = "txtWordToPdf";
            this.txtWordToPdf.Size = new System.Drawing.Size(263, 20);
            this.txtWordToPdf.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "PDF To Word";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Excel To PDF";
            // 
            // btnBrowsePdf
            // 
            this.btnBrowsePdf.Location = new System.Drawing.Point(394, 12);
            this.btnBrowsePdf.Name = "btnBrowsePdf";
            this.btnBrowsePdf.Size = new System.Drawing.Size(27, 23);
            this.btnBrowsePdf.TabIndex = 4;
            this.btnBrowsePdf.Text = "...";
            this.btnBrowsePdf.UseVisualStyleBackColor = true;
            this.btnBrowsePdf.Click += new System.EventHandler(this.btnBrowsePdf_Click);
            // 
            // btnPdf
            // 
            this.btnPdf.Location = new System.Drawing.Point(427, 13);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(75, 23);
            this.btnPdf.TabIndex = 5;
            this.btnPdf.Text = "Process";
            this.btnPdf.UseVisualStyleBackColor = true;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // btnWord
            // 
            this.btnWord.Location = new System.Drawing.Point(427, 55);
            this.btnWord.Name = "btnWord";
            this.btnWord.Size = new System.Drawing.Size(75, 23);
            this.btnWord.TabIndex = 7;
            this.btnWord.Text = "Process";
            this.btnWord.UseVisualStyleBackColor = true;
            this.btnWord.Click += new System.EventHandler(this.btnWord_Click);
            // 
            // btnBrowseWord
            // 
            this.btnBrowseWord.Location = new System.Drawing.Point(394, 55);
            this.btnBrowseWord.Name = "btnBrowseWord";
            this.btnBrowseWord.Size = new System.Drawing.Size(27, 23);
            this.btnBrowseWord.TabIndex = 6;
            this.btnBrowseWord.Text = "...";
            this.btnBrowseWord.UseVisualStyleBackColor = true;
            this.btnBrowseWord.Click += new System.EventHandler(this.btnBrowseWord_Click);
            // 
            // frmProcessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 115);
            this.Controls.Add(this.btnWord);
            this.Controls.Add(this.btnBrowseWord);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.btnBrowsePdf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtWordToPdf);
            this.Controls.Add(this.txtPdfToWord);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProcessor";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change File Format";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPdfToWord;
        private System.Windows.Forms.TextBox txtWordToPdf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBrowsePdf;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.Button btnWord;
        private System.Windows.Forms.Button btnBrowseWord;
    }
}

