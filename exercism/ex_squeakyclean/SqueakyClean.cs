using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        string clear;
        clear = identifier.Replace(' ', '_');
        
        clear = Regex.Replace(clear, @"\p{Cs}", ""); //remove emojis
        clear = Regex.Replace(clear, @"[α-ω]", ""); //remove lowercase greek letters

        for (int item = 0; item < clear.Length; item++)   
        {
            
            if(Char.IsControl(clear[item])) clear = clear.Replace(clear[item].ToString(), "CTRL");
            if(Char.IsDigit(clear[item])) clear = clear.Remove(clear.IndexOf(clear[item]), 1);

            if(clear[item] == '-')
            {
                clear = clear
                .Remove(clear.IndexOf(clear[item]), 1)
                .Replace(clear[item+1], Char.ToUpper(clear[item+1]));              
            }
        }         
        System.Console.WriteLine(clear);

        return clear;
    }
}