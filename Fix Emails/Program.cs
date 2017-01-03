﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();
            string name = Console.ReadLine();
            string[] domains = { ".us", ".uk" };
            while (!name.Equals("stop"))
            {
                string email = Console.ReadLine();
                phonebook.Add(name, email);
                name = Console.ReadLine();
            }
            RemoveEmailsByDomain(phonebook, domains);
            foreach (var item in phonebook)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }

        private static void RemoveEmailsByDomain(Dictionary<string, string> phonebook, string[] domains)
        {
            foreach (var domain in domains)
            {
                var filtredEmails = phonebook.Where(x => x.Value.EndsWith(domain)).ToList();
                foreach (var userEntry in filtredEmails)
                {
                    phonebook.Remove(userEntry.Key);
                }
            }
        }
    }
}
