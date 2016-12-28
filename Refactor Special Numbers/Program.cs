using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int howMuch = int.Parse(Console.ReadLine());
            int sum = 0; int such = 0; bool special = false;
            for (int i = 1; i <= howMuch; i++)
            {
                such = i;
                while (i > 0)
                {
                    sum += i % 10;
                    i = i / 10;
                }
                special = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{such} -> {special}");
                sum = 0; i = such;
            }
        }
    }
}
