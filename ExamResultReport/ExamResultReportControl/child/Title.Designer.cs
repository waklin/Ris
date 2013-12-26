namespace ExamResultReportControl
{
    partial class Title
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.examinDateLable = new System.Windows.Forms.Label();
            this.title1Lable = new System.Windows.Forms.Label();
            this.title2Lable = new System.Windows.Forms.Label();
            this.separatePanel = new System.Windows.Forms.Panel();
            this.logoPicture = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.examinDateLable, 2, 4);
            this.tableLayoutPanel.Controls.Add(this.title1Lable, 2, 0);
            this.tableLayoutPanel.Controls.Add(this.title2Lable, 2, 2);
            this.tableLayoutPanel.Controls.Add(this.separatePanel, 0, 5);
            this.tableLayoutPanel.Controls.Add(this.logoPicture, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 6;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(1037, 262);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // examinDateLable
            // 
            this.examinDateLable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.examinDateLable.Location = new System.Drawing.Point(227, 216);
            this.examinDateLable.Name = "examinDateLable";
            this.examinDateLable.Size = new System.Drawing.Size(807, 32);
            this.examinDateLable.TabIndex = 1;
            this.examinDateLable.Text = "检查日期";
            this.examinDateLable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // title1Lable
            // 
            this.title1Lable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.title1Lable.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.title1Lable.ForeColor = System.Drawing.Color.Red;
            this.title1Lable.Location = new System.Drawing.Point(226, 0);
            this.title1Lable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title1Lable.Name = "title1Lable";
            this.title1Lable.Size = new System.Drawing.Size(809, 80);
            this.title1Lable.TabIndex = 2;
            this.title1Lable.Text = "title1";
            this.title1Lable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.title1Lable.Paint += new System.Windows.Forms.PaintEventHandler(this.title1Lable_Paint);
            // 
            // title2Lable
            // 
            this.title2Lable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.title2Lable.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.title2Lable.ForeColor = System.Drawing.Color.Blue;
            this.title2Lable.Location = new System.Drawing.Point(226, 132);
            this.title2Lable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title2Lable.Name = "title2Lable";
            this.title2Lable.Size = new System.Drawing.Size(809, 64);
            this.title2Lable.TabIndex = 3;
            this.title2Lable.Text = "title2";
            this.title2Lable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.title2Lable.Paint += new System.Windows.Forms.PaintEventHandler(this.title2Lable_Paint);
            // 
            // separatePanel
            // 
            this.separatePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.separatePanel.BackColor = System.Drawing.Color.Gray;
            this.tableLayoutPanel.SetColumnSpan(this.separatePanel, 3);
            this.separatePanel.Location = new System.Drawing.Point(2, 250);
            this.separatePanel.Margin = new System.Windows.Forms.Padding(2);
            this.separatePanel.Name = "separatePanel";
            this.separatePanel.Size = new System.Drawing.Size(1033, 10);
            this.separatePanel.TabIndex = 4;
            // 
            // logoPicture
            // 
            this.logoPicture.Location = new System.Drawing.Point(2, 2);
            this.logoPicture.Margin = new System.Windows.Forms.Padding(2);
            this.logoPicture.Name = "logoPicture";
            this.tableLayoutPanel.SetRowSpan(this.logoPicture, 5);
            this.logoPicture.Size = new System.Drawing.Size(200, 241);
            this.logoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.logoPicture.TabIndex = 1;
            this.logoPicture.TabStop = false;
            this.logoPicture.Paint += new System.Windows.Forms.PaintEventHandler(this.logoPicture_Paint);
            // 
            // Title
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.tableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Title";
            this.Size = new System.Drawing.Size(1037, 262);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.PictureBox logoPicture;
        private System.Windows.Forms.Label title1Lable;
        private System.Windows.Forms.Label title2Lable;
        private System.Windows.Forms.Panel separatePanel;
        private System.Windows.Forms.Label examinDateLable;


    }
}
