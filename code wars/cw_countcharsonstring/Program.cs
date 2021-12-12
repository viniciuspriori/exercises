using System;
using System.Collections.Generic;

namespace cw_countcharsonstring
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> t = Kata.Count("ababbacab");

            foreach (var item in t)
            {
                System.Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
