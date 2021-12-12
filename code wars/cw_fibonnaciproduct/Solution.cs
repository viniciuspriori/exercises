public class Solution 
     {
          public static ulong[] productFib(ulong prod)
          {
              ulong a = 0, b = 1;
              while (a*b < prod)
              {
                  b = a + b;
                  a = b - a;
                  if(a*b==prod)
                      return new ulong[] { a, b, 1 };
              }
              return new ulong[] { a, b, 0 };
          }
    }