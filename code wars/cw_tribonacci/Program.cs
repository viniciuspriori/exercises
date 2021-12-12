using System;

namespace cw_tribonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            var f = new Zbonacci();

            var res = f.Tribonacci2(new double[] {0, 0, 1}, 2);

            foreach (var item in res)
            {
                Console.Write(item+" ");
            }
            
        }
    }
}
