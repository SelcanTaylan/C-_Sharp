using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace örnek1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DateTime tarih = DateTime.Now;
        private void button1_Click(object sender, EventArgs e)
        {
            double hesapla, urunfiyati = 0;
            string urunadi=txtAdi.Text;
            urunfiyati=Convert.ToDouble(txtFiyati.Text);
            double taksit=cmbTaksit.SelectedIndex+1;
            if (taksit >= 6)
            {
                urunfiyati = urunfiyati * 1.1;
            }
            else if(taksit > 9)
            {
                urunfiyati = urunfiyati * 1.2;
            }
            else
            {
                urunfiyati = urunfiyati;
            }

            hesapla = urunfiyati/taksit;
             
            for(int i = 1; i <= taksit; i++)
            {
               tarih=tarih.AddMonths(1);
                hesapla=Math.Round(hesapla,2);
                lstListele.Items.Add(i+".Taksit:"+tarih.ToShortDateString()+" Ödenecek Tutar: "+hesapla);

            }
            lblToplamTutar.Text = "Toplam Ödenecek Tutar: " + urunfiyati + "₺";

        }
    }
}
