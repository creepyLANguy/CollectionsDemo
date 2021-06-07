using System.Linq;

namespace CollectionsDemo
{
  internal partial class Program
  {
    private static void Demo_Array()
    {
      //var array = new int[] {1, 2, 3, 4, 5};  

      var array = new int[5];

      for (var i = 0; i < 5; ++i) //6?
      {
        array[i] = i + 1;
      }

      //array.

      Print(array.Reverse());

      Print(array);
    }
  }
}