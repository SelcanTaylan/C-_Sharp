using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam_day_tracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string KalanGunHesapla(DateTime tarih, Label label)
        {
            string mesaj = "";
            DateTime bugun=DateTime.Now;
            TimeSpan fark=tarih-bugun;
            if(fark.Days <0)
            {
                mesaj = "Sınav Tarihi Geçti.";
                label.ForeColor = Color.Red;
            }
            else if (fark.Days==0)
            {
                mesaj = "Sınav bugün yapılacak.";
                label.ForeColor = Color.Black;
            }
            else
            {
                mesaj = "Sınava " + fark.Days + " gün kaldı.";
                label.ForeColor = Color.Black;
            }
            return mesaj;
        }
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            lblEdebiyat.Text = KalanGunHesapla(dtpEdb.Value, lblEdebiyat);
            lblMatematik.Text=KalanGunHesapla(dtpMat.Value, lblMatematik);
            lblNTP.Text=KalanGunHesapla(dtpNTP.Value, lblNTP);
        }
    }
}
