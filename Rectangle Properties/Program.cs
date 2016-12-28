using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double perimeter = width * 2 + height * 2;
            double area = width * height;
            double diagnonal = (width * width) + (height * height);
            double diagonalResult = Math.Sqrt(diagnonal);

            Console.WriteLine(perimeter);
            Console.WriteLine(area);
            Console.WriteLine(diagonalResult);
        }
    }
}
