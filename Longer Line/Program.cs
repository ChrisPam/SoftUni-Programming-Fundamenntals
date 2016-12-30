using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            GetLongerLine(x1, y1, x2, y2, x3, y3, x4, y4);
        }

        private static void GetLongerLine(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            double firstPair = Math.Pow(Math.Abs(x1), 2) + Math.Pow(Math.Abs(y1), 2) + Math.Pow(Math.Abs(x2), 2) + Math.Pow(Math.Abs(y2), 2);
            double secondPair = Math.Pow(Math.Abs(x3), 2) + Math.Pow(Math.Abs(y3), 2) + Math.Pow(Math.Abs(x4), 2) + Math.Pow(Math.Abs(y4), 2);

            bool firstIsGraterThanSecond = firstPair >= secondPair;

            if (firstIsGraterThanSecond == false)
            {
                if (Math.Pow(Math.Abs(x3), 2) + Math.Pow(Math.Abs(y3), 2) >= Math.Pow(Math.Abs(x4), 2) + Math.Pow(Math.Abs(y4), 2))
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
                else if (Math.Pow(Math.Abs(x3), 2) + Math.Pow(Math.Abs(y3), 2) <= Math.Pow(Math.Abs(x4), 2) + Math.Pow(Math.Abs(y4), 2))
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
            }
            else
            {
                //Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
        }
    }
}
