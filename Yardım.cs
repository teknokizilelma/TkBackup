using Spire.PdfViewer.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestAdb_05032020
{
    public partial class Yardım : Form
    {
        public Yardım()
        {
            InitializeComponent();
        }

        private void Yardım_Load(object sender, EventArgs e)
        {
            viewer.LoadFromFile("Yardım.pdf");
        }
    }
}
