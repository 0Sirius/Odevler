using System;

namespace E_ticaretornek2
{
    
    class Program
    {
        static void Main(string[] args)
        {
            urun urun1 = new urun();
            urun1.urunler = "patates";
            urun1.urunmıktarı = 32;


            urun urun2 = new urun();
            urun2.urunler = "salatalık";
            urun2.urunmıktarı = 33;

            urun[] urunlerr = new urun[] { urun1, urun2 };
            foreach (var x in urunlerr)
            {
                Console.WriteLine(x.urunler +  ":" + x.urunmıktarı);
            }
            for (int i = 0; i < urunlerr.Length; i++)
            {
                Console.WriteLine(urun[i].urunler + ":" + urun[i].urunmıktarı);
            }
        }
        class urun
        {
            public int urunmıktarı { get; set; }
            public string urunler { get; set; }

        }
    }
}
