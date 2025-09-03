using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDB_Homeworks
{
    class Program
    {
        static void Main(string[] args)
        {
            do {
                Console.WriteLine();
                String rev_input = "";
                Console.Write("Enter a String: ");
                String input = Console.ReadLine();
                if (input == "*")
                {
                    break;
                }
                input = input.ToLower();

                int length = 0;

                foreach (char alphabet in input)
                {
                    length++;
                }

                for (int i = length; i > 0; i--)
                {
                    rev_input = rev_input + input[i - 1];
                }

                Console.WriteLine();
                Console.WriteLine("Original String:\t\tReversed String:");
                Console.WriteLine(input + "\t\t\t\t" + rev_input);

                if (input == rev_input)
                {
                    Console.WriteLine("Palindrome?\t\t\tYes");
                }
                else
                {
                    Console.WriteLine("Palindrome?\t\t\tNo");
                }
            } while (true);
        }
    }
}
