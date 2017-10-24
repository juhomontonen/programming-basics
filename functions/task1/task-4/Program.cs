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
            Console.WriteLine("Syötä ohjelmaan 10 positiivista kokonaislukua. Ohjelma palauttaa suurimman.");
            Console.WriteLine(Luvut());
            Console.ReadKey();
        }
        static string Luvut()
        {
            int luku = 0;
            bool num = false;
            int iso = 0;
            int mones = 0;
            string lukujono = "";

            for (int i = 1; i <= 10; i++)
            {
                do
                {
                    Console.Write($"Syötä {i}. luku: ");
                    num = int.TryParse(Console.ReadLine(), out luku);
                    if (!num || luku < 1)
                    {
                        Console.WriteLine($"{luku} ei ole positiivinen kokonaisluku.");
                    }
                    if (iso < luku)
                    {
                        iso = luku;
                        mones = i;
                    }

                }
                while (luku < 0);

                lukujono += $"{luku} ";

            }
            Console.WriteLine($"Syötit seuraavat luvut: {lukujono}\n");
            return ($"Suurin luku oli {iso} eli syöte numero {mones}.");
        }
    }
}
