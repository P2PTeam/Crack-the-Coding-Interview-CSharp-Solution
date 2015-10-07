using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.ms_interview
{
  class BracketBalances
  {
    static void NotMain(String[] args)
    {
      var blacks = "()()(()){}{}[[]]";
      var result = IsBalance2(blacks);
      Console.WriteLine("The result is: " + result.ToString());

      Console.Read();
    }

    //use count
    public static bool IsBalance2(string s)
    {
      if (string.IsNullOrWhiteSpace(s)) return true;
      int count1 = 0, count2 = 0, count3 = 0;
      foreach (var ch in s)
      {
        if (ch == '(')
        {
          count1++;
        }
        else if (ch == ')')
        {
          count1--;
        }

        if (ch == '{')
        {
          count2++;
        }
        else if (ch == '}')
        {
          count2--;
        }

        if (ch == '[')
        {
          count3++;
        }
        else if (ch == ']')
        {
          count3--;
        }
      }

      return count1 ==0 && count2 == 0 && count3 == 0;
    }

    // use stack
    public static bool IsBalance1(string s)
    {
      if (string.IsNullOrWhiteSpace(s))
      {
        return true;
      }

      var stack = new Stack<char>();
      int len = s.Length;
      foreach (var ch in s)
      {
        if (IsOpen(ch))
        {
          stack.Push(ch);
        }
        else if (IsClose(ch))
        {
          var open = stack.Pop();
          if (!IsMatch(open, ch))
          {
            return false;
          }
        }
      }

      return stack.Count == 0;
    }

    private static bool IsOpen(char ch)
    {
      return ch == '(' || ch == '{' || ch == '[';
    }

    private static bool IsClose(char ch)
    {
      return ch == ')' || ch == '}' || ch == ']';
    }

    private static bool IsMatch(char ch1, char ch2)
    {
      return (ch1 == '(' && ch2 == ')') || (ch1 == '{' && ch2 == '}') || (ch1 == '[' && ch2 == ']');
    }
  }
}
