using System;
using System.Linq;
using System.Collections.Generic;
public static class Kata
{
    public static int GetVowelCount(string str)
    {   
        List<char> LVowels = new List<char> {'a', 'e', 'i', 'o', 'u'};
        int vowelCount = 0;

        List<char> LChars = str.ToList();

        foreach (var item in LChars)
        {   
            foreach (var item2 in LVowels)
            {
                if(item == item2)
                {
                    vowelCount++;
                }
            }   
        }
        return vowelCount;
    }
}