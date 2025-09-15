using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prime or Composite Program");
            List <String> input = new List <String>();
            for (int i = 1; i <= 5; i++)
            {
                Console.Write("Enter a String: ");
                input.Add(Console.ReadLine());
            }

            Console.WriteLine();
            isPrimeorComposite(input);

            Console.ReadKey();
        }
        //Checks if its Prime or Composite
        static void isPrimeorComposite(List <String> inputs)
        {
            int counter = 1;
            foreach (String input in inputs)
            {
                bool isPrime = true;
                int num = int.Parse(input);
                Console.Write($"{counter}. ");
                if (num <= 1)
                {
                    Console.WriteLine($"{num} is neither Prime or Composite");
                    continue;
                }
                else
                {
                    for (int i = 2; i * i <= num; i++)
                    {
                        if (num % i == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime)
                    {
                        Console.WriteLine($"{num}\tPrime");
                    }
                    else
                    {
                        Console.WriteLine($"{num}\tComposite");
                    }
                }
                counter++;
            }
        }
    }
}
