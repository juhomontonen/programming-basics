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
            Console.Write("Kirjoita jotain: ");
            string userInput;
            userInput = Console.ReadLine().ToUpper();
            
            userInput = userInput.Replace(" ", "");


        
            if (IsPalindrome(userInput))
            {
                Console.WriteLine("Syötteesi on palindromi");
            }
            else
            {
                Console.WriteLine("Syötteesi ei ole palindromi");
            }
            Console.ReadKey();

        }
        static bool IsPalindrome(string xx)
        {
            bool isPalindrome = true;
            for (int i = 0; i < xx.Length; i++)
            {
                int j = xx.Length - i - 1;
                if (xx[i] != xx[j])
                {
                    isPalindrome = false;
                    break;
                }
                else if (i > j)
                {
                    break;
                }

            }
            return isPalindrome;
        }
    }
}
