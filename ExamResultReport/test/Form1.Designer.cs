namespace test
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
            ExamResultReportControl.TitleInfo titleInfo2 = new ExamResultReportControl.TitleInfo();
            this.button1 = new System.Windows.Forms.Button();
            this.title1 = new ExamResultReportControl.Title();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // title1
            // 
            this.title1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.title1.AutoSize = true;
            this.title1.Location = new System.Drawing.Point(12, 11);
            this.title1.Margin = new System.Windows.Forms.Padding(2);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(1047, 262);
            this.title1.TabIndex = 2;
            titleInfo2.delegateObj = this.title1;
            titleInfo2.ExamineDate = "2012-12-26";
            titleInfo2.Logo = null;
            titleInfo2.LogoPath = null;
            titleInfo2.Title1 = "title1";
            titleInfo2.Title2 = "title2";
            this.title1.TitleInfo = titleInfo2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 545);
            this.Controls.Add(this.title1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private ExamResultReportControl.Title title1;





    }
}

