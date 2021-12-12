using System;

namespace cw_fibonnaciproduct
{
    class Program
    {        
        static void Main(string[] args)
        {
            var x = Solution.productFib(123);

            foreach (var item in x)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
