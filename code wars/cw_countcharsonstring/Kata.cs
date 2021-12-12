using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
  public static Dictionary<char, int> Count(string str)
  {
    Dictionary<char, int> d = new Dictionary<char, int>();
    char[] a = GetCharArr(str);
    int i=0;

    foreach (var item in a)
    {
        if(!d.ContainsKey(item)) {
            d.Add(item, i);
        }
        d[item] += 1;        
    }

    return d;
  }
  public static char[] GetCharArr(string str) => str.ToCharArray();
}