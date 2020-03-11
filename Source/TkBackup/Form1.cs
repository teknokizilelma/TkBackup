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
            strCmdText = "/C adbKill.bat";
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);
            YedekAlYeni YedekAlY = new YedekAlYeni();
            YedekAlY.Show();

            Process[] pname = Process.GetProcessesByName("adb");
            for (; pname.Length > 0;)
            {
                pname = Process.GetProcessesByName("adb");
                for (; pname.Length == 0;)
                {
                    System.Diagnostics.Process.Start("CMD.exe", strCmdText);
                    YedekAlY.Close();
                    pname = Process.GetProcessesByName("adb");
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string strCmdText;
            strCmdText = "/C adbKill.bat";
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);
            YedekYukleYeni YedekYukleY = new YedekYukleYeni();
            YedekYukleY.Show();

            Process[] pname = Process.GetProcessesByName("adb");
            for (; pname.Length > 0;)
            {
                pname = Process.GetProcessesByName("adb");
                for (; pname.Length == 0;)
                {
                    System.Diagnostics.Process.Start("CMD.exe", strCmdText);
                    YedekYukleY.Close();
                    pname = Process.GetProcessesByName("adb");
                }
            }
        }



        private void button4_Click(object sender, EventArgs e)
        {
            string strCmdText;
            strCmdText = "/C adbKill.bat";
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);
            Yardım yrd = new Yardım();
            yrd.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string strCmdText;
            strCmdText = "/C adbKill.bat";
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);
            YedekAlUserYeni YedekAlUY = new YedekAlUserYeni();
            YedekAlUY.Show();

            Process[] pname = Process.GetProcessesByName("adb");
            for (; pname.Length > 0;)
            {
                pname = Process.GetProcessesByName("adb");
                for (; pname.Length == 0;)
                {
                    System.Diagnostics.Process.Start("CMD.exe", strCmdText);
                    YedekAlUY.Close();
                    pname = Process.GetProcessesByName("adb");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string strCmdText;
            strCmdText = "/C adbKill.bat";
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);
            YedekAlEski YedekAlE = new YedekAlEski();
            YedekAlE.Show();

            Process[] pname = Process.GetProcessesByName("adb");
            for (; pname.Length > 0;)
            {
                
                pname = Process.GetProcessesByName("adb");
                for (; pname.Length == 0;)
                {
                    System.Diagnostics.Process.Start("CMD.exe", strCmdText);
                    YedekAlE.Close();
                    pname = Process.GetProcessesByName("adb");
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string strCmdText;
            strCmdText = "/C adbKill.bat";
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);
            YedekAlUserEski YedekAlUE = new YedekAlUserEski();
            YedekAlUE.Show();

            Process[] pname = Process.GetProcessesByName("adb");
            for (; pname.Length > 0;)
            {
                pname = Process.GetProcessesByName("adb");
                for (; pname.Length == 0;)
                {
                    System.Diagnostics.Process.Start("CMD.exe", strCmdText);
                    YedekAlUE.Close();
                    pname = Process.GetProcessesByName("adb");
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string strCmdText;
            strCmdText = "/C adbKill.bat";
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);
            YedekYukleEski YedekYukleE = new YedekYukleEski();
            YedekYukleE.Show();

            Process[] pname = Process.GetProcessesByName("adb");
            for (; pname.Length > 0;)
            {
                pname = Process.GetProcessesByName("adb");
                for (; pname.Length == 0;)
                {
                    System.Diagnostics.Process.Start("CMD.exe", strCmdText);
                    YedekYukleE.Close();
                    pname = Process.GetProcessesByName("adb");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string strCmdText;
            strCmdText = "/C adbKill.bat";
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);
        }
    }
}