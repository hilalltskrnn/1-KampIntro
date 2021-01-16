using System;

namespace _3_ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Hilal";
            int yas = 23;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Hilal Taşkıran";
            kurs1.IzlenmeOrani = 80;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "PLC";
            kurs2.Egitmen = "İlhan Aydoğan";
            kurs2.IzlenmeOrani = 52;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Java";
            kurs3.Egitmen = "Ali Asaf";
            kurs3.IzlenmeOrani = 10;


            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.Egitmen = "mislina";
            kurs4.IzlenmeOrani = 100;
            //Console.WriteLine(kurs1.KursAdi+ " : "+ kurs1.Egitmen + " " + kurs1.IzlenmeOrani+ "%");

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3, kurs4 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + ": " + kurs.Egitmen);
            }

        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
