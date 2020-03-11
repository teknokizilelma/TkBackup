using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestAdb_05032020
{
    public partial class YedekYukleYeni : Form
    {
        public YedekYukleYeni()
        {
            InitializeComponent();
        }

        private void YedekYukleYeni_Load(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = @"/C yedekYukle.bat";
            process.StartInfo = startInfo;
            var islem = process.Start();
        }
    }
}
