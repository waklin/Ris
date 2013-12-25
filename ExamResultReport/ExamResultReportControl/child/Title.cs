using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace ExamResultReportControl
{

    public partial class Title : UserControl
    {
        readonly string _defaultTitle1 = "title1";
        readonly string _defaultTitle2 = "title2";

        public Title()
        {
            InitializeComponent();
            //title1Lable.Text = _defaultTitle1;
            //title2Lable.Text = _defaultTitle2;
        }

        public Label Title1 { get { return title1Lable; } }
        public Label Title2 { get { return title2Lable; } }

        public Image Logo
        {
            get;
            set;
        }

        #region ...设计时的辅助信息...
        void _drawBoundary(Graphics g, Rectangle clientRect)
        {
            using (Pen pen = new Pen(Color.Black, 0))
            {
                pen.DashStyle = DashStyle.Dot;
                g.DrawRectangle(pen, clientRect);
            }
        }

        private void logoPicture_Paint(object sender, PaintEventArgs e)
        {
            if (logoPicture.Image == null)
            {
                string notice = "place logo in here.";
                Font font = new Font("Arial", 9.0f, FontStyle.Regular);
                StringFormat sf = new StringFormat();
                sf.LineAlignment = sf.Alignment = StringAlignment.Center;

                Rectangle clientRect = logoPicture.ClientRectangle;
                e.Graphics.DrawString(notice,
                    font,
                    Brushes.Red,
                    clientRect,
                    sf);
                clientRect.Inflate(-1, -1);
                this._drawBoundary(e.Graphics, clientRect);
            }
        }

        private void title2Lable_Paint(object sender, PaintEventArgs e)
        {
            if (title2Lable.Text != _defaultTitle2)
                return;

            Rectangle clientRect = title2Lable.ClientRectangle;
            clientRect.Inflate(-1, -1);
            this._drawBoundary(e.Graphics, clientRect);
        }

        private void title1Lable_Paint(object sender, PaintEventArgs e)
        {
            if (title1Lable.Text != _defaultTitle1)
                return;

            Rectangle clientRect = title1Lable.ClientRectangle;
            clientRect.Inflate(-1, -1);
            this._drawBoundary(e.Graphics, clientRect);
        }

        #endregion

    }
}
