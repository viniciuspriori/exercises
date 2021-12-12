using System;
using System.Collections.Generic;
using System.Linq;

public class Xbonacci
{
  public double[] Tribonacci(double[] signature, int n)
  {
    var a = signature[0];
    var b = signature[1];
    var c = signature[2];
    
    var f = new List<double>();
    int count = 0;

    if(n==0) return f.ToArray();

        while(count<n)
        {
          if(count<3){
              f.Add(signature[count]);
          } else{
            f.Add(a+b+c);
            a=b;
            b=c;
            c=f.Last();
          }
          count++;
        }
    return f.ToArray();
  }
}