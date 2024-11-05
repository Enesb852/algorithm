using System;
using System.Data;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi = 0 , sayac = 1, fak = 1;
            
            
            Console.WriteLine("Bir sayı giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine());
            enes:
            sayac++;
            if (sayac <= sayi) { fak = fak * sayac; goto enes; }
            Console.WriteLine(fak);
        }
    }
}

