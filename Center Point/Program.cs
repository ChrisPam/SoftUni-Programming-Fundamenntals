using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Center_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            PrintPointClosestToCenter(x1, y1, x2, y2);
        }

        private static void PrintPointClosestToCenter(double x1, double y1, double x2, double y2)
        {
            double firstLine = Math.Pow(x1, 2) + Math.Pow(y1, 2);
            double secondLine = Math.Pow(x2, 2) + Math.Pow(y2, 2);

            bool firstIsGraterThanSecond = firstLine > secondLine;

            if (firstIsGraterThanSecond == true)
            {
                Console.WriteLine($"({x2}, {y2})");
            }
            else if(firstIsGraterThanSecond == false)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
        }
    }
}
