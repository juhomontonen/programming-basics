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
            int n = 0;
            int ok = 0;
            int lowerBound = 1;
            int upperBound = 20;
            while (true)
            {
                Console.Write("Syötä luku väliltä 1-20");
                n = int.Parse(Console.ReadLine());

                if (n < 1 && n > 20)
                {
                    Console.WriteLine($"Luku {n} ei ole sallittu luku.");
                }
                else
                {
                    break;
                }
                
            }
            int retNumber = numberFromRange(1, 20);

        }
        static int numberFromRange(int lowerBound, int upperBound)
        {
            if (n >= lowerBound && n <= upperBound)
            {
                return ok;
            }
            else
            {

            }
        }

    }
}
