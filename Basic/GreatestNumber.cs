using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    internal class GreatestNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int num1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter third number");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if(num1>num2 && num1 > num3)
            {
                Console.WriteLine(num1+" is greatest number");
            }
            else if (num2>num1 && num2> num3)
            {
                Console.WriteLine(num2 + " is greatest number");
            }
            else
            {
                Console.WriteLine(num3 + " is greatest number");
            }

        }
    }
}
