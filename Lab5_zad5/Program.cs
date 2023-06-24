using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_zad5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int n = -1;

            while (x <= 0)
            {
                Console.Write("Podaj liczbę naturalną x: ");
                if (!int.TryParse(Console.ReadLine(), out x) || x <= 0)
                {
                    Console.WriteLine("Błędne dane. Podaj liczbę naturalną większą od zera.");
                }
            }

            while (n < 0)
            {
                Console.Write("Podaj liczbę całkowitą nieujemną n: ");
                if (!int.TryParse(Console.ReadLine(), out n) || n < 0)
                {
                    Console.WriteLine("Błędne dane. Podaj liczbę całkowitą nieujemną.");
                }
            }

            int result = 0;
            int temp = 0;
            int iter = 0;

            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    temp += result;
                    iter++;
                }
                result = temp;
                temp = 0;
            }

            int expectedResult = (int)Math.Pow(x, n);

            Console.WriteLine("Wynik obliczony: " + result);
            Console.WriteLine("Wynik oczekiwany: " + expectedResult);
            Console.WriteLine("Czy wyniki są zgodne: " + (result == expectedResult));

            Console.ReadLine();
        }
    }
}
