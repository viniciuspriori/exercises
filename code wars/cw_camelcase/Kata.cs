using System;
using System.Linq;
using System.Collections.Generic;

public class Kata
{
  public static string ToCamelCase(string str)
  { 
      char c;
      string res = "";
    
      for (int i = 0; i < str.Length; i++)
      {
          if(str[i] == '-' || str[i] == '_')
          {
            c = char.ToUpper(str[i+1]);
            res += c;
            i++;
          }
         else
         {
            res += str[i];
         }       
      }        
      
    return res;
  }
}