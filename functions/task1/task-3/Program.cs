using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tarkistaa onko luku annetulta alueelta.");
            int retNumber = numberFromRange(1, 20);
            Console.WriteLine($"Syötit {retNumber}. Se on annetulta alueelta.");
            Console.ReadKey();

        }
        static int numberFromRange(int lowerBound, int upperBound)
        {
            int luku = 0;
            bool num = false;
            do
            {
                Console.Write($"Syötä luku väliltä {lowerBound}-{upperBound}: ");
                num = int.TryParse(Console.ReadLine(), out luku);
                if (!num || luku < lowerBound || luku > upperBound)
                {
                    Console.WriteLine($"Syötit {luku}. Se ei ole annetulta alueelta.");
                }

            }
            while (!num || luku < lowerBound || luku > upperBound);
            {
                return luku;
            }
        }
    }
}
