using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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

        Hesapla secilenDers;
        List<Hesapla> ortHesapla = new List<Hesapla>();
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            string ad=txtAd.Text;
            int dersSaati=Convert.ToInt32(txtSaat.Text);
            double Not1 = Convert.ToDouble(txtNot1.Text);
            double Not2 = Convert.ToDouble(txtNot2.Text);
            double Performans1 = Convert.ToDouble(txtPerformans1.Text);
            double Performans2 = Convert.ToDouble(txtPerformans2.Text);

            Hesapla ort=new Hesapla(ad, dersSaati, Not1, Not2, Performans1, Performans2);
            ortHesapla.Add(ort);
            btnHesapla.Enabled = false;
            Listele();
        
        }


        void Listele()
        {
            dgvHesapla.DataSource = null;
            dgvHesapla.DataSource = ortHesapla.ToList();
          

        }
        void Temizle()
        {
            txtAd.Clear();
            txtSaat.Clear();
            txtNot1.Clear();
            txtNot2.Clear();
            txtPerformans1.Clear();
            txtPerformans2.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Hesapla ders1 = new Hesapla("Fizik",2,100,85,100,100);
            Hesapla ders2 = new Hesapla("Kimya", 2, 75, 98, 100, 100);
            Hesapla ders3 = new Hesapla("Matematik", 2, 74, 95, 95, 100);
            ortHesapla.Add(ders1);
            ortHesapla.Add(ders2);
            ortHesapla.Add(ders3);
            btnHesapla.Enabled = false;
            Listele();
        }

        private void dgvHesapla_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvHesapla.SelectedRows.Count > 0)
            {
                secilenDers=(Hesapla)dgvHesapla.SelectedRows[0].DataBoundItem;
            }
            txtAd.Text = secilenDers.DersAdi;
            txtSaat.Text=secilenDers.DersSaati.ToString();
            txtNot1.Text=secilenDers.Not1.ToString();
            txtNot2.Text = secilenDers.Not2.ToString();
            txtPerformans1.Text=secilenDers.Performans1.ToString();
            txtPerformans2.Text = secilenDers.Performans2.ToString();

        }

      

        private void btnYeni_Click_1(object sender, EventArgs e)
        {
            Temizle();
            btnHesapla.Enabled = true;
        }

        private void btnSonuc_Click(object sender, EventArgs e)
        {
            lblDurum.Text = SonucYazdir();
        }
        private string SonucYazdir()
        {
            int kalinanDersSayisi = 0;
            int toplamDersSaati = 0;
            double agirlikliOrtalamaToplami = 0;
            double agirlikliOrtalama = 0;
            string belge = "";

            foreach (Hesapla d in ortHesapla)
            {
                toplamDersSaati += d.DersSaati;
                agirlikliOrtalamaToplami += d.AgirlikliOrtalama;

                agirlikliOrtalama = Math.Round(agirlikliOrtalamaToplami / toplamDersSaati, 2);

                if (d.Durum == "KALDI")
                {
                    kalinanDersSayisi++;
                }
            }

            if (kalinanDersSayisi == 0)
            {
                if (agirlikliOrtalama >= 50 && agirlikliOrtalama < 70)
                {
                    belge = "Geçtiniz";
                }
                else if (agirlikliOrtalama >= 70 && agirlikliOrtalama < 85)
                {
                    belge = "Teşekkür belgesi aldınız.";
                }
                else if (agirlikliOrtalama >= 85 && agirlikliOrtalama <= 100)
                {
                    belge = "Takdir belgesi aldınız.";
                }
                else
                {
                    belge = "Hata!";
                }
            }
            else if (kalinanDersSayisi > 3)
            {
                belge = "Sınıfta kaldınız :(";
            }
            else
            {
                belge = "Sorumlu geçtiniz.";
            }


            string sonuc = $"Ağırlıklı ortalamanız: {agirlikliOrtalama}\nKaldığınız ders sayısı: {kalinanDersSayisi}" +
                $"\n{belge}";
            return sonuc;


        }
    }
}
