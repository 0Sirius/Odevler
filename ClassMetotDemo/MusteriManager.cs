using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle( Musteri musteri)
        {
            Console.WriteLine("Müşteri Başarıyla Eklendi : " + musteri.Ad);
            Console.WriteLine("Müşteri Başarıyla Eklendi : " + musteri.Soyadi);

        }
        public void Ekle2(Musteri musteri)
        {
            Console.WriteLine("Müşreriler Listelendi " );
        }
    }
}
