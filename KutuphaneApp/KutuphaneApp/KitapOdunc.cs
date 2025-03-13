using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneApp
{
    internal class KitapOdunc
    {
        string ogrenciAdi;
        string kitapAdi;
        DateTime alisTarihi;
        DateTime? teslimTarihi;
        int toplamSure;
        string durum;

        public string OgrenciAdi { get => ogrenciAdi; set => ogrenciAdi = value; }
        public string KitapAdi { get => kitapAdi; set => kitapAdi = value; }
        public DateTime AlisTarihi { get => alisTarihi; set => alisTarihi = value; }
        public DateTime? TeslimTarihi { get => teslimTarihi; set => teslimTarihi = value; }
        public int ToplamSure { get => SureHesapla(); set => toplamSure = value; }
        public string Durum { get => DurumHesapla(); set => durum = value; }

        private int SureHesapla()
        {
            if (TeslimTarihi == null)
            {
                return (DateTime.Today - AlisTarihi).Days;
            }
            else
            {
                return (TeslimTarihi.Value - AlisTarihi).Days;
            }
        }


        private string DurumHesapla()
        {
            if (TeslimTarihi == null)
            {
                return "Teslim Edilmedi.";
            }
            else if (ToplamSure > 15)
            {
                return "Gecikmeli Teslim Edildi.";
            }
            else
            {
                return "Teslim Edildi.";
            }
        }

        public KitapOdunc(string ogrenciAdi, string kitapAdi, DateTime alisTarihi, DateTime? teslimTarihi)
        {
            OgrenciAdi = ogrenciAdi;
            KitapAdi = kitapAdi;
            AlisTarihi = alisTarihi;
            TeslimTarihi = teslimTarihi;
        }
    }
}
