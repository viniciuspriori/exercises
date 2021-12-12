using System;

namespace ex_anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World");

                var candidates = new[] { "Bolsonaor"};
                var sut = new Anagram("BOLSONARO");
                sut.FindAnagrams(candidates);

                sut.print();
        
        }
    }
}
