using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    internal class GradeByPercentage
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter marks of Maths");
            int sub1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter marks of Bio");
            int sub2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter marks of Physics");
            int sub3 = Convert.ToInt32(Console.ReadLine());

            double total = sub1 + sub2 + sub3 ;

            double percentage = (total / 300) * 100;

            char grade;

            switch ((int)percentage / 10)
            {
                case 10:
                case 9:
                    grade = 'A';
                    break;
                case 8:
                    grade = 'B';
                    break;
                case 7:
                    grade = 'C';
                    break;
                case 6:
                    grade = 'D';
                    break;
                default:
                    grade = 'F';
                    break;
            }

            Console.WriteLine($"Your percentage is {percentage}% and your grade is {grade}");
        }
    }
}
