using System;

namespace E_TıcaretSıtesıOrnek
{
    class Program
    {
        static void Main(string[] args)
        {

            urun urun1 = new urun();
            urun1.urunler= "araba";
            urun1.urunsayısı = 15;
            

            urun urun2 = new urun();
           
            urun2.urunler = "defter";
            urun2.urunsayısı = 29;
    
            urun[] urunler = new urun[] {urun1,urun2 };
            
            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i].urunler + ":" + urunler[i].urunsayısı);

            }
            foreach (var a in urunler)
            {
                Console.WriteLine(a.urunler + ":" + a.urunsayısı);

            }
            int j = 0;
            while (j<urunler.Length)
            {
                Console.WriteLine(urunler[j].urunler + ":" + urunler[j].urunsayısı);
            }





        }
    }
    class urun
    {
        public int urunsayısı { get; set; }
        public string urunler { get; set; }
    }

}
