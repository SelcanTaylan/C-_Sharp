using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monitor_viewer
{
    internal class Monitor
    {
        string marka;
        string model;
        double boyut;
        double fiyat;
        string cozunurluk;
        bool stokdurumu;

        public string Marka { get => marka; set => marka = value; }
        public string Model { get => model; set => model = value; }
        public double Boyut { get => boyut; set => boyut = value; }
        public double Fiyat { get => fiyat; set => fiyat = value; }
        public string Cozunurluk { get => cozunurluk; set => cozunurluk = value; }
        public bool Stokdurumu { get => stokdurumu; set => stokdurumu = value; }

        public Monitor(string marka, string model, double boyut, double fiyat, string cozunurluk, bool stokdurumu)
        {
            this.marka = marka;
            this.model = model;
            this.boyut = boyut;
            this.fiyat = fiyat;
            this.cozunurluk = cozunurluk;
            this.stokdurumu = stokdurumu;
        }
        public Monitor()
        {
        }
        public string BilgileriListele()
        {
            return $"Marka:{marka}\nModel:{model}\nBoyut:{boyut}";
        }
    }
}
