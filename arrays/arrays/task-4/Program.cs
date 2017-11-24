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
            Console.WriteLine("Ohjema arpoo kaksiulotteisen kokonaislukutaulukkoon arvot väliltä 0-100");
            int[,] arrayNumber = new int[10,20];
            Random rnd = new Random();
            Console.WriteLine("[X, Y] = Arvo ");

            for (int i=0;i<10;i++)
            {
                for (int y=0;y<20;y++)
                {
                    arrayNumber[i, y] = rnd.Next(0, 100);
                    if (arrayNumber[i, y] < 10)
                    {
                        Console.WriteLine($"[{i}, {y}] = 0{arrayNumber[i,y]}");
                    }
                    else
                    {
                        Console.WriteLine($"[{i}, {y}] = {arrayNumber[i, y]}");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
