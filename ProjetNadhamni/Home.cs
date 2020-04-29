using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetNadhamni
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        Facebook fb = new Facebook();

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pic_fb_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            fb.Left += 10;
            if (fb.Left >= 830)
            {
                timer1.Stop();
                this.TopMost = false;
                fb.TopMost = true;
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            fb.Left -= 10;
            if (fb.Left <= 525)
            {
                timer2.Stop();
            }

        }

        private void Home_Load(object sender, EventArgs e)
        {
            fb.Show();
        }

        private void exitHome_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
