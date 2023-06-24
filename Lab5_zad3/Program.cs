using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Jaki wysoki ma być trójkąt? Podaj wysokość: ");
            int wysokosc = int.Parse(Console.ReadLine());

            for (int i = 1; i <= wysokosc; i++)
            {
                int iloscZnakow = 2 * i - 1;
                int iloscSpacji = wysokosc - i;

                Console.Write(new string(' ', iloscSpacji));
                Console.WriteLine(new string('+', iloscZnakow));
            }

            Console.ReadLine();
        }
    }
}
