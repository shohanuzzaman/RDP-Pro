using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace rdp3
{
    public partial class home1 : UserControl
    {
        public home1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            p.StartInfo.FileName = "C:\\Program Files (x86)\\LogMeIn Hamachi\\hamachi-2-ui.exe";
            p.Start();
            
        }
    }
}
