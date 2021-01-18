using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)

        {
            string kurs1 = "Yazilim gelistirici Yetistirme Kampi";
            string kurs2 = "Programlamaya baslangic icin temel kurs";
            string kurs3 = "Java";
            string kurs4 = "Python";
            string kurs5 = "C#";


            string[] kurslar = new string[] { "Yazilim gelistirici Yetistirme Kampi", "Programlamaya baslangic icin temel kurs", "Java", "Python", "C#" };


            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);

            }
            Console.WriteLine("---------------------------------------------------------------");

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs);

            }
        }
    }
}
