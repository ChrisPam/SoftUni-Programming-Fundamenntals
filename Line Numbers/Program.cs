﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] file = File.ReadAllLines("input.txt");

            File.WriteAllText("output.txt", "");

            for (int i = 0; i < file.Length; i++)
            {
                    File.AppendAllText("output.txt", $"{i + 1}. {file[i]}\r\n");
            }
        }
    }
}
