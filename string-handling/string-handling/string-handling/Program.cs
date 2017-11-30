using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_handling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kirjoita jotain: ");
            string userInput;
            userInput = Console.ReadLine();

            Console.WriteLine($"Tekstissäsi on {userInput.Length} merkkiä");

            Console.ReadKey();
        }
    }
}
