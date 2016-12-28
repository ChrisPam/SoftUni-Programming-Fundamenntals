using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw_a_Filled_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintEndLine(n);
            PrintBody(n);
            PrintEndLine(n);
        }
        static void PrintEndLine(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }
        static void PrintBody(int n)
        {
            for (int j = 0; j < n-2; j++)
            {
            Console.Write("-");
            for (int i = 1; i < n; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine("-");
            }
        }
    }
}
