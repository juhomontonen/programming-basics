using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop_statements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa 1-10 kokonaisluvut sekä niiden neliöjuuret: ");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i} \t {Math.Sqrt(i):f2}");
            }

            Console.ReadKey();

        }
    }
}
