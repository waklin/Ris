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
            this.logoPicture = new System.Windows.Forms.PictureBox();
            this.title1Lable = new System.Windows.Forms.Label();
            this.title2Lable = new System.Windows.Forms.Label();
            this.separatePanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.logoPicture, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.title1Lable, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.title2Lable, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.separatePanel, 0, 4);
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 5;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(945, 362);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // logoPicture
            // 
            this.logoPicture.Location = new System.Drawing.Point(3, 3);
            this.logoPicture.Name = "logoPicture";
            this.tableLayoutPanel.SetRowSpan(this.logoPicture, 3);
            this.logoPicture.Size = new System.Drawing.Size(197, 316);
            this.logoPicture.TabIndex = 1;
            this.logoPicture.TabStop = false;
            this.logoPicture.Paint += new System.Windows.Forms.PaintEventHandler(this.logoPicture_Paint);
            // 
            // title1Lable
            // 
            this.title1Lable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.title1Lable.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.title1Lable.ForeColor = System.Drawing.Color.Red;
            this.title1Lable.Location = new System.Drawing.Point(206, 0);
            this.title1Lable.Name = "title1Lable";
            this.title1Lable.Size = new System.Drawing.Size(736, 100);
            this.title1Lable.TabIndex = 2;
            this.title1Lable.Text = "title1";
            this.title1Lable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.title1Lable.Paint += new System.Windows.Forms.PaintEventHandler(this.title1Lable_Paint);
            // 
            // title2Lable
            // 
            this.title2Lable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.title2Lable.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.title2Lable.ForeColor = System.Drawing.Color.Blue;
            this.title2Lable.Location = new System.Drawing.Point(206, 242);
            this.title2Lable.Name = "title2Lable";
            this.title2Lable.Size = new System.Drawing.Size(736, 80);
            this.title2Lable.TabIndex = 3;
            this.title2Lable.Text = "title2";
            this.title2Lable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.title2Lable.Paint += new System.Windows.Forms.PaintEventHandler(this.title2Lable_Paint);
            // 
            // separatePanel
            // 
            this.separatePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.separatePanel.BackColor = System.Drawing.Color.Gray;
            this.tableLayoutPanel.SetColumnSpan(this.separatePanel, 2);
            this.separatePanel.Location = new System.Drawing.Point(3, 347);
            this.separatePanel.Name = "separatePanel";
            this.separatePanel.Size = new System.Drawing.Size(939, 10);
            this.separatePanel.TabIndex = 4;
            // 
            // Title
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "Title";
            this.Size = new System.Drawing.Size(948, 537);
            this.tableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.PictureBox logoPicture;
        private System.Windows.Forms.Label title1Lable;
        private System.Windows.Forms.Label title2Lable;
        private System.Windows.Forms.Panel separatePanel;


    }
}
