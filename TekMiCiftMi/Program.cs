using System;

namespace TekMiCiftMi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sayı: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            bool ciftMi = sayi % 2 == 0;

            // Console.WriteLine(ciftMi);
            //             boolean ifade ? true ise : false ise
            string sonuc = ciftMi ? "çift" : "tek"; // =>  ternary operator ?:

            Console.WriteLine("Girdiğiniz sayı bir " + sonuc + " sayıdır.");
            Console.WriteLine($"Girdiğiniz sayı bir {sonuc} sayıdır.");
            Console.WriteLine("Girdiğiniz sayı bir {0} sayıdır.", sonuc);

            Console.ReadKey();
        }
    }
}
