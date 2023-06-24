using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rozmiar = 0;
            int iloscProb = 0;
            Random rand = new Random();

            while (rozmiar < 3)
            {
                Console.Write("Podaj rozmiar rombu (nieparzysta liczba >= 3): ");
                if (!int.TryParse(Console.ReadLine(), out rozmiar))
                {
                    Console.WriteLine("Błędne dane. Podaj liczbę.");
                    iloscProb++;
                }
                else if (rozmiar % 2 == 0 || rozmiar < 3)
                {
                    Console.WriteLine("Błędne dane. Podaj nieparzystą liczbę większą lub równą 3.");
                    rozmiar = 0;
                    iloscProb++;
                }

                if (iloscProb >= 3)
                {
                    Console.WriteLine("Przekroczono limit prób. Koniec programu.");
                    Console.ReadLine();
                    return;
                }
            }

            Console.WriteLine("Rysowanie rombu o rozmiarze: " + rozmiar);
            Console.WriteLine();

            string[] obramowanie = {  "|"  };
            string[] wnetrze = { "p", "-" };

            for (int i = 0; i < rozmiar; i++)
            {
                int iloscSpacji = Math.Abs(rozmiar / 2 - i);
                int iloscZnakow = rozmiar - 2 * iloscSpacji;

                for (int j = 0; j < iloscSpacji; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k < iloscZnakow; k++)
                {
                    if (k == 0 || k == iloscZnakow - 1 || i == 0 || i == rozmiar - 1)
                    {
                        int indeksObramowania = rand.Next(obramowanie.Length);
                        Console.Write(obramowanie[indeksObramowania]);
                    }
                    else
                    {
                        int indeksWnetrza = rand.Next(wnetrze.Length);
                        Console.Write(wnetrze[indeksWnetrza]);
                    }
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
