using System;
using System.IO;
using System.Linq;

namespace advent1
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = File.ReadAllLines("txt.txt").Select(Int32.Parse).Sum();
            Console.WriteLine(input);
        }
    }
}
