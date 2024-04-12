using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    internal class SubjectPercentage
    {
        static void Main(string[] args)
        {
            int sub1;
            int sub2;
            int sub3;
            int sub4;
            int sub5;

            Console.WriteLine("Enter marks of Maths");
            sub1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter marks of Bio");
            sub2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter marks of Physics");
            sub3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter marks of Chemistry");
            sub4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter marks of English");
            sub5 = Convert.ToInt32(Console.ReadLine());

            double total = sub1 + sub2 + sub3 + sub4 + sub5;

            double percentage = (total / 500) * 100;

            Console.WriteLine("Percentage "+percentage);

        }
    }
}
