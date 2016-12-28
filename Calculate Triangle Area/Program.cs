using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area = GetTriangleArea(height, width);
            Console.WriteLine(area);
        }
        static double GetTriangleArea(double height, double width)
        {
            return height * width / 2;
        }
    }
}
