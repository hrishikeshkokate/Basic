using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    internal class AreaOfTriangle
    {
        static void Main(string[] args)
        {
            int b1;
            int h1;

            Console.WriteLine("Enter the base of triangle");
            b1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the height of triangle");
            h1 = Convert.ToInt32(Console.ReadLine());

            double area=0.5*b1*h1;

            Console.WriteLine("Area of trangle with base "+b1+" and height "+h1+" is : "+area);
        }
    }
}
