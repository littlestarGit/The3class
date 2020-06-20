using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The3class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int deltx = 10;
        int delty = 8;
        int deltx1 = 10;
        int delty1 = 4;
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label1.Left += deltx;
            this.label1.Top += delty;
            if (this.label1.Top < 0 || this.label1.Top + this.label1.Height > this.Height)
                delty = -delty;
            if (this.label1.Left < 0 || this.label1.Left + this.label1.Width > this.Width)
                deltx = -deltx;

            this.label2.Left += deltx1;
            this.label2.Top += delty1;
            if (this.label2.Top < 0 || this.label2.Top + this.label2.Height > this.Height)
                delty1 = -delty1;
            if (this.label2.Left < 0 || this.label2.Left + this.label2.Width > this.Width)
                deltx1 = -deltx1;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
