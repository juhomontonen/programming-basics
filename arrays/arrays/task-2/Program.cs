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
            int[] lottorivi = new int[8];
            Random rnd = new Random();


                for (int i = 0; i < lottorivi.Length; i++)
                {
                    lottorivi[i] = rnd.Next(0, 40);
                }

            Console.WriteLine($"{lottorivi[1]} {lottorivi[2]} {lottorivi[3]} {lottorivi[4]}");


                Console.ReadKey();
        }
    }
}
