using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MetotlarAlistirma
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = Add(4);// ikinci deger verilmez ise default degeri olarak 30 kullanilir. deger 34 ü döner

            Console.WriteLine(result);
            //-------------------------------------------------------------
            int number1;  //out - refle ayni isi görür. ref´ten farki nummer 1 en basta bir deger atamana gerek yok
            int number2 = 100;
            var result2 = Add2(out number1, number2);
            Console.WriteLine(result2);
            Console.WriteLine(number1);
            //--------------------------------------------------------------

            Console.WriteLine(multiply(2, 4));
            Console.WriteLine(multiply(2, 4, 5));
            //--------------------------------------

            Console.WriteLine(Add3(1, 2, 3, 4, 5, 6, 7));
            Console.ReadLine();


        }

        static int Add(int number1, int number2 = 30) // default deger son deger olmak zorunda
        {
            var result = number1 + number2;
            return result;
        }

        static int Add2(out int number1, int number2) // ref keyword  ile: sadece metot icinde degisen nummer1 =30 degeri yukaridaki nummer1 = 20 degerininde arka planda 30 olmasini saglar
        {
            number1 = 30;
            return number1 + number2;

        }

        static int multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        static int multiply(int number1, int number2, int number3) // ayni isimli metotu fazla sayidaki degerler icinde kullanilir. buna Overloading özelligi denir.
        {
            return number1 * number2 * number3;
        }

        static int Add3(int nummer, params int[] numbers) // ilk deger metotta kullanilmadigi icin yukarida 2,3,4,5,6,7 toplar. 1 int nummer atanmis olur
        {
            return numbers.Sum();

        }
    }
}
