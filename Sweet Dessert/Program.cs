using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Sweet_Dessert
{
    class Program
    {
        static void Main()
        {
            var cash = double.Parse(Console.ReadLine());
            var guests = long.Parse(Console.ReadLine());
            var bananasPrice = double.Parse(Console.ReadLine());
            var eggsPrice = double.Parse(Console.ReadLine());
            var berriesPriceForKilo = double.Parse(Console.ReadLine());

            double set = (int) Math.Ceiling(guests / 6.0);
            double cost= set * (2 * bananasPrice) + set * (4 * eggsPrice) + set * (0.2 * berriesPriceForKilo);

            if (cost <= cash)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {cost:F2}lv.");
            }
            else
            {
                var neededMoney = cost - cash;
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {neededMoney:F2}lv more.");
            }
            
        }
    }
}
