using System;

namespace _1_KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety = tip güvenliği
            //değer tutucu, alias
            string categoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }

            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }

            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }
            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }

            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }

            Console.WriteLine(categoriEtiketi);
        }
    }
}
