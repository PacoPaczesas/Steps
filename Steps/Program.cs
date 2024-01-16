using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program tworzy wzór gdzie tworzy wskazaną liczbę wierszy. W każdym wierszy jest znak # równy numerowi wiersza");
            Console.WriteLine("Wprowadź liczbę wierszy");

            string wartosc = Console.ReadLine();
            if (int.TryParse(wartosc, out int steps))
            {
                Console.WriteLine("");
                WyswietlSchody(steps);
            }
            else
            {
                Console.WriteLine("Nieprawidłowy format liczby całkowitej.");
            }
        }


        static void WyswietlSchody (int steps)
        {
            for (int i = 0; i < steps; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("#");
                }

                for (int k = steps; k > i + 1; k--)
                {
                    Console.Write(" ");
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }

    }
}
