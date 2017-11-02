using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNumber = new int[100];
            Random rnd = new Random();
            double sum = 0;

            for (int i = 0; i < arrayNumber.Length; i++)
            {
                arrayNumber[i] = rnd.Next(0, 51);
                Console.WriteLine(arrayNumber[10]);
            }
            for (int i = 0; i < arrayNumber.Length; i++)
            {
                Console.WriteLine($"{i}. {arrayNumber[i]}");
                sum += arrayNumber[i];

            }
            Console.WriteLine($"Lukujen summa on {sum}");
            Console.WriteLine($"Lukujen keskiarvo on {sum/arrayNumber.Length:f2}");
            

            Console.ReadKey();
        }
    }
}
