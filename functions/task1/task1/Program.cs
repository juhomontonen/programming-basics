using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            do
            {
                Console.Write("Syötä ohjelmalle luku: ");
                string luku = Console.ReadLine();
                num = int.Parse(luku);
                if (num < 0)
                {
                    Console.Write($"Numero {num} ei ole sallittu luku.\n");
                }

                for (int i = 0; i < num; i++)
                {
                    Console.Write("*");
                }
            }
            while (num < 0);
            Console.ReadKey();
        }
    }
}
