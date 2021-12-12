using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class ListFilterer
{
   public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
   {
      return listOfItems.Where(x => x is int)
                        .Select(x => (int)x);
   }
}