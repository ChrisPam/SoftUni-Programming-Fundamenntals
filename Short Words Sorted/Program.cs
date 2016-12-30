using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Short_Words_Sorted
{
    class Program
    {
        static void Main(string[] args)
        {
            var separators = new char[] {'.',',',':',';','(',')','[',']','"','\'','/','!','?',' '};
            var nums = Console.ReadLine()
                .ToLower()
                .Split(separators, StringSplitOptions.RemoveEmptyEntries)
                .Where(num => num.Length < 5)
                .OrderBy(num => num)
                .Distinct();
            Console.WriteLine(string.Join(", ", nums));
        }
    }
}
