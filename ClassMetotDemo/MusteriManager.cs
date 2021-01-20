using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Eklenen müşteri: " + musteri.MusteriAdi + " " + musteri.MusteriSoyadi);
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("Silinen müşteri: " + musteri.MusteriAdi + " " + musteri.MusteriSoyadi);
        }

        public void MusteriListele(Musteri musteri) 
        {
            Console.WriteLine(musteri.MusteriAdi + " " + musteri.MusteriSoyadi);
        }
    }
}
