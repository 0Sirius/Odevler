using System;

namespace OdevlerDenemekIcın3
{
    class Program
    {
        static void Main(string[] args)
        {
            Menü menü1 = new Menü();
            menü1.AnaYemek = "Ana Yemek";
            menü1.p= "Pilav";
           

            Menü menü2 = new Menü();
            menü2.AnaYemek = "Ana Yemek";
            menü2.p = "Patlıcan";
            


            Menü[]  menüler = new Menü[] {menü1,menü2};

            foreach (var Menü in menüler)

            {
                Console.WriteLine(Menü.AnaYemek + " : " + Menü.p);
            }
            Menü tatlı = new Menü();
            tatlı.Tatlı = "baklava";
            tatlı.Tatlı_= "Tatlı";

            Menü[] tatlılar = new Menü[] { tatlı };
            foreach (var Menü in tatlılar)
            {
                Console.WriteLine(Menü.Tatlı_ + " : " + Menü.Tatlı);
            }
        }
    }
}
class Menü
{
    public string p { get; set; }
    public string AnaYemek { get; set; }
    public string Tatlı { get; set; }
    public string Tatlı_ { get; set; }
}
