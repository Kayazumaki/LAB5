using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Metoda nr.1"); //METODA 1

            Console.ReadKey();

            Console.Write("Podaj ilość liczb parzystych do wygenerowania: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Wylosowane {n} liczby parzyste:");

            Random rand = new Random();
            int licznik = 0;

            while (licznik < n)
            {
                int liczba = rand.Next(-8, 8);

                if (liczba % 2 == 0)
                {
                    Console.Write(liczba);

                    if (licznik < n - 1)
                    {
                        Console.Write(", ");
                    }

                    licznik++;
                }
            }

            
            
            

            Console.ReadLine();

            Console.WriteLine("Metoda nr.2"); //METODA 2

            Console.Write("Podaj ilość liczb parzystych do wygenerowania: ");
            int k = int.Parse(Console.ReadLine());

            Console.WriteLine($"Wylosowane {k} liczby parzyste:");

            Random rah = new Random();
            int licz = 0;

            while (licz < k)
            {
                int liczba = rah.Next(-8, 8) * 2;

                Console.Write(liczba);

                if (licz < k - 1)
                {
                    Console.Write(", ");
                }

                licz++;
            }

            Console.ReadLine();
        }
    }
}
