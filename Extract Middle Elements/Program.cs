using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extract_Middle_1__2_or_3_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

            List<int> middleElements = new List<int>();
            int n = numbers.Length;

            if (n % 2 == 1 && n != 1)
            {
                middleElements.Add(numbers[(n / 2) - 1]);
                middleElements.Add(numbers[n / 2]);
                middleElements.Add(numbers[(n / 2) + 1]);
            }
            else if (n % 2 == 0)
            {
                middleElements.Add(numbers[n / 2 - 1]);
                middleElements.Add(numbers[n / 2]);
            }
            else if (n == 1)
            {
                middleElements.Add(numbers[0]);
            }
            Console.WriteLine("{ " + string.Join(", ", middleElements) + " }");

        }
    }
}
