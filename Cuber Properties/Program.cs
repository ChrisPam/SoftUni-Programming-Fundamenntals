using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuber_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal cubeSide = decimal.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();

            Console.WriteLine("{0:F2}", GetCubeResult(cubeSide, parameter));
        }

        private static double GetCubeResult(decimal cubeSide, string parameter)
        {
            if (parameter == "volume")
            {
                return Math.Pow((double)cubeSide, 3);
            }
            else if(parameter == "area")
            {
                return 6 * Math.Pow((double)cubeSide, 2);
            }
            else if(parameter == "face")
            {
                return Math.Sqrt(2 * Math.Pow((double)cubeSide, 2));
            }
            else if(parameter == "space")
            {
                return Math.Sqrt(3 * Math.Pow((double)cubeSide, 2));
            }
            return 0;
        }
    }
}
