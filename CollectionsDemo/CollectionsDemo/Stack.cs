using System.Collections.Generic;

namespace CollectionsDemo
{
  internal partial class Program
  {
    private static void Demo_Stack()
    {
      var stack = new Stack<int>();

      stack.Push(1);
      stack.Push(2);
      stack.Push(3);
      stack.Push(4);
      stack.Push(5);

      Print(stack);
    }
  }
}