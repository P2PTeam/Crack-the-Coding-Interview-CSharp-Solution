using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.chapter01
{
    class question0101
    {
        static void NotMain(string[] args)
        {
          Console.WriteLine(IsUniqueCharacters("haha"));
            Console.WriteLine(HasUniqueCharactersSpaceEfficient("helo wd"));

            Console.Read();
        }

        //利用HashTable 统计ASCII码
        static bool HasUniqueCharacters(String s)
        {
            if (s.Length > 256)
                return false;
            char[] cArray = s.ToCharArray();
            char[] count = new char[256];
            for (int i = 0; i < cArray.Length; i++)
            {
                count[cArray[i]]++;
                if (count[cArray[i]] == 2)
                    return false;
            }
            return true;
        }

        //Brust force O(n2)
        static bool HasUniqueCharactersSpaceEfficient(String s)
        {
            if (s.Length > 256)
                return false;
            char[] cArray = s.ToCharArray();
            for(int i = 0;i<cArray.Length;i++)
                for (int j = i + 1; j < cArray.Length; j++)
                    if (cArray[i] == cArray[j])
                        return false;
            return true;
        }

        //tow points
        static bool IsUniqueCharacters(string s)
        {
            if (!string.IsNullOrWhiteSpace(s))
            {
                Array.Sort(s.ToArray());
                int len = s.Length;
                int start = 0, end = 1;
                while (start < len - 1 && end < len - 1)
                {
                    if (s[start] == s[end])
                    {
                        return false;
                    }else
                    {
                        start++;
                        end++;
                    }
                }
            }

            return true;
        }
    }
}
