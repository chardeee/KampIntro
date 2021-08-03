using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer musteri1 = new Customer();
            musteri1.Id = 1111;
            musteri1.Ad = " Ali ";
            musteri1.Soyad = " Serin ";
            musteri1.Yaş = 18;

            Customer musteri2 = new Customer();
            musteri2.Id = 1112;
            musteri2.Ad = " İsmail ";
            musteri2.Soyad = " Serin ";
            musteri2.Yaş = 20;

            Customer musteri3 = new Customer();
            musteri3.Id = 1113;
            musteri3.Ad = " Mehmet ";
            musteri3.Soyad = " Gövez ";
            musteri3.Yaş = 25;

            Customer musteri4 = new Customer();
            musteri4.Id = 1114;
            musteri4.Ad = " Hüseyin ";
            musteri4.Soyad = " Vanlı ";
            musteri4.Yaş = 29;


            MusteriManager musteriManager = new MusteriManager();

            Console.WriteLine(    );
            Console.WriteLine("Ekleme İşlemi");
            musteriManager.Add(musteri3);
            musteriManager.Add(musteri2);

            Console.WriteLine(    );
            Console.WriteLine("Listeleme İşlemi");
            musteriManager.List(musteri2);
            musteriManager.List(musteri4);


            Console.WriteLine();
            Console.WriteLine("Silme İşlemi");
            musteriManager.Delete(musteri1);
            musteriManager.Delete(musteri2);
            musteriManager.Delete(musteri3);
            musteriManager.Delete(musteri4);


        }
    }
}
