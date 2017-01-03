using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> numbers = Console.ReadLine().Split().Select(x => decimal.Parse(x)).ToList();

            
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if(numbers[i] == numbers[i + 1])
                {
                    var sum = numbers[i] + numbers[i];
                    numbers.Remove(numbers[i]);
                    numbers.Remove(numbers[i]);
                    numbers.Insert(i, sum);
                    i = -1;
                }
            }
            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }
        }
    }
}
