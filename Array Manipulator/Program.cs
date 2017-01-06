using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(x => int.Parse(x)).ToList();

            string command = Console.ReadLine();
            while (!command.Equals("end"))
            {
                string[] commands = command.Split().ToArray();
                switch (commands[0])
                {
                    case "exchange":

                        int pos = int.Parse(commands[1]);
                        if (pos >= input.Count)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            List<int> firstPart = input.Take(pos + 1).ToList();  //сометимес уин, сометимес люн
                            input.RemoveRange(0, pos + 1);
                            input.AddRange(firstPart);
                        }


                        break;
                    case "max":
                        if (commands[1] == "even")
                        {
                            var where = (input.Where(x => x % 2 == 0));
                            if (!where.Any())
                            {
                                Console.WriteLine("No matches");
                            }
                            else
                            {
                                var result = input.LastIndexOf(where.Max());
                                Console.WriteLine(result);
                            }
                        }
                        else
                        {
                            var where = (input.Where(x => x % 2 == 1));
                            if (!where.Any())
                            {
                                Console.WriteLine("No matches");
                            }
                            else
                            {
                                var result = input.LastIndexOf(where.Max());
                                Console.WriteLine(result);
                            }

                        }
                        break;
                    case "min":
                        if (commands[1] == "even")
                        {
                            var where = (input.Where(x => x % 2 == 0));
                            if (!where.Any())
                            {
                                Console.WriteLine("No matches");
                            }
                            else
                            {
                                var result = input.LastIndexOf(where.Max());
                                Console.WriteLine(result);
                            }
                        }
                        else
                        {
                            var where = (input.Where(x => x % 2 == 1));
                            if (!where.Any())
                            {
                                Console.WriteLine("No matches");
                            }
                            else
                            {
                                var result = input.LastIndexOf(where.Max());
                                Console.WriteLine(result);
                            }
                        }
                        break;
                    case "first":
                        if (commands[2] == "even")
                        {
                            var where = input.Where(x => x % 2 == 0);
                            if (!where.Any())
                            {
                                Console.WriteLine("[]");
                            }
                            else
                            {
                                int count = int.Parse(commands[1]);
                                if (count > input.Count)
                                {
                                    Console.WriteLine("Invalid count");
                                }
                                else
                                {
                                    List<int> idk = input.Take(count).Where(x => x % 2 == 0).ToList();
                                    //сометимес уин, сометимес люн
                                    Console.WriteLine("[" + string.Join(", ", idk) + "]");
                                }

                            }
                        }
                        else
                        {
                            var where = input.Where(x => x % 2 == 1);

                            if (!where.Any())
                            {
                                Console.WriteLine("[]");
                            }
                            else
                            {
                                int count = int.Parse(commands[1]);
                                if (count > input.Count)
                                {
                                    Console.WriteLine("Invalid count");
                                }
                                else
                                {
                                    List<int> idk = input.Take(count).Where(x => x % 2 == 1).ToList();
                                    //сометимес уин, сометимес люн
                                    Console.WriteLine("[" + string.Join(", ", idk) + "]");
                                }
                            }
                        }
                        break;
                    case "last":
                        if (commands[2] == "even")
                        {
                            var where = input.Where(x => x % 2 == 0);
                            if (!where.Any())
                            {
                                Console.WriteLine("[]");
                            }
                            else
                            {
                                int count = int.Parse(commands[1]);
                                if (count > input.Count)
                                {
                                    Console.WriteLine("Invalid count");
                                }
                                else
                                {
                                    List<int> idk = input.Take(count).Where(x => x % 2 == 0).ToList();
                                    //сометимес уин, сометимес люн
                                    Console.WriteLine("[" + string.Join(", ", idk) + "]");
                                }
                            }
                        }
                        else
                        {
                            var where = input.Where(x => x % 2 == 1);
                            if (!where.Any())
                            {
                                Console.WriteLine("[]");
                            }
                            else
                            {
                                int count = int.Parse(commands[1]);
                                if (count > input.Count)
                                {
                                    Console.WriteLine("Invalid count");
                                }
                                else
                                {
                                    List<int> idk = input.Take(count).Where(x => x % 2 == 1).ToList();
                                    //сометимес уин, сометимес люн
                                    Console.WriteLine("[" + string.Join(", ", idk) + "]");
                                }
                            }
                        }
                        break;
                    default:
                        break;
                }

                command = Console.ReadLine();
            }
            Console.WriteLine("[" + string.Join(", ", input) + "]");
        }
    }
}
