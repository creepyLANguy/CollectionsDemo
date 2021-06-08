using System.Collections.Generic;
using System.Linq;

/*
  Given an array with the following input: 
   
  111111
  1111111111
  111111111
  11
  11111
  11111
  1111
  1111111111
  11111111
  1
  1111111111
  1111
  1111111111
  11111111
  11
  11
  1111111111  
  1111111
  111
  
  Print the following output: 
  
  1111111111
  111111111
  11111111
  1111111
  111111
  11111
  1111
  111
  11
  1
   
  You are required to call the Output() function for displaying your final output.

  Constraints: 
   
  - You may not explicitly check the length or value of any input row. 
  - You may not explicitly compare any input rows.
  - You may not modify any of the input rows.
  - You may not populate collections by using indexes. 
  - You must ingest all rows of the input. (Best start with the example class containing the array)
   
  Tips: 
  - Rely on the nature of the collections of the collections we've discussed today and use them to achieve the output, 
    without resorting to traditional methods or manual operations on the data.
  - Think about transforming one collection into another, and into another... 
  - Curiously, you may notice that the input has duplicate rows... 👀
   
  Bonus Points: 
  - Solve using 3 different collections and without calling Reverse() method.
 */

namespace CollectionsDemo
{
  internal partial class Program
  {
    private static readonly int[] input = {
      111111,
      1111111111,
      111111111,
      11,
      11111,
      11111,
      1111,
      1111111111,
      11111111,
      1,
      1111111111,
      1111,
      1111111111,
      11111111,
      11,
      11,
      1111111111,
      1111111,
      111
    };

    private static void Demo_Activity()
    {
      Output(input);

      var set = new HashSet<int>(input);
      Output(set);

      var list = new List<int>(set); //var list = set.ToList();
      list.Sort();
      Output(list);

      var stack = new Stack<int>(list);
      Output(stack);
    }
  }
}