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
            Console.WriteLine("Ohjema arpoo yksiulotteiseen kokonaislukutaulukkoon arvot väliltä 0-20");
            int[] arrayNumber = new int[10];
            Random rnd = new Random();
            Console.WriteLine("[X]\t=\tArvo");

            for (int i = 0; i < 10; i++)
            {
                arrayNumber[i] = rnd.Next(0, 20);
                if (arrayNumber[i] < 10)
                {
                    Console.WriteLine($"[{i}]\t=\t0{arrayNumber[i]}");
                }
                else
                {
                    Console.WriteLine($"[{i}]\t=\t{arrayNumber[i]}");
                }


            }
            Console.ReadKey();

        }
    }
}
