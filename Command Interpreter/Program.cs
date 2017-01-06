using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            string[] command = Console.ReadLine().Split();
            while (!command[0].Equals("end"))
            {
                if (command[0] == "reverse")
                {
                    ReverseString(input, command);

                }
                else if (command[0] == "sort")
                {
                    SortString(input, command);
                }
                else if (command[0] == "rollLeft")
                {
                    RollLeft(input, command);
                }
                else if (command[0] == "rollRight")
                {
                    RollRight(input, command);
                }
                else
                {
                    Console.WriteLine("Invalid input parameters");
                }

                command = Console.ReadLine().Split().ToArray();
            }
            Console.WriteLine("[" + string.Join(", ", input) + "]");
        }

        private static void RollRight(List<string> input, string[] command)
        {
            int count = int.Parse(command[1]);
            if (count < 0)
            {
                Console.WriteLine("Invalid input parameters.");
                Console.WriteLine("[" + string.Join(", ", input) + "]");
                return;
            }
            for (int i = 0; i < (count % input.Count); i++)
            {
                string element = input[input.Count - 1];

                input.RemoveAt(input.Count - 1);
                input.Insert(0, element);
            }
        }

        private static void RollLeft(List<string> input, string[] command)
        {
            int count = int.Parse(command[1]);
            if (count < 0)
            {
                Console.WriteLine("Invalid input parameters.");
                return;
            }
            for (int i = 0; i < (count % input.Count); i++)
            {
                string element = input[0];
                input.RemoveAt(0);
                input.Add(element);
            }
        }

        private static void SortString(List<string> input, string[] command)
        {
            int start = int.Parse(command[2]);
            int count = int.Parse(command[4]);
            if (start < 0 || start >= input.Count || (start + count) > input.Count || count < 0)
            {
                Console.WriteLine("Invalid input parameters.");
                return;
            }
            List<string> currList = input.Skip(start).Take(count).OrderBy(x => x).ToList();
            input.RemoveRange(start, count);
            input.InsertRange(start, currList);
        }

        private static void ReverseString(List<string> input, string[] command)
        {
            int start = int.Parse(command[2]);
            int count = int.Parse(command[4]);
            if (start < 0 || start >= input.Count || (start + count) > input.Count || count < 0)
            {
                Console.WriteLine("Invalid input parameters.");
                return;

            }
            List<string> currList = input.Skip(start)
                                        .Take(count)
                                        .Reverse()
                                        .ToList();
            input.RemoveRange(start, count);
            input.InsertRange(start, currList);
        }
    }
}
