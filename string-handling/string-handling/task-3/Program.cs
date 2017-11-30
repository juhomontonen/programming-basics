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
            Console.Write("Kirjoita jotain: ");
            string userInput;
            userInput = Console.ReadLine().ToUpper();
            int i = 0;

            foreach (char x in userInput)
            {
                if (x == 'L')
                i++;
            }


            Console.WriteLine($"Tekstissäsi on {i} L-merkkiä.");
            Console.ReadKey();
        }
    }
}
