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

      //stack.Pop(); //Remember, exception when popping an empty stack, just like trying to reference an element in an index of an array that does not exist.
      //stack.Peek();

      Print(stack);
    }
  }
}