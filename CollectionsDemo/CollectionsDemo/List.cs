using System.Collections.Generic;

namespace CollectionsDemo
{
  internal partial class Program
  {
    private static void Demo_List()
    {
      var list = new List<int>();

      list.Add(1);
      list.Add(2);
      list.Add(3);
      list.Add(4);
      list.Add(5);

      Print(list);
    }
  }
}