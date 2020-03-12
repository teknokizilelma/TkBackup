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
          
            YedekAlYeni YedekAlY = new YedekAlYeni();
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

            foreach (Process p in Process.GetProcesses())
            {
                if (p.ProcessName == "adb")
                {

                    
                }
                else
                {
                    YedekAlY.Close();
                    break;
                }
                

            }
        }


       

        private void button2_Click(object sender, EventArgs e)
        {
           
            
            YedekYukleYeni YedekYukleY = new YedekYukleYeni();
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

            foreach (Process p in Process.GetProcesses())
            {
                if (p.ProcessName == "adb")
                {


                }
                else
                {
                    YedekYukleY.Close();
                    break;
                }


            }



        }



        private void button4_Click(object sender, EventArgs e)
        {
         
            Yardım yrd = new Yardım();
            yrd.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            
            YedekAlUserYeni YedekAlUY = new YedekAlUserYeni();
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

            foreach (Process p in Process.GetProcesses())
            {
                if (p.ProcessName == "adb")
                {


                }
                else
                {
                    YedekAlUY.Close();
                    break;
                }


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            YedekAlEski YedekAlE = new YedekAlEski();

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

            foreach (Process p in Process.GetProcesses())
            {
                if (p.ProcessName == "adb")
                {


                }
                else
                {
                    YedekAlE.Close();
                    break;
                }


            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
            YedekAlUserEski YedekAlUE = new YedekAlUserEski();
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

            foreach (Process p in Process.GetProcesses())
            {
                if (p.ProcessName == "adb")
                {


                }
                else
                {
                    YedekAlUE.Close();
                    break;
                }


            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            YedekYukleEski YedekYukleE = new YedekYukleEski();
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

            foreach (Process p in Process.GetProcesses())
            {
                if (p.ProcessName == "adb")
                {


                }
                else
                {
                    YedekYukleE.Close();
                    break;
                }


            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}