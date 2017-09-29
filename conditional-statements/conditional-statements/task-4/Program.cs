using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define instructions
            Console.WriteLine("Syötä ohjelmaan 3 numeroa:");
            {

                Console.WriteLine("Syötä numero 1: ");
                // Define variables
                string numero1 = Console.ReadLine();
                int numx = int.Parse(numero1);

                Console.WriteLine("Syötä numero 2: ");
                string numero2 = Console.ReadLine();
                int numy = int.Parse(numero2);

                Console.WriteLine("Syötä numero 3: ");
                string numero3 = Console.ReadLine();
                int numz = int.Parse(numero3);

                if (numx < numy && numx < numz)
                {
                    if (numy < numz)
                    {
                        Console.WriteLine($"Järjestys on {numx}, {numy}, {numz}");
                    }
                    else
                    { 
                    Console.WriteLine($"Järjestys on {numx}, {numz}, {numy}");
                    }   
                }
                if (numy < numx && numy < numz)
                {
                    if (numx < numz)
                    {
                        Console.WriteLine($"Järjestys on {numy}, {numx}, {numz}");
                    }
                    else
                    {
                        Console.WriteLine($"Järjestys on {numy}, {numz}, {numx}");
                    }
                }
                if (numz < numx && numz < numy)
                {
                    if (numx < numy)
                    {
                        Console.WriteLine($"Järjestys on {numz}, {numx}, {numy}");
                    }
                    else
                    {
                        Console.WriteLine($"Järjestys on {numz}, {numy}, {numx}");
                    }
                }
                Console.ReadKey();
            }
        }
    }
}
