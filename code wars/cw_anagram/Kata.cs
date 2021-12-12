using System;
using System.Collections.Generic;
using System.Linq;

public static class Kata
{
  public static List<string> Anagrams(string word, List<string> words)
  {
    var anagrams = new List<string>();

    foreach (var item in words)
    {
        var orderedWord = item.OrderBy(x => x);
        var result = orderedWord.SequenceEqual(word.OrderBy(x => x));
        if(result) anagrams.Add(item);
    }       
        return anagrams;    
  }
}