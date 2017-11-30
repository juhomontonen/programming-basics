using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] arrT_1 = new int[10];
            int[] arrT_2 = new int[10];
            int[] arrT_3 = new int[10];

            for (int i = 0; i < 10; i++)
            {
                arrT_1[i] = rnd.Next(50);
                arrT_2[i] = rnd.Next(50);

                if (arrT_1[i] > arrT_2[i])
                {
                    arrT_3[i] = arrT_1[i];
                }
                else
                {
                    arrT_3[i] = arrT_2[i];
                }
            }


                Console.Write("         ");
                for (int j = 1; j <= 10; j++)
                {
                    if (j < 10)
                    {
                        Console.Write($"0{j} ");
                    }
                    else
                    {
                        Console.Write($"{j}\n");
                    }
                }

                Console.Write("         ");
                for (int v = 0; v < 15; v++)
                {
                    Console.Write("--");
                }

                Console.Write("\n arrT_1: ");
                for (int y = 0; y < 10; y++)
                {
                    Console.Write($"{arrT_1[y]:00} ");
                }

                Console.Write("\n arrT_2: ");
                for (int k = 0; k < 10; k++)
                {
                    Console.Write($"{arrT_2[k]:00} ");
                }

                Console.Write("\n arrT_3: ");
                for (int h = 0; h < 10; h++)
                {
                    Console.Write($"{arrT_3[h]:00} ");
                }

                Console.ReadKey();

            
        }
    }
}
