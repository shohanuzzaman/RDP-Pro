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
using System.IO;

namespace rdp3
{
    public partial class connect : UserControl
    {
        public connect()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string address = AddressBox.Text;
            string username = bunifuTextbox2.Text;
            string password = bunifuTextbox1.Text;
            string filename = "ceshi".Trim() + ".rdp";

            AddressBox.Items.Add(address);

            var TemplateStr = rdp3.Properties.Resources.TemplateRDP;
            
            var pwstr = BitConverter.ToString(DataProtection.ProtectData(Encoding.Unicode.GetBytes(password), ""));
            pwstr = pwstr.Replace("-", "");
   
            var NewStr = TemplateStr.Replace("{#address}", address).Replace("{#username}", username).Replace("{#password}", pwstr);
       
            StreamWriter sw = new StreamWriter(filename);
            sw.Write(NewStr);
            sw.Close();
            ProcCmd("mstsc " + filename);
        }
        void ProcCmd(String cmd)
        {
            Process p = new Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.CreateNoWindow = true;
            p.Start();
            p.StandardInput.WriteLine(cmd);
            p.StandardInput.WriteLine("exit");
        }
    }
}
