using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string events = Console.ReadLine();
            while (events != "Time for Code")
            {
                Regex regex = new Regex(@"(?:@)(\w+)");
                MatchCollection peoples = regex.Matches(events);
                List<string> listOfPeoples = new List<string>();
                foreach (Match people in peoples)
                {
                    
                }
            }

        }
    }
}
