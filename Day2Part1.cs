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
            var input = File.ReadAllLines("txt.txt").Select(l => l.ToCharArray());
            var num1 = 0;
            var num2 = 0;
            foreach (var line in input)
            {
                Dictionary<char, int> dict = new Dictionary<char, int>();

                foreach (var chr in line)
                {
                    if (dict.ContainsKey(chr))
                    {
                        dict[chr]++;
                    }
                    else
                    {
                        dict.Add(chr, 1);
                    }
                }

                if (dict.ContainsValue(2))
                {
                    num1++;
                }

                if (dict.ContainsValue(3)){
                    num2++;
                }
            }

            Console.WriteLine(num1 * num2);
        }
    }
    
}
