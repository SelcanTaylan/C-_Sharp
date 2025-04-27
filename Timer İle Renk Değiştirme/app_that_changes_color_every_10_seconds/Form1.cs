using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_that_changes_color_every_10_seconds
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = 1000;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime simdi= DateTime.Now;
            Random rnd = new Random();
            label1.Text = simdi.ToString("ss");
            if (simdi.Second%10==0)
            {
                int r = rnd.Next(255);
                int g = rnd.Next(255);
                int b = rnd.Next(255);
                this.BackColor= Color.FromArgb(r, g, b);
            }
        }
    }
}
