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

    public partial class Title : UserControl, TitleInfoChangedDelegate
    {
        readonly string _defaultTitle1 = "title1";
        readonly string _defaultTitle2 = "title2";
        readonly string _defaultExaminDate = "检查日期";

        public Title()
        {
            InitializeComponent();
            _titleInfo = new TitleInfo() { Title1 = _defaultTitle1, Title2 = _defaultTitle2, ExamineDate = "2012-12-26" };
            _titleInfo.delegateObj = this;
            updateTitleInfo(_titleInfo);
        }

        public Label Title1 { get { return title1Lable; } }
        public Label Title2 { get { return title2Lable; } }

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

        TitleInfo _titleInfo = null;

        public TitleInfo TitleInfo
        {
            get { return _titleInfo; }
            set
            {
                _titleInfo = value;
                _titleInfo.delegateObj = this;
                if (_titleInfo != null)
                    this.updateTitleInfo(_titleInfo);
            }
        }

        #region TitleInfoChangedDelegate Members

        public void updateTitleInfo(TitleInfo sender)
        {
            if (sender == null)
                return;

            title1Lable.Text = sender.Title1;
            title2Lable.Text = sender.Title2;
            examinDateLable.Text = string.Format("{0}: {1}", _defaultExaminDate, sender.ExamineDate);
            if (!string.IsNullOrEmpty(sender.LogoPath))
                logoPicture.ImageLocation = sender.LogoPath;
            else
                logoPicture.Image = sender.Logo;
        }

        #endregion
    }

    public interface TitleInfoChangedDelegate
    {
        void updateTitleInfo(TitleInfo sender);
    }

    public class TitleInfo
    {
        public TitleInfoChangedDelegate delegateObj { get; set; }
        string _title1;
        string _title2;
        string _examinDate;
        string _logoPath;
        Image _logo;

        void _noticeDelegateObj()
        {
            if (this.delegateObj != null)
                this.delegateObj.updateTitleInfo(this);
        }
        public string Title1
        {
            get { return _title1; }
            set
            {
                if (_title1 != value)
                {
                    _title1 = value;
                    this._noticeDelegateObj();
                }
            }
        }
        public string Title2
        {
            get { return _title2; }
            set
            {
                if (_title2 != value)
                {
                    _title2 = value;
                    this._noticeDelegateObj();
                }
            }
        }

        public string ExamineDate
        {
            get { return _examinDate; }
            set
            {
                if (_examinDate != value)
                {
                    _examinDate = value;
                    this._noticeDelegateObj();
                }
            }
        }
        public string LogoPath
        {
            get { return _logoPath; }
            set
            {
                if (_logoPath != value)
                {
                    _logoPath = value;
                    this._noticeDelegateObj();
                }
            }
        }

        public Image Logo
                {
            get { return _logo; }
            set
            {
                if (_logo != value)
                {
                    _logo = value;
                    this._noticeDelegateObj();
                }
            }
        }
    }
}
