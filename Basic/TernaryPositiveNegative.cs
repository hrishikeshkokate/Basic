using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    internal class TernaryPositiveNegative
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());

            string result = (number > 0) ? "Positive" : (number < 0) ? "Negative" : "Zero";

            Console.WriteLine($"The number is {result}.");
        }
    }
}
