using System.Collections.Generic;

namespace CollectionsDemo
{
  internal partial class Program
  {
    private static void Demo_Stack()
    {
      var list = new Stack<int>();

      list.Push(1);
      list.Push(2);
      list.Push(3);
      list.Push(4);
      list.Push(5);

      Print(list);
    }
  }
}