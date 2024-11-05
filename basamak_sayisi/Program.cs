using System;
using System.Data;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi, bas=1;
        
            Console.WriteLine("Bir sayı gir");
            sayi = Convert.ToInt32(Console.ReadLine());
            enes:
            if (sayi < 10) { Console.WriteLine(bas); }
            else { sayi = sayi / 10;
                bas++;
                goto enes;
            }
        }
    }
}

