using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "x";
            musteri1.Soyadi = "y";

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "a";
            musteri2.Soyadi = "b";


            Musteri[] a = new Musteri[] { musteri1, musteri2 };

            foreach (var m in a)
            {
                Console.WriteLine(m.Ad);
                Console.WriteLine(m.Soyadi);
              
            }
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);

            Console.WriteLine("-------------------------------Müşteri Listesi-----------------------");

            Musteri[] musteriler = { musteri1, musteri2 };
            foreach (var m in musteriler)
            {
                Console.WriteLine(m.Ad);
                Console.WriteLine(m.Soyadi);

            }
        }
    }
}
