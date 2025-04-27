using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prime_numbers_between_257_1233
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            lstAsalSayi.Items.Clear();
            for (int i = 257; i < 1233; i++)
            {
                if (asalSayi(i))
                {
                    lstAsalSayi.Items.Add(i);
                }
            }
        }

        private bool asalSayi(int sayi)
        {
            if (sayi <2) return false;

            for (int i = 2; i*i <=sayi; i++)
            {
                if (sayi%i==0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
