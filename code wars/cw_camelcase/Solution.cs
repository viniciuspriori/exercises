using System;
using System.Text.RegularExpressions;

public class Solution
{
  public static string ToCamelCase(string str)
  {
    return Regex.Replace(str, @"[_-](\w)", m => m.Groups[0].Value.ToUpper());
  }
}