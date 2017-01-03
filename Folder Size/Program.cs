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
            string[] files = Directory.GetFiles("TestFolder");
            double sum = 0;
            foreach (var file in files)
            {
                FileInfo fInfo = new FileInfo(file);
                sum += fInfo.Length;
            }
            sum = sum / 1024 / 1024;
            File.WriteAllText("output.txt", sum.ToString());
        }
    }
}
