using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = new char[] { ',', ' ' };
            string[] words = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string text = Console.ReadLine();

            foreach (var word in words)
            {
                var stars = new string('*', word.Length);
                text = text.Replace(word, stars);
            }
            Console.WriteLine(text);
        }
    }
}
