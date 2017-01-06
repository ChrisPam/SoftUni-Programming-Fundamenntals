using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Football_League
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input != "Over!")
            {
                Regex regex = new Regex(@"^([0-9]+)*([a-zA-Z]+)([0-9]+)*\n");
                Match match = regex.Match(input);
                var firstDigits = match.Groups[1].ToString();
                var word = match.Groups[2].ToString();
                var secondtDigits = match.Groups[3].ToString();

                foreach (var letter in word)
                {
                    
                }
            }
        }
    }
}
