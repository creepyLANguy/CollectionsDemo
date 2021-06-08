using System.Collections.Generic;

namespace CollectionsDemo
{
  internal partial class Program
  {
    private static void Demo_HashSet()
    {
      var set = new HashSet<int>();

      set.Add(30);
      set.Add(20);
      set.Add(11);
      set.Add(10);
      set.Add(3);
      set.Add(2);

      Print(set);
    }
  }
}