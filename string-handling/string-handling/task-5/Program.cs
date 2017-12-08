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
            Console.Write("Kirjoita jotain: ");
            string userInput;
            userInput = Console.ReadLine().ToUpper();
            int maara = 0;

            char[] vokaalit = new char[] { 'A', 'E', 'I', 'O', 'U', 'Y', 'Ä', 'Ö' };
            for (int i = 0; i < userInput.Length; i++)
            {
                foreach (char x in vokaalit)
                {
                    if (x == userInput[i])
                    {
                        maara++;
                        break;
                    }
                }
            }


            Console.WriteLine($"Tekstissäsi {userInput} on {maara} vokaalia.");
            Console.ReadKey();

        }
    }
}
