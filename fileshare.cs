using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RemoteFileSystemTester;
using RemoteFileSystemServer;

namespace rdp3
{
    public partial class fileshare : UserControl
    {
        public fileshare()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMain fm1 = new frmMain();
            fm1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmRfs fm2 = new frmRfs();
            fm2.Show();
        }
    }
}
