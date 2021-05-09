using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            SaatiYazdir();
            KereYazdir("Oley! ", 3);
            KereYazdir("Merhaba! ");
            string gun = HaftaninGunu();
            Console.WriteLine("Bugün günlerden " + gun);
            Console.WriteLine("{0} + {1} = {2}", 3, 5, Topla(3,5));
            Console.ReadKey();
        }

        // parametre alan değer döndüren
        static double Topla(double sayi1, double sayi2)
        {
            return sayi1 + sayi2;
        }

        // parametre almayan değer döndüren
        static string HaftaninGunu()
        {
            return DateTime.Today.DayOfWeek.ToString();
        }

        // parametre alan değer döndürmeyen
        // adet parametresi opsiyonel bir parametredir, değeri verilmezse 1 olur
        static void KereYazdir(string metin, int adet = 1)
        {
            for (int i = 0; i < adet; i++)
            {
                Console.Write(metin);
            }
            Console.WriteLine();
        }

        // parametre almayan değer döndürmeyen
        static void SaatiYazdir()
        {
            Console.WriteLine(DateTime.Now.ToLongTimeString());
        }
    }
}
