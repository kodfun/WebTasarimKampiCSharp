using System;

namespace Karesi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bu program girilen sayının karesini hesaplar.");
            Console.Write("Sayı: ");
            string cevap = Console.ReadLine();
            int sayi = Convert.ToInt32(cevap);
            int sonuc = sayi * sayi;
            Console.WriteLine("Girdiğiniz sayının karesi: " + sonuc);

            Console.ReadKey(); // klavyeden bir tuş girmesini iste
        }
    }
}
