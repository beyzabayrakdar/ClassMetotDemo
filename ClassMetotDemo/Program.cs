using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriAdi = "Ayse";
            musteri1.MusteriSoyadi = "Kahraman";

            Musteri musteri2 = new Musteri();
            musteri2.MusteriAdi = "Ahmet";
            musteri2.MusteriSoyadi = "Korkmaz";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);

            Console.WriteLine("----------------");

            musteriManager.MusteriSil(musteri2);

            Console.WriteLine("----------------");

            musteriManager.MusteriListele(musteri1);
            musteriManager.MusteriListele(musteri2);
        }
    }
}
