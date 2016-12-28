using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            isPrime(n);
            
        }
        static void isPrime(int n)
        {
            if (n % 2 == 0)
            {
                Console.WriteLine("True");
            }
            else if(n == 0)
            {
                Console.WriteLine("False");
            }
            else if(n % 2 != 0)
            {
                Console.WriteLine("False");
            }
        }
    }
}
