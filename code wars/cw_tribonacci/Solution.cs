using System.Linq;
using System.Collections.Generic;

public class Zbonacci
{
  public double[] Tribonacci(double[] signature, int n)
  {
    if (n == 0) {
      return new double[] { 0 };
    }
    
    var result = new double[n];
    for (var i = 0; i < n; i++) {
      result[i] = i < 3
        ? signature[i]
        : result.Skip(i - 3).Take(3).Sum();
    }
    return result;
  }

    public double[] Tribonacci2(double[] signature, int n)
  {
    var seq = new List<double>(signature);
    
    for (var i = 3; i < n; i++)
    {
      seq.Add(seq[i - 1] + seq[i - 2] + seq[i - 3]);
    }
    
    return seq.Take(n).ToArray();
  }
}