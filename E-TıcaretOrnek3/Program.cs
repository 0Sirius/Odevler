using System;

namespace E_TıcaretOrnek3
{
    class Program
    {
        static void Main(string[] args)
        {
            cıkolata urun1 = new cıkolata();
            urun1.adı = "Bitter";
            urun1.sayısı = 22;

            cıkolata urun2 = new cıkolata();
            urun2.adı = "Milka";
            urun2.sayısı = 24;

            cıkolata[] urunler = new cıkolata[] {urun1,urun2 };

            foreach (var  a in urunler)
            {
                Console.WriteLine(a.adı + " : " + a.sayısı);
            }
            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i].adı + ":" + urunler[i].sayısı);
            }


        }
        

    }
}
class cıkolata
{
    public int sayısı { get; set; }
    public string adı { get; set; }
    
}
