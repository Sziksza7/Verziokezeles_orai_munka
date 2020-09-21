using System;

namespace Verziókezelés
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérem adjon meg x számot: ");
            int x = int.Parse(Console.ReadLine());
            int[] szamok = new int[x];
            for (int i = 0; i < szamok.Length; i++)
            {
                Console.WriteLine("Adja meg a következő számot");
                int beertek = int.Parse(Console.ReadLine());
                szamok[i] = beertek;
            }
            int osszeg=0;
            for (int i = 0; i < szamok.Length; i++)
            {
                osszeg = osszeg + szamok[i];
            }
            double atlag = osszeg / x;
            Console.WriteLine("A számok átlaga: "+atlag);
        }
    }
}
