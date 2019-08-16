using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace glassMerchandise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {
            


        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if(textBox4.Text=="admin" && textBox3.Text=="123456")
            {
                MessageBox.Show("WELCOME");
            }
            else
            {
                MessageBox.Show("Username and Password credentials are INVALID");
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            PanelRight.Left = 34;
            PanelLeft.Left = 398;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            PanelRight.Left = 398;
            PanelLeft.Left = 34;
        }
    }
}
