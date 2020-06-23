using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace rdp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            logo2.Visible = false;
            bLabel2.Hide();
            blabel3.Hide();
            blabel4.Hide();
            back.Hide();
            next.Hide();
            home11.Hide();
            connect1.Hide();
            fileshare1.Hide();
           
        }


        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
        
               animator1.Hide(logo);
                panel1.Visible = false;
                panel1.Width = 60;
                animator2.ShowSync(panel1);
            logo2.Visible = true;
            label1.Location = new Point(386, 141);
            label2.Location = new Point(344, 180);
            go.Location = new Point(390, 221);
            home11.Location = new Point(164, 46);
            back.Location = new Point(110, 459);


        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel1.Width = 245;
            home11.Location = new Point(268, 39);
            back.Location = new Point(266, 462);
            animator2.ShowSync(panel1);
            animator1.ShowSync(logo);
            logo2.Visible = false;
            label1.Location = new Point(525, 159);
            label2.Location = new Point(476, 196);
            go.Location = new Point(538, 238);
            home11.Location = new Point(268, 45);
            back.Location = new Point(266, 462);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void go_Click(object sender, EventArgs e)
        {

            animator1.Hide(logo);
            panel1.Visible = false;
            panel1.Width = 60;
            animator2.ShowSync(panel1);
            logo2.Visible = true;
            bLabel1.Hide();
            bLabel2.Show();
            back.Show();
            next.Show();
            home11.Show();
            home11.Location = new Point(164, 46);
            back.Location = new Point(110, 459);
        }

        private void back_Click(object sender, EventArgs e)
        {
            home11.Hide();
            bLabel2.Hide();
            bLabel1.Show();
            back.Hide();
            next.Hide();
            connect1.Hide();
            fileshare1.Hide();
        }

        private void next_Click(object sender, EventArgs e)
        {
            connect1.Show();
            bLabel1.Hide();
            bLabel2.Hide();
            blabel3.Show();
            home11.Hide();
            next.Hide();
            back.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fileshare1.Show();
            back.Show();
            blabel4.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fileshare1.Hide();
            connect1.Hide();
            back.Hide();
            blabel4.Hide();
            bLabel1.Show();
        }
    }
}
