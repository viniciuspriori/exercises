using System;
public static class JadenCase
{
  public static string ToJadenCase(this string phrase)
  {
      string[] words = phrase.Split(' ');
      string res = "";

      foreach (var word in words)
      {
          char c = char.ToUpper(word[0]);
          res += c + word.Substring(1) + " ";
      }
      res=res.TrimEnd();
      Console.WriteLine(res);
    return res;
  }
}