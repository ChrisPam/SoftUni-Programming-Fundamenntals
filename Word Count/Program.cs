using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = File.ReadAllText("text.txt").ToLower().Split(new char[] { ' ', ',', '-', '!', '?', '.' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string[] words = File.ReadAllText("words.txt").ToLower().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            foreach (var word in words)
            {
                wordCount[word] = 0;
            }
            foreach (var word in text)
            {
                if (wordCount.ContainsKey(word))
                    wordCount[word]++;
            }
            wordCount = wordCount.OrderByDescending(w => w.Value).ToDictionary(x => x.Key, x => x.Value);
            File.WriteAllText("results.txt", "");
            foreach (KeyValuePair<string, int> pair in wordCount)
            {
                //Console.WriteLine($"{pair.Key} - {pair.Value}");
                File.AppendAllText("results.txt", $"{pair.Key} - {pair.Value}\r\n");
            }
        }
    }
}
