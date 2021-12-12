using System;

namespace cw_subarraysum
{
    class Program
    {
        static void Main(string[] args)
        {           
            //Console.WriteLine(Kata.MaxSequence(new int[]  {-2, 1, -3, 4, -1, 2, 1, -5, 4}));

            int[] res = Kata.MaxSequenceArr(new int[]  {-2, 1, -3, 4, -1, 2, 1, -5, 4});

            foreach (var item in res)
            {
                System.Console.WriteLine(item);
            }

        }
    }
}
