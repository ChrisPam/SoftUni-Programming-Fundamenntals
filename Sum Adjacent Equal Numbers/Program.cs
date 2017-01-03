using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(n => int.Parse(n)).ToArray();

            List<int> nums = numbers.ToList();
            nums.Sort();
            var pos = 0;
            while (pos < nums.Count)
            {

                int num = nums[pos], count = 1, sum = 0;
                while (pos + count < nums.Count &&
                    nums[pos + count] == num)
                {
                    count++;
                }
                sum = sum + num * count;
                pos = pos + count;
                Console.WriteLine($"{sum}");
            }
        }
    }
}
