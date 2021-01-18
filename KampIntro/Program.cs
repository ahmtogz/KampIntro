using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sitemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugün = 7.45;

            if (dolarDun > dolarBugün)
            {
                Console.WriteLine("Azalis butonu göster");
            }
            else if (dolarDun < dolarBugün)
            {
                Console.WriteLine("Artis butonu göster");
            }
            else
            {
                Console.WriteLine("Degismedi butonu");
            }
            if (sitemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanici ayarlari butonu");
            }
            else
            {
                Console.WriteLine("Giris yap butonu");
            }


        }
    }
}
