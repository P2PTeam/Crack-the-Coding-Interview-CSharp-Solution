using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.chapter01
{
    class question0103
    {
        static void NotMain(String[] args)
        {
            Console.WriteLine(IsPermutation("", "s"));
            Console.WriteLine(IsPermutation("Dog", "goD"));

            Console.Read();
        }

        //判断一个字符串是否是另外一个字符串的组合：
        //HashTable: 遍历一个字符串做加法++， 然后遍历另外一个字符串做减法--
        static bool IsPermutation(String s1, String s2)
        {
            if (s1.Length != s2.Length)
                return false;
            char[] count = new char[256];
            char[] a1 = s1.ToCharArray();
            char[] a2 = s2.ToCharArray();
            for (int i = 0; i < a1.Length; i++)
                count[a1[i]]++;

            for (int i = 0; i < a2.Length; i++)
            {
                count[a2[i]]--;
                if (count[a2[i]] < 0)
                    return false;
            }
            return true;
        }
    }

}
