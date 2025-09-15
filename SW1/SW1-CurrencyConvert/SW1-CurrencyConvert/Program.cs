using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW1_CurrencyConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> money = new List<double>();
            Console.WriteLine("Currency Converter Program");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter currency in ($): ");
                money.Add(Convert.ToDouble(Console.ReadLine()));
            }

            Console.WriteLine();
            dollarToPesoToYen(money);

            Console.ReadKey();
        }
        //converts the dollar to peso and yen
        static void dollarToPesoToYen(List<double> money)
        {
            Console.WriteLine("Dollar ($)\tPhil Peso (P)\tJpn Yen (Y)");
            foreach (double dollar in money)
            {
                Console.WriteLine(dollar + "\t\t" + dollar * 57.17 + "\t\t" + dollar * 146.67);
            }
        }
    }
}
