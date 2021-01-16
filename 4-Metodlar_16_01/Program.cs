using System;

namespace _4_Metodlar_16_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dont repeat yourself -DRY - Clean code - Best Practice
            string urunAdi1 = "Elma";
            double fiyat1 = 15;
            string aciklama2 = "Amasya ELması";

            string[] Meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuz";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            //type safe --tip güvenli 
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("---------------------");
            }

            Console.WriteLine("-------------------------Metodlar------------------------");
            //instance Örnek
            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1); //ekle metodunu çağırma
            sepetManager.Ekle(urun2);


            sepetManager.Ekle2("Armut", "Yeşil armut", 12, 10);
            sepetManager.Ekle2("Elma", "yeşil elma", 12, 9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12, 8);


        }
    }
}
