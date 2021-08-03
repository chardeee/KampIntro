using System;
using System.Collections.Generic;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Products product1 = new Products();

            product1.Code = 001;
            product1.Name = "SteelSeries Rival 3";
            product1.Price = 100;
            product1.Explanation = "SteelSeries Newest Mouse ";
            product1.DiscountedPrice = 85;
            product1.ProfitRate = 15;


            Products product2 = new Products();

            product2.Code = 002;
            product2.Name = "Iphone 7";
            product2.Price = 400;
            product2.Explanation = "The Best Phone In The World";
            product2.DiscountedPrice = 350;
            product2.ProfitRate = 50;


            Products product3 = new Products();

            product3.Code = 003;
            product3.Name = "Monster Tulpar T7";
            product3.Price = 800;
            product3.Explanation = "A Computer With A New Generation Processor And A Graphic Card";
            product3.DiscountedPrice = 700;
            product3.ProfitRate = 100;


            Products product4 = new Products();

            product4.Code = 004;
            product4.Name = "HyperX Cloud 2";
            product4.Price = 250;
            product4.Explanation = "For Those Looking For A Nice Sound Experience And Comfort";
            product4.DiscountedPrice = 225;
            product4.ProfitRate = 25;


            Products product5 = new Products();

            product5.Code = 005;
            product5.Name = "Razer Blackwidow";
            product5.Price = 310;
            product5.Explanation = "Colorful , Fast, Loud";
            product5.DiscountedPrice = 300;
            product5.ProfitRate = 10;

            Products[] products = new Products[] { product1, product2, product3, product4, product5 };

            foreach (Products product in products)
            {
                Console.WriteLine(product.Code);
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Explanation);
                Console.WriteLine(product.DiscountedPrice);
                Console.WriteLine(product.ProfitRate);
                Console.WriteLine("---------Next Page---------");
            }
        }
    }
}
