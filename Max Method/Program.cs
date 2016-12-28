using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2= int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            GetMax(n1, n2, n3);
        }
        static void GetMax(int n1, int n2, int n3)
        {
            int firstcheck = Math.Max(n1, n2);
            int secondcheck = Math.Max(firstcheck, n3);
            Console.WriteLine(secondcheck);
        }
    }
}
