using System;
using System.Collections.Generic;

namespace cw_anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = new List<string>() {"a", "b", "c", "d"};
            
            var result = Kata.Anagrams("e", words);
        }
    }
}
