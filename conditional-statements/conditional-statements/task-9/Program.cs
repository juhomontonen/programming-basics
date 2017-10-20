using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee lisäyksen. Anna luku, jonka lisäys lasketaan: ");
            string userInput = Console.ReadLine();

            int number = int.Parse(userInput);

            int i = 1;
            int f = 0;

            if (number == 0)
            {
                Console.WriteLine("Virheellinen syöte");
            }
            else if (number > 0)
            {
                do
                {
                    i = i + 1;

                    f = f + i;
                    Console.WriteLine($"{i} = {f}");
                } while (i < number);
            }
            else if (number < 0)
            {
                do
                {
                    i = i - 1;

                    f = f + i;
                    Console.WriteLine($"{i} = {f}");
                } while (i > number);
            }
            Console.ReadKey();
        }
    }
}
