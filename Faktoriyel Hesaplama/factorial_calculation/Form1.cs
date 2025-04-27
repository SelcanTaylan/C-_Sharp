using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace factorial_calculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int Faktoriyel(int sayi1)
        {
            int carpim = 1;
            for(int i=1; i<=sayi1;i++)
            {
                carpim *= i;
            }
            return carpim;
        }
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int n=Convert.ToInt32(txt_n.Text);
            int r=Convert.ToInt32(txt_r.Text);
            int sonuc=Faktoriyel(n)/(Faktoriyel(r)*Faktoriyel(n-r));
            lblSonuc.Text = "Sonuç: " + sonuc;
        }
    }
}
