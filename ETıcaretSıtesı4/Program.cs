using System;

namespace ETıcaretSıtesı4
{
    class Program
    {
        static void Main(string[] args)
        {
            Product Product1 = new Product();
            Product1.Name = "domates";
            Product1.Price = 221;

            Product Product2 = new Product();
            Product2.Name = "ananas";
            Product2.Price = 2343;

            Product[] Products = new Product[] { Product1, Product2 };

            foreach (var x in Products)
            {
                Console.WriteLine(x.Name + ":" + x.Price);
            }
            for (int i = 0; i < Products.Length; i++)
            {
                Console.WriteLine(Products[i].Name + ":" + Products[i].Price);
            }
            int j = 0;
            while (j < Products.Length)
            {
                Console.WriteLine(Products[j].Name + ":" + Products[j].Price);
            }
        }
        class Product
        {
            public int Price { get; set; }
            public string Name { get; set; }
        }
    }
}
