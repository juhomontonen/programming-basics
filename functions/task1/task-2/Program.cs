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
            int luku1;
            int luku2;

            Console.WriteLine("Syötä ohjelmaan kaksi lukua. Ohjelma laittaa luvut suuruusjärjestykseen.");
            Console.Write("Ensimmäinen luku: ");
            luku1 = int.Parse(Console.ReadLine());

            Console.Write("Toinen luku: ");
            luku2 = int.Parse(Console.ReadLine());

            int x = vertaa(luku1, luku2);

            if (x==luku1)
            {
                Console.WriteLine($"{luku1} on pienempi kuin {luku2}.");
            }
            else
            {
                Console.WriteLine($"{luku2} on pienempi kuin {luku1}.");
            }
            Console.ReadKey();
        }
        static int vertaa(int luku1, int luku2)
        {
            if (luku1<luku2)
            {
                return luku1;
            }
            else
            {
                return luku2;
            }
        }


    }
}
