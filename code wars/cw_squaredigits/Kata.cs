using System;
using System.Linq;
using System.Collections.Generic;

public class Kata
{
  public static int SquareDigits(int n)
  {     
    string q = n.ToString();
    List<int> l = q.Select(x => int.Parse(x.ToString())).ToList(); 

    String res = String.Empty; 
    l =  l.Select(x => x*x).ToList();

    foreach (var item in l)
    {
        res += item;
    }

    return int.Parse(res);
  }
}