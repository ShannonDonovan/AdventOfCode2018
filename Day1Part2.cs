using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace advent1
{
    class Program
    {
        static void Main(string[] args)
        {
            var flag = false;
            var count = 0;
            var input = File.ReadAllLines("txt.txt").Select(Int32.Parse);
            Dictionary<int, int> dict = new Dictionary<int, int>();
            while (flag == false)
            {
                foreach (var line in input)
                {
                    count += line;
                    if (!dict.ContainsKey(count))
                    {
                        dict.Add(count, count);
                    }
                    else
                    {
                        flag = true;
                        Console.WriteLine("got here");
                        break;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
