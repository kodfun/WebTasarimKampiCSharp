using System;

namespace HaftaninGunu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Gün no (1-7): ");
            int no = Convert.ToInt32(Console.ReadLine());
            string gun;
            switch (no)
            {
                case 1:
                    gun = "Pazartesi";
                    break;
                case 2:
                    gun = "Salı";
                    break;
                case 3:
                    gun = "Çarşamba";
                    break;
                case 4:
                    gun = "Perşembe";
                    break;
                case 5:
                    gun = "Cuma";
                    break;
                case 6:
                    gun = "Cumartesi";
                    break;
                case 7:
                    gun = "Pazar";
                    break;
                default:
                    gun = "#HATA#";
                    break;
            }

            Console.WriteLine(gun);

            Console.ReadKey();
        }
    }
}
