using System;

namespace OdevlerıDenemekIcın
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool SistemeGirisYamısMi = false;
            double dolarDun = 7.55;
            double dolarBugun = 7.65;


            if (dolarBugun < dolarDun)
            {
                Console.WriteLine("Yükseliş Oku");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Azalış Oku");
               
            }
            else
            {
                Console.WriteLine("değişmedi butonu");
            
            }
            if (SistemeGirisYamısMi == true) 

            {
                Console.WriteLine("Kullanıcı Ayarları Butonu ");

            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu ");

            }
            Console.WriteLine(kategoriEtiketi);

            public string Eğitmen   
        }   
    }
}
