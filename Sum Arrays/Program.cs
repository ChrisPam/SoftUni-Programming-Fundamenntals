using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstRow = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            int[] secondRow = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

            List<int> results = new List<int>();
            var lenght = Math.Max(firstRow.Length, secondRow.Length);
            
            for (int i = 0; i < lenght; i++)
            {
                int firstNumber = firstRow[i % firstRow.Length];
                int secondNumber = secondRow[i % secondRow.Length];
                int sumOfTwoNumbers = firstNumber + secondNumber;
                results.Add(sumOfTwoNumbers);
            }
            foreach (var result in results)
            {
                Console.Write(result + " ");
            }
        }
    }
}
