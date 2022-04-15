using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw_MovingZeroes
{
    public class Kata
    {
        public static int[] MoveZeroes(int[] arr)
        {
            var list = new List<int>();
            list = arr.ToList();
            var zeros = new List<int>();

            while(list.Contains(0))
            {
               list.Remove(0);
               zeros.Add(0);
            }

            var res = list.Concat(zeros).ToList().ToArray();

            return res;
        }


    }
}
