using System;
namespace Uppgift5_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] städer = { "1. Kina", "2. Indien", "3. USA", "4. Indonesien", "5. Pakistan" };
            for (int i = 0; i < städer.Length; i++)
            {
                Console.WriteLine(städer[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Mata in dem länder du vill ska visas igen genom att skriva deras nummer separerat av mellanslag.");
            string[] svar = Console.ReadLine().Split();
            Console.WriteLine();
            for (int i = 0; i < svar.Length; i++)
            {
                int ny = int.Parse(svar[i]);
                Console.WriteLine(städer[ny-1]);
            }
            Console.ReadKey();
        }
    }
}