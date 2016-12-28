using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers_in_Reversed_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            PrintTheDigitsInReversedOrder(n);
        }
        static void PrintTheDigitsInReversedOrder(string a)
        {
            for (int i = a.Length - 1; i >= 0; i--)
            {
                Console.Write(a[i]);
            }
            Console.WriteLine();
        }
    }
}
