﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine()
                .Split()
                .Select(number => double.Parse(number))
                .OrderByDescending(number => number)
                .Take(3)
                .ToArray();
                Console.WriteLine(string.Join(" ", nums));
        }
    }
}
