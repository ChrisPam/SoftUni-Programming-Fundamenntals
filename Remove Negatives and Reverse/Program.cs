using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(n => double.Parse(n)).ToArray();
            List<double> nums = new List<double>();
            foreach (var num in input)
            {
                if(num >= 0)
                {
                    nums.Add(num);
                }
            }
            nums.Reverse();
            if(nums.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", nums));
            }
        }
    }
}
