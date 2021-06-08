using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CollectionsDemo
{
  internal partial class Program
  {
    private static void Print(object o)
    {
      Console.WriteLine("\n"+o.ToString());
    }

    private static void Print(IEnumerable<int> collection)
    {
      Console.WriteLine(GetName(collection));
      foreach (var item in collection)
      {
        Console.Write("[ " + item + " ]");
      }
      Console.Write("\n\n");
    }

    private static void Print<T,U>(Dictionary<T, U> collection)
    {
      Console.WriteLine(GetName(collection));
      foreach (var item in collection)
      {
        Console.Write("[ " + item.Key + ", " + item.Value + " ]");
      }
      Console.Write("\n\n");
    }

    private static string GetName(object o)
    {
      var name = o.GetType().Name;

      var index = name.IndexOf(">", StringComparison.Ordinal);
      name = index > 0 ? name.Substring(0, index) : name;
      
      name = Regex.Replace(name, @"[^a-zA-Z\.]", string.Empty);

      name += (name.Contains("[") && name.Contains("]")) ? "[]" : "";

      return name;
    }
  }
}