using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string adı = "Elma";
            double fiyatı = 15;
            string acıklama = "Amasya Elması";

            string[] meyveler = new string[] { };

            Product urun1 = new Product();
            urun1.Adi = "Elma";
            urun1.Fiyatı = 15;
            urun1.Acıklama = "Amasya Elması";
            urun1.KargoSuresi = "2 gün";

            Product urun2 = new Product();
            urun2.Adi = "Karpuz";
            urun2.Fiyatı = 80;
            urun2.Acıklama = "Diyarbakır Karpuzu";
            urun2.KargoSuresi = "4 gün";

            Product[] urunler = new Product[] {urun1,urun2  };

            //type-safe -- tip güveliği
            foreach (Product urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyatı);
                Console.WriteLine(urun.Acıklama);
                Console.WriteLine("-------------");
            }

            Console.WriteLine("------Metotlar------");

            //instance-örnek
            //encapsulation

            SepetManager sepetManager = new SepetManager();
            
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil armut", 12, 7);
            sepetManager.Ekle2("Elma", "Yeşil elma", 14, 8);
            sepetManager.Ekle2("Karpuz", "Dİyarbakır karpuzu", 19, 9);

        }

    }
}


//do not repeat yourself - DRY - Clean Code - Best Practice
