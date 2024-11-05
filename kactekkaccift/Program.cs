using System;
using System.Data;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi = 0, sayac = 0, kac_cift = 0, kac_tek = 0;

        enes:
            Console.WriteLine("Bir sayı girin: ");
            sayi = Convert.ToInt32(Console.ReadLine());
            sayac++;
            if (sayi % 2 == 0) { kac_cift++; }

            else { kac_tek++; };

            if(sayac < 5) { goto enes; }
            Console.WriteLine("Tek sayısı: " + kac_tek);
            Console.WriteLine("Çift sayısı: " + kac_cift);
        }
    }
}

