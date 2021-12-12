using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace cw_listfilter
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<object>(){1, 2, "a", "b", 3, "324"};

           IEnumerable<int> res = ListFilterer.GetIntegersFromList(list);

            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
           
        }
    }
}
