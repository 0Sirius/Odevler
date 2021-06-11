using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Patates";
            urun1.Aciklamasi = "Niğde Patatesi";
            urun1.Fiyati = 221;
            urun1.StokAdedi = 32;

            Urun[] urunler = new Urun[] { urun1 };
            foreach (var a in urunler)
            {
                Console.WriteLine(a.Adi);
                Console.WriteLine(a.Fiyati);
                Console.WriteLine(a.StokAdedi);
                Console.WriteLine(a.Aciklamasi);

            }

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
        }
    }
}
