using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    internal class AreaOfCricle
    {
       static void Main(string[] args)
        {
            double r1;
            Console.WriteLine("Enter the RADIUS of circle");
            r1=Convert.ToDouble(Console.ReadLine());

            double area = 3.14 * (r1*r1);
            Console.WriteLine("The area of a circle with radius {0} is: {1}", r1, area);
        }
    }
}
