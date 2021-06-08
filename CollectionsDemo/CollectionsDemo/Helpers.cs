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
      var trimmed = index > 0 ? name.Substring(0, index) : name;
      var reduced = Regex.Replace(trimmed, @"[^a-zA-Z\.]", string.Empty);
      var final = reduced + ((name.Contains("[") && name.Contains("]")) ? "[]" : "");

      return final;
    }

    private static void Output(IEnumerable<int> collection)
    {
      Console.WriteLine(GetName(collection) + " :\n");

      foreach (var item in collection)
      {
        Console.WriteLine(item);
      }
      Console.Write("\n\n");
    }
  }
}