using System;
using System.Collections.Generic;
using System.Linq;

public static class Kata
{
  public static int DescendingOrder(int num)
  {
      var strNum = num.ToString();

      List<int> intList = strNum.Select(x => int.Parse(x.ToString())).ToList();
  
      List<int> reorder = new List<int>();

        foreach (var item in intList)
        {
            reorder = intList.OrderByDescending(x => x).ToList();
        }

        String res = String.Empty;

        foreach (var item in reorder)
        {   
           res += item;
        }

    return Convert.ToInt32(res);
  }
}
