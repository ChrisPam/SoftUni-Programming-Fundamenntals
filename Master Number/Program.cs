﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());

            for (int i = 0; i < range; i++)
            {
                if(IsPalindrome(i) && SumOfDigits(i) && ContainsEvenDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool ContainsEvenDigit(int i)
        {
            
            while (i != 0)
            {
                if((i % 10) % 2 == 0)
                {
                    return true;
                }
                i /= 10;
            }
            return false;
        }

        private static bool SumOfDigits(int i)
        {
            int sum = 0;
            while (i != 0)
            {
                sum += i % 10;
                i /= 10;
            }
            if(sum % 7 == 0)
            {
                return true;
            }
            return false;
        }

        private static bool IsPalindrome(int i)
        {
            int n = i;
            int rev = 0;
            while (i > 0)
            {
                int dig = i % 10;
                rev = rev * 10 + dig;
                i = i / 10;
            }
            if(n == rev)
            {
                return true;
            }
            return false;
        }
    }
}
