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
            label1.Text = "İş bu uygulama test aşamasında olup veri kayıplarından uygulama yapımcısı sorumlu değildir. \n Bazı telefon marka üreticileri tarafından Rehber kişileri,SMS Mesajların yedeklenmesi güvenlik gerekçesiyle engellenir.\n WhatsApp uygulama ve yedekleri güvenlik gerekçesiyle Facebook Inc. tarafından engellenmektedir.";
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            Loading YedekAlY = new Loading();
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = @"/C yedekAl.bat";
            process.StartInfo = startInfo;
            process.Start();

            if (process.Start() == true)
            {
                YedekAlY.Show();
            }
            process.WaitForExit();
            YedekAlY.Close();
        }


       

        private void button2_Click(object sender, EventArgs e)
        {


            Loading YedekYukleY = new Loading();
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = @"/C yedekYukle.bat";
            process.StartInfo = startInfo;
            process.Start();

            if (process.Start() == true)
            {
                YedekYukleY.Show();
            }
            if (process.Start() == true)
            {
                YedekYukleY.Show();
            }
            process.WaitForExit();
            YedekYukleY.Close();



        }



        private void button4_Click(object sender, EventArgs e)
        {
         
            Yardım yrd = new Yardım();
            yrd.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {


            Loading YedekAlUY = new Loading();
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = @"/C yedekAlUser.bat";
            process.StartInfo = startInfo;
            process.Start();

            if (process.Start() == true)
            {
                YedekAlUY.Show();
            }

            if (process.Start() == true)
            {
                YedekAlUY.Show();
            }
            process.WaitForExit();
            YedekAlUY.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Loading YedekAlE = new Loading();

            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = @"/C yedekAlEski.bat";
            process.StartInfo = startInfo;
            process.Start();

            if (process.Start() == true)
            {
                YedekAlE.Show();
            }

            if (process.Start() == true)
            {
                YedekAlE.Show();
            }
            process.WaitForExit();
            YedekAlE.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            Loading YedekAlUE = new Loading();
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = @"/C yedekAlUserEski.bat";
            process.StartInfo = startInfo;
            process.Start();

            if (process.Start() == true)
            {
                YedekAlUE.Show();
            }

            if (process.Start() == true)
            {
                YedekAlUE.Show();
            }
            process.WaitForExit();
            YedekAlUE.Close();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Loading YedekYukleE = new Loading();
            YedekYukleE.Show();
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = @"/C yedekYukleEski.bat";
            process.StartInfo = startInfo;
            process.Start();

            if (process.Start() == true)
            {
                YedekYukleE.Show();
            }

            if (process.Start() == true)
            {
                YedekYukleE.Show();
            }
            process.WaitForExit();
            YedekYukleE.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        private void Form1_Close(object sender, FormClosedEventArgs e)
        {
            string strCmdText;
            strCmdText = "/C adbKill.bat";
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);
        }
        private void Form1_Closed(object sender, FormClosedEventArgs e)
        {
            string strCmdText;
            strCmdText = "/C adbKill.bat";
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);
        }
        private void Form1_Closing(object sender, FormClosingEventArgs e)
        {
            string strCmdText;
            strCmdText = "/C adbKill.bat";
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);
        }
    }
}