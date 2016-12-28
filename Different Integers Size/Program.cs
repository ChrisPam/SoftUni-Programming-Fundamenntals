using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Different_Integers_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            long l;

            if(long.TryParse((input), out l))
            {
                Console.WriteLine($"{input} can fit in: ");
                sbyte s;
                byte b;
                short sh;
                ushort ush;
                int i;
                uint ui;
                if (sbyte.TryParse((input), out s)) { Console.WriteLine("* sbyte"); }
                if (byte.TryParse((input), out b)) { Console.WriteLine("* byte"); }
                if(short.TryParse((input), out sh)) { Console.WriteLine("* short"); }
                if (ushort.TryParse((input), out ush)) { Console.WriteLine("* ushort"); }
                if (int.TryParse((input), out i)) { Console.WriteLine("* int"); }
                if (uint.TryParse((input), out ui)) { Console.WriteLine("* uint"); }
                Console.WriteLine("* long");
            }
            else
            {
                Console.WriteLine($"{input} can't fit in any type");
            }
        }
    }
}
