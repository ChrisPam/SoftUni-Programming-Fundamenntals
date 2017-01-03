using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());

            BigInteger factorial = 1;
            for (int i = 1; i <= range; i++)
            {
                factorial = factorial * i;
            }
            
            Console.WriteLine(CountZeroInFactorial(factorial));
        }

        private static int CountZeroInFactorial(BigInteger factorial)
        {
            int count = 0;
            BigInteger last = factorial % 10;
            while (last == 0)
            {
                count++;
                factorial /= 10;
                last = factorial % 10;
            }
            return count;
        }
    }
}
