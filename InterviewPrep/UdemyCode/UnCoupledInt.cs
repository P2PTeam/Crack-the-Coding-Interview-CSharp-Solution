using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.UdemyCode
{
  class UnCoupledInt
  {
    static void NotMain(string[] args)
    {
      var arr = new int[] { 2, 7, 2, 8, 5, 1, 1, 7, 8 };
      int result = FindUncoupledIntSet(arr);
      Console.WriteLine("The result: " + result.ToString());
      Console.Read();
    }

    // XOR
    public static int FindUncoupledInt1(int[] arr)
    {
      if (arr == null || arr.Length == 0)
      {
        throw new Exception("The input is invalid.");
      }

      int result = 0;
      int len = arr.Length;
      for (int i = 0; i < len; i++)
      {
        result ^= arr[i];
      }

      return result;
    }

    //use hasetable
    public static int FindUncoupledIntSet(int[] arr)
    {
      int result = 0;
      var hset = new HashSet<int>();

      foreach (int item in arr)
      {
        if (hset.Contains(item))
        {
          hset.Remove(item);
        }
        else
        {
          hset.Add(item);
        }
      }

      result = hset.First<int>();

      return result;
    }

  }
}
