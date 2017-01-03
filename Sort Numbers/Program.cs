using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(n => double.Parse(n)).ToArray();

            List<double> result = new List<double>();
            foreach (var number in numbers)
            {
                result.Add(number);
            }
            result.Sort((a, b) => a.CompareTo(b));
            Console.WriteLine(string.Join(" <= ", result));
        }
    }
}
