using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Append_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lists = Console.ReadLine().Trim().Split('|').Reverse().ToArray();

            List<string> result = new List<string>();
            foreach (var item in lists)
            {
                item.Trim();
                result.Add(item);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
