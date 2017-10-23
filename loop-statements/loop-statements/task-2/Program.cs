using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa kertotaulun luvuille 1-9: ");

            for (int i=1; i<=9; i++)
            {
                for (int k=1; k<=10; k++)
                {
                    if (i == 0)
                    {
                        Console.Write("{0}\t", i);
                    }
                    else
                    {
                        Console.Write("{0}\t", i * k);
                    }
                }
            }

            Console.ReadKey();

        }
    }
}
