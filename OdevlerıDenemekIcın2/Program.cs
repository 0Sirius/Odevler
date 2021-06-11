using System;

namespace OdevlerıDenemekIcın2
{
    class Program
    {
        static void Main(string[] args)
        {
            string menü1 = "Patlıcan" + " " + "Pilav" + " " + "Cacık";
            Console.WriteLine(menü1);


            string[] kurslar = new string[] { "Patlıcan", "Pilav ", "Cacık" };
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For Bitti");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);

            }
            Console.WriteLine("Sayfa Sonu");
        }    
    }
}
