﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rounding_Numbers_Away_from_Zero
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(' ').Select(x => double.Parse(x)).ToArray();

            foreach (var number in numbers)
            {
                Console.WriteLine($"{number} => {Math.Round(number, MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
