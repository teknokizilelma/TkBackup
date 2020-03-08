using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spire.PdfViewer.Forms;
using WindowsInstaller;
using System.Windows.Forms;
using System.IO;

namespace TestAdb_05032020
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "İş bu uygulama test aşamasında olup veri kayıplarından uygulama yapımcısı sorumlu değildir.";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strCmdText;
            strCmdText = "/C yedekAl.bat";
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string strCmdText;
            strCmdText = "/C yedekYukle.bat";
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);
        }

     

        private void button4_Click(object sender, EventArgs e)
        {
            Yardım yrd = new Yardım();
            yrd.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
