using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pythagoras_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double a=Convert.ToDouble(txt_a.Text);
            double b=Convert.ToDouble(txt_b.Text);
            double aKuvvet=Math.Pow(a,2);
            double bKuvvet=Math.Pow(b,2);
            double islem=aKuvvet+bKuvvet;
            double c=Math.Sqrt(islem);
            lblSonuc.Text = string.Format("Sonuç: {0:F2", c);
        }
    }
}
