using System.Collections.Generic;

namespace CollectionsDemo
{
  internal partial class Program
  {
    private static void Demo_Dictionary()
    {
      var dictionary = new Dictionary<string, int>();

      dictionary.Add("J", 30);
      dictionary.Add("9", 20);
      dictionary.Add("A", 11);
      dictionary.Add("10",10);
      dictionary.Add("K", 3);
      dictionary.Add("Q", 2);

      //dictionary.Add("Q", 25);
      //dictionary.Add("X", 2);

      Print(dictionary);
    }
  }
}