using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Сръбско_Unleashed
{
    class Program
    {
        static void Main(string[] args)
        {
            var concert = Console.ReadLine();
            var placeWithSinger = new Dictionary<string, Dictionary<string, int>>();
            while (concert != "End")
            {
                Regex regex = new Regex(@"(\D+)\s@(\D+)\s(\d+)\s(\d+)");
                MatchCollection matches = regex.Matches(concert);
                if (matches.Count == 0) { }
                else
                {
                    Match match = regex.Match(concert);
                    var singer = match.Groups[1].ToString().Trim();
                    var place = match.Groups[2].ToString().Trim();
                    var ticketPriceGroup = match.Groups[3].ToString().Trim();
                    var moneyEarnedGroup = match.Groups[4].ToString().Trim();
                    var ticketPrice = int.Parse(ticketPriceGroup);
                    var moneyEarnedFromConcert = int.Parse(moneyEarnedGroup);
                    var totalMoney = ticketPrice * moneyEarnedFromConcert;
                    if (placeWithSinger.ContainsKey(place))
                    {
                        if (placeWithSinger[place].ContainsKey(singer))
                        {
                            placeWithSinger[place][singer] += totalMoney;
                        }
                        else
                        {
                            placeWithSinger[place].Add(singer, totalMoney); //Сометимес уин, сометимес люн :D :D  
                        }
                    }
                    else
                    {
                        placeWithSinger.Add(place, new Dictionary<string, int>());
                        placeWithSinger[place].Add(singer, totalMoney);
                    }
                }
                concert = Console.ReadLine();
            }

            foreach (var place in placeWithSinger)
            {
                Console.WriteLine(place.Key);
                foreach (var item in place.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {item.Key} -> {item.Value}");
                }
            }
        }
    }
}
