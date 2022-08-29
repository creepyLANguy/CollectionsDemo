using System.Collections.Generic;

namespace CollectionsDemo
{
  internal partial class Program
  {
    private static void Demo_Queue()
    {
      var queue = new Queue<int>();

      queue.Enqueue(1);
      queue.Enqueue(2);
      queue.Enqueue(3);
      queue.Enqueue(4);
      queue.Enqueue(5);
      
      //queue.

      Print(queue);
     }
  }
}