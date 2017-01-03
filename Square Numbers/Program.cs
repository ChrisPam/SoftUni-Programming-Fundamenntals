using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(n => double.Parse(n)).ToArray();

            List<double> result = new List<double>();
            foreach (var number in numbers)
            {
                if(Math.Sqrt(number) == (int)Math.Sqrt(number))
                {
                    result.Add(number);
                }
            }
            result.Sort((a, b) => b.CompareTo(a));
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
