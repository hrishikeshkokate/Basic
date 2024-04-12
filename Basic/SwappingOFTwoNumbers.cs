using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Basic
{
    internal class SwappingOFTwoNumbers
    {

        static void Main(String[] strings)
        {
            int num1;
            Console.WriteLine("Enter the 1st number");
            num1=Convert.ToInt16(Console.ReadLine());

            int num2;
            Console.WriteLine("Enter the 2nd number");
            num2 = Convert.ToInt16(Console.ReadLine());

            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;

            Console.WriteLine("After Swapping");
            Console.WriteLine("First number :"+num1);
            Console.WriteLine("Second number :"+num2);




        }

        
    }
}
