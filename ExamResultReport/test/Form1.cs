using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ExamResultReportControl;
using System.IO;
using System.Reflection;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TitleInfo ti = new TitleInfo();
            ti.Title1 = "中华人民共和国";
            ti.Title2 = "北京市人民政府";
            ti.ExamineDate = "2013-12-26";
            string res_name = "test.hospital.jpg";
            using (Stream imgStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(res_name))
            {
                if (imgStream != null)
                    ti.Logo = Image.FromStream(imgStream);
            }
            title1.TitleInfo = ti;
        }

    }
}
