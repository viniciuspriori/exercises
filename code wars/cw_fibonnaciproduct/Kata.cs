using System;
using System.Collections.Generic;
using System.Linq;

public class ProdFib {
      public static ulong[] productFib(ulong prod) {

          ulong[] fibo = GenerateFibonacciArray(prod);
          int i = 0;
          
          for (i = 0; i < fibo.Length-1; i++)
          {
              if(fibo[i] * fibo[i+1] == prod) return new ulong[] {fibo[i], fibo[i+1], 1};

              if(fibo[i] * fibo[i+1] > prod) break;
          } 
          return new ulong[] {fibo[i], fibo[i+1], 0};
      }

      private static ulong[] GenerateFibonacciArray(ulong num)
      {
        ulong first = 0, next = 1;
        List<ulong> fibo = new List<ulong> {first, next};
        ulong toAdd;

            while(first+next<=num) {   
                toAdd = first + next;             
                fibo.Add(toAdd);
                first = next;
                next = toAdd;
            }         
            return fibo.ToArray();
      }
}