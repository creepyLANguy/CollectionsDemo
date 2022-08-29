using System.Collections.Generic;
using System.Linq;

namespace CollectionsDemo
{
  internal partial class Program
  {
    private static void Demo_HashSet()
    {
      var set = new HashSet<int>();

      set.Add(30);
      set.Add(11);
      set.Add(20);
      set.Add(10);
      set.Add(7);
      set.Add(53);

      //set.Add(20);

      //set.TryGetValue(10 /*999*/, out var searchResult);
      //Print("searchResult = " + searchResult);

      Print(set);
    }
  }
}