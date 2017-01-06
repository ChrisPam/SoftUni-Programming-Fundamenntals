using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni_Coffee_Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            decimal totalPrice = 0;
            for (int i = 0; i < n; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                DateTime date = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                long capsulesCount = long.Parse(Console.ReadLine());
                var year = date.Year;
                var month = date.Month;
                var daysInMonth = DateTime.DaysInMonth(year, month);
                decimal orderPrice = ((daysInMonth * capsulesCount) * pricePerCapsule);

                totalPrice += orderPrice;
                Console.WriteLine("The price for the coffee is: ${0:F2}", orderPrice);
            }
            Console.WriteLine("Total: ${0:F2}", totalPrice);
        }
    }
}
