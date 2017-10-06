using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Syötä ohjelmaan luku: ");
            // Define variables
            string luku = Console.ReadLine();
            int num = int.Parse(luku);
            int i = 1;
            int n = 1;
            string parseOutput = "";

            while (i <= num)
            {
                parseOutput = $"{parseOutput} x {i}";
                n = n * i;              
                Console.WriteLine($"{i}!={n}"); //5!=120
                i++;
            }
            Console.WriteLine($"{parseOutput}={n}");
            Console.ReadLine();
        }
    }
}
