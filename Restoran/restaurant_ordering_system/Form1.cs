using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restaurant_ordering_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double[] fiyatListesi= { 80,100,200,20,50};
        string[] yemekListesi = { "Çorba","Tavuk Döner","Et Döner","Ayran","Sütlaç"};
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex==2)
            {
                lblFis.Text = $"Sipariş Fiş: {txtMusteri.Text}\n----------------------\n";
                double toplamTutar = 0;
                decimal[] adet = {numCorba.Value,numTavukDoner.Value,numEtDoner.Value,numAyran.Value,numSutlac.Value};
                
                for(int i=0;i<adet.Length;i++)
                {
                    int urunAdet=Convert.ToInt32(adet[i]);
                    double urunFiyat=fiyatListesi[i];
                    double tutar=urunAdet*urunFiyat;
                    toplamTutar += tutar;

                    if (urunAdet > 0)
                    {
                        lblFis.Text += yemekListesi[i] + " x " + urunAdet + " = " + tutar + " TL\n";
                            }
                }

                lblFis.Text += "-------------------\nToplam Tutar: " + toplamTutar + " TL";

            }
        }
    }
}
