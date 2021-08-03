using System;

namespace Classintro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "İsmail";
            int yaş = 18;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdı = "C#";
            kurs1.Eğitmen = "İsmail Serin";
            kurs1.İzlenmeOranı = 56;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdı = "Java";
            kurs2.Eğitmen = "Seyit Ali";
            kurs2.İzlenmeOranı = 68;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdı = "Phyton";
            kurs3.Eğitmen = "Memet Gövez";
            kurs3.İzlenmeOranı = 80;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdı = "C++";
            kurs4.Eğitmen = "Mal Salih";
            kurs4.İzlenmeOranı = 31;

            




            //Console.WriteLine(kurs1.KursAdı + " : " + kurs1.Eğitmen);

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3, kurs4,};

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdı + " : " + kurs.Eğitmen + " %" + kurs.İzlenmeOranı);
            }

            //Console.WriteLine("Hello World!");
        }
    }
    //prop
    class Kurs
    {
        public string KursAdı { get; set; }
        public string Eğitmen { get; set; }
        public int İzlenmeOranı { get; set; }
    }
}
