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
            int[] lottorivi = new int[40];
            Random rnd = new Random();
            int i = 0;

            while (i < 7)
            {
                int rndNumber = rnd.Next(0, 41);
                if (lottorivi[rndNumber] == 0)
                {
                    lottorivi[rndNumber] = 1;
                    i++;
                }
            }
            Console.WriteLine("Oikea lottorivi on: ");
            for (i = 0; i < lottorivi.Length; i++)
            {
                if (lottorivi[i] == 1)
                {
                    Console.Write($"{i} ");
                }
            }
                while (true)
                {
                    int rndNumber = rnd.Next(0, 41);
                    if (lottorivi[rndNumber] == 0)
                    {
                        lottorivi[rndNumber] = 2;
                        break;
                    }
                }
                for (i = 0; i < lottorivi.Length; i++)
                {
                    if (lottorivi[i]==2)
                    {
                        Console.WriteLine($" \nLisänumero: {i}");
                    }
                }
                Console.Write($"Tuplausnumero: {rnd.Next(0, 41)}");
            Console.ReadKey();
        }
    }
}
