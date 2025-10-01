using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_HW3
{
    class Program
    {
        static void Main(string[] args)
        {
            String input;
            String[] separator;

            Console.Write("Please Enter a word: ");
            input = Console.ReadLine();

            separator = input.Replace(", ", ",").Split(',');
            Console.WriteLine();

            frequencyCounter(separator);

            Console.ReadKey();
        }

        static void frequencyCounter(String[] characters)
        {
            Dictionary<Char, int> letterFrequency = new Dictionary<Char, int>();
            Dictionary<Char, Char> letterAppearance = new Dictionary<Char, Char>();

            for (int i = 0; i < characters.Length; i++)
            {
                for (int j = 0; j < characters[i].Length; j++)
                {
                    Char letter = characters[i][j];
                    Char lowercased = Char.ToUpper(letter);

                    if (letterFrequency.ContainsKey(lowercased))
                    {
                        letterFrequency[lowercased] += 1;
                    }
                    else
                    {
                        letterFrequency.Add(lowercased, 1);
                        letterAppearance.Add(lowercased, letter);
                    }
                }
                foreach (KeyValuePair<Char, int> alphabet in letterFrequency)
                {
                    char fakeDisplay = letterAppearance[alphabet.Key];
                    Console.Write($"{fakeDisplay}: {alphabet.Value}, ");
                }
                letterFrequency.Clear();
                letterAppearance.Clear();
                Console.WriteLine();
            }
        }
    }
}
