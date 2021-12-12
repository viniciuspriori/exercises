using System;

namespace cw_camelcase
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "the-stealth-warrior";
            Kata.ToCamelCase(str);

            System.Console.WriteLine(Solution.ToCamelCase(str)); 
            
        }
    }
}
