using System;
using System.Data;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi = 0, sayac, ek = 0;

            for (sayac = 0; sayac < 5; sayac++)
            {
                Console.WriteLine("Bir sayı girin: ");
                sayi = Convert.ToInt32(Console.ReadLine());
                if (sayac == 1) // Sayaç 1 olduğunda bunu en küçük değer olarak ayarla
                {
                    ek = sayi;
                }

                if(sayi < ek) { ek = sayi; }
            }

            Console.WriteLine("En küçük değer: " + ek);
        }
    }
}

