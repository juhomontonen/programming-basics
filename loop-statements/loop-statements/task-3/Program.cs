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
            Console.WriteLine("Ohjelma tulostaa 20 satunnaista kokonaislukua väliltä 0-50: ");
            Random rnd = new Random();

            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine($"{rnd.Next(50)},\t {rnd.Next(50)},\t {rnd.Next(50)},\t {rnd.Next(50)},\t {rnd.Next(50)}");
            }

            Console.ReadKey();
        }
    }
}
