
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Syötä luku. Ohjelma laskee parillisten ja parittomien summan: ");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);

            int i = 1;
            int even = 0;
            int odd = 0;

            do
            {
                if (i % 2 == 0)
                    even += i;
                else
                    odd += i;
                i++;
            }
            while (i <= number);

            Console.WriteLine($"Parillisten lukujen summa = {even} ja parittomien lukujen summa = {odd}");

         Console.ReadKey();
        }
    }
}
