using System;

namespace Verziókezelés
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérem adjon meg 10 számot: ");
            int[] szamok = new int[10];
            for (int i = 0; i < szamok.Length; i++)
            {
                Console.WriteLine("Adja meg a következő számot");
                int beertek = int.Parse(Console.ReadLine());
                szamok[i] = beertek;
            }
            
        }
    }
}
