using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter row: ");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter column: ");
            int column = Convert.ToInt32(Console.ReadLine());
            double input = 0.0;
            double sum = 0.0;
            double average = 0.0;

            List<List<Double>> rowlist = new List<List<Double>>();
            Console.WriteLine();

            for (int i = 0; i < row; i++)
            {
                List<Double> columnlist = new List<Double>();
                Console.WriteLine($"Row: {i + 1}");
                for (int j = 0; j < column; j++)
                {
                    Console.Write($"Enter a number for Column {j + 1}: ");
                    input = Convert.ToDouble(Console.ReadLine());
                    columnlist.Add(input);
                    sum += input;
                }
                rowlist.Add(columnlist);

                Console.WriteLine();
            }

            average = sum / (row * column);
            Console.WriteLine("The numbers are:");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write(rowlist[i][j].ToString("F1") + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum:F1}");
            Console.WriteLine($"Average: {average:F1}");

            Console.ReadKey();
        }
    }
}
