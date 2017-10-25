using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee lisäyksen. Anna luku, jonka lisäys lasketaan: ");
            string userInput = Console.ReadLine();

            int number = int.Parse(userInput);

            int i = 1;
            int f = 1;

            if (number < 1)
            {
                Console.WriteLine("Virheellinen syöte");
            }
            else
            {
                do
                {
                    i = i + 1;

                    f = f + i;
                    Console.WriteLine($"{i}= {f}");
                } while (i < number);
            }
            Console.ReadKey();
        }
    }
}
