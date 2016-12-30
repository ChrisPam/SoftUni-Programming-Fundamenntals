﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            string[] words = input.Split(' ');

            var counts = new Dictionary<string, int>();
            foreach (var word in words)
            {
                if (counts.ContainsKey(word))
                {
                    counts[word]++;
                }
                else
                {
                    counts[word] = 1;
                }
            }
            var list = new List<string>();
            foreach (var pair in counts)
            {
                if(pair.Value % 2 != 0)
                {
                    list.Add(pair.Key);
                }
            }
            Console.WriteLine(string.Join(", ", list));
        }
    }
}
