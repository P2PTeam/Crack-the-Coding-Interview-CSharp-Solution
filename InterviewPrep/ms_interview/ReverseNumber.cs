using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.ms_interview
{
  class ReverseNumber
  {
    static void NotMain(string[] args)
    {
      var result=Reverse(int.MinValue);
      Console.WriteLine(string.Format("The min value is: {0}", int.MinValue));
      foreach (var i in result)
      {
        Console.WriteLine(i);
      }

      Console.WriteLine(string.Format("The max value is: {0}", int.MaxValue));
      ReverseInteger2(int.MaxValue);
      var str = ReverSentance("Print int min value");
      Console.WriteLine(str);
      ReverseInteger2(int.MinValue);
      
      //Console.WriteLine(inverse);
      Console.Read();
    }

    private static List<int> Reverse(int n){
      var result = new List<int>();
      int res = 0;
      while (n != 0)
      {
        if (res > int.MaxValue / 10 || res < int.MinValue / 10)
        {
          res = 0;
          result.Clear();
          result.Add(0);
          return result;
        }

        int r = n % 10;
        res = res * 10 + r; 
        result.Add(r);
        n /= 10;
      }

      return result;
    }

    private static int ReverseInteger(int n)
    {
      int result = 0;
      bool flag = false;
      if (n < 0)
      {
        flag = true;
        n = 0 - n;
      }

      while (n > 0)
      {
        if (result > int.MaxValue / 10)
        {
          return 0;
        }

        int r = n % 10;
        Console.WriteLine(r);
        result = result * 10 + n % 10;
        n = n / 10;
      }

      if (flag)
      {
        result = 0 - result;
      }

      return result;
    }

    private static void ReverseInteger2(int n)
    {
      int res = 0;
      while (n != 0)
      {
        if (res > int.MaxValue / 10 || res < int.MinValue / 10)
        {
          Console.WriteLine(0);
        }

        int r = n % 10;
        Console.WriteLine(r);
        res = res * 10 + n % 10;
        n = n / 10;
      }      
    }

    private static string ReverseString(string s)
    {
      
      if (string.IsNullOrWhiteSpace(s))
      {
        return string.Empty;
      }

      var result = string.Empty;
      //result=new string(s.Reverse().ToArray());      
     
      var arr = s.ToCharArray();
      int i = 0, j = arr.Length - 1;
      int end = arr.Length / 2;
      while (i < end)
      {
        var t = arr[i];
        arr[i] = arr[j];
        arr[j] = t;
        i++;
        j--;
      }

      result = new string(arr);
      return result;
    }

    private static string ReverSentance(string s)
    {
      if (string.IsNullOrWhiteSpace(s))
      {
        return string.Empty;
      }

      var result = string.Empty;

      return string.Join(" ", s.Split(' ').Reverse());
    }

  }
}
