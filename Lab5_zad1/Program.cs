using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj ilość liczb pierwszych do wyświetlenia: ");
            int n;

            while (!int.TryParse(Console.ReadLine(), out n) || n < 1)
            {
                Console.WriteLine("Nieprawidłowa wartość. Podaj liczbę większą od zera.");
            }

            Console.WriteLine($"Pierwsze {n} liczb pierwszych:");

            int liczba = 2;
            int licznik = 0;

            while (licznik < n)
            {
                if (CzyLiczbaPierwsza(liczba))
                {
                    Console.WriteLine(liczba);
                    licznik++;
                }

                liczba++;
            }

            Console.ReadLine();
        }

        static bool CzyLiczbaPierwsza(int liczba)
        {
            if (liczba < 2)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(liczba); i++)
            {
                if (liczba % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
