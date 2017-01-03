using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serbian
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split();
            Dictionary<string, string> placeWithSinger = new Dictionary<string, string>();

            while (!line.Equals("End"))
            {
                var priceTicket = line.Reverse().Take(2);
                var tickectCount = line.First();
                placeWithSinger[priceTicket] = tickectCount;

                line = Console.ReadLine().Split();
            }
            Console.WriteLine();
        }
    }
}
