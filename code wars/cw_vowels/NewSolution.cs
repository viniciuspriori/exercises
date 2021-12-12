using System;
using System.Linq;
using System.Collections.Generic;
public static class NewSolution
{
    public static int GetVowelCount2(string str)
    {  
        return str.Count(x => "aeiou".Contains(x));
    }
}