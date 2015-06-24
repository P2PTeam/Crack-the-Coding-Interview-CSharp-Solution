using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.ms_interview
{
  /*
   * String A = “abcdef” and String B= “efghjik” How to get a string Result = “abcdefghjik”
   */
  class ContractTwoStrings
  {
    static void NotMain(string[] args)
    {
      var s1 = "abcdef";
      var s2 = "efghjik";
      var result = MergeWithoutDup2(s1, s2);
      Console.WriteLine("The result: " + result);
      Console.Read();
    }

    //use StringBuilder
    public static string MergeWithoutDup1(string s1, string s2)
    {
      if (String.IsNullOrEmpty(s1) && String.IsNullOrEmpty(s2)) return string.Empty;
      if (String.IsNullOrEmpty(s1)) return s2;
      if (String.IsNullOrEmpty(s2)) return s1;

      var result = new StringBuilder();
      int l1 = s1.Length;
      int l2 = s2.Length;
      for (int i = 0; i < l1; i++)
      {
        var ch = s1[i];
        if (!result.ToString().Contains(ch))
        {
          result.Append(ch);
        }
      }

      for (int i = 0; i < l2; i++)
      {
        var ch = s2[i];
        if (!result.ToString().Contains(ch))
        {
          result.Append(ch);
        }
      }

      return result.ToString();
    }

    //use HashSet
    public static string MergeWithoutDup2(string s1, string s2)
    {
      if (String.IsNullOrEmpty(s1) && String.IsNullOrEmpty(s2)) return string.Empty;
      if (String.IsNullOrEmpty(s1)) return s2;
      if (String.IsNullOrEmpty(s2)) return s1;
      var hs = new HashSet<Char>();

      foreach (var ch in s1)
      {
        hs.Add(ch);
      }

      foreach (var c in s2)
      {
        hs.Add(c);
      }

      var sb = new StringBuilder();
      foreach (var cs in hs)
      {
        sb.Append(cs);
      }
  
      return sb.ToString();
    }
  }
}
