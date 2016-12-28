using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable_in_Hex_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            string hexdec = Console.ReadLine();
            decimal convertedToDecimal = Convert.ToInt32(hexdec, 16);

            Console.WriteLine(convertedToDecimal);
        }
    }
}
