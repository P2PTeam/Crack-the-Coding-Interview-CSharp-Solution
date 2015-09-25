using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.common
{
    class CombinationPermutation
    {
        static void NotMain(String[] args)
        {
            //List<String> permutation = GetPermutation("abcd");
          var permutation = Permutation("abcd");
            foreach (var s in permutation)
            {
               
                Console.WriteLine("["+new string(s.ToArray())+"]");
            }
          
            //If n = 4 and k = 2, a solution is:
            //[[2,4],[3,4],[2,3],[1,2],[1,3],[1,4]]
            var combination = GetCombination("dcab",2);
            foreach (var s in combination)
            {
                Console.WriteLine("[" + new string(s.ToArray()) + "]");
            }
           
            Console.Read();
        }

        public static List<List<char>> Permutation(string s)
        {
          var result = new List<List<char>>();
          if (string.IsNullOrWhiteSpace(s)) return result;

          Helper(result, new List<char>(), s.ToCharArray());

          return result;
        }

        private static void Helper(List<List<char>> result, List<char> p, char[] s)
        {
          if (p.Count == s.Length)
          {
            result.Add(new List<char>(p));
            return;
          }

          for (int i = 0; i < s.Length; i++)
          {
            if (p.Contains(s[i]))
            {
              continue;
            }

            p.Add(s[i]);
            Helper(result, p, s);
            p.RemoveAt(p.Count - 1);
          }
        }


        public static List<List<char>> GetCombination(String s, int k)
        {
          var result = new List<List<char>>();
          if (string.IsNullOrWhiteSpace(s)) return result;

          CombinationHelper(result, new List<char>(), s.ToCharArray(),k,0);

          return result;
        }

        private static void CombinationHelper(List<List<char>> result, List<char> p, char[] s, int k, int idx)
        {
          if (p.Count == k)
          {
            result.Add(new List<char>(p));
            return;
          }

          for (int i = idx; i < s.Length; i++)
          {
            p.Add(s[i]);
            CombinationHelper(result, p, s,k,i+1);
            p.RemoveAt(p.Count - 1);
          }
        }
       
    }
}
