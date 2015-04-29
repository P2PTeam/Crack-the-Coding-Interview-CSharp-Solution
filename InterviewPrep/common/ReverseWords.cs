using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.common
{
    class ReverseWords
    {

        static void NotMain(String[] args)
        {
            String s = "abc  def     zcc";
            Console.WriteLine("[]");
            var result = ReverseWord2(s);
                
            Console.WriteLine("[" + ReverseWord(s) + "]");
            Console.Read();
        }

        static String ReverseWord(String s)
        {

            StringBuilder result = new StringBuilder();
            s = s + " ";
            int begin = 0;
            int end = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    for (int j = end - 1; j >= begin; j--)
                    {
                        result.Append(s[j]);
                    }
                    end += 1;
                    begin = end;
                    result.Append(" ");
                }
                else
                {
                    end++;
                }
            }
            return result.ToString(0,result.Length-1);
        }

        //三次翻转
        static String ReverseWord2(String s)
        {
            if (string.IsNullOrWhiteSpace(s)) return s;
            int len = s.Length;
            //翻转整个字符串
            ReverseString(s, 0, len - 1);
            int i = 0, j = 0;
            while (i < len - 1 && j < len - 1)
            {
                if (s[j] == ' ')
                {
                    //翻转每个单词
                    ReverseString(s, i, j - 1);
                    j++;
                    i = j;
                }
                else
                {
                    j++;
                }
            }

            return s;
        }

        static String ReverseString(String s,int left,int right)
        {
            if(string.IsNullOrWhiteSpace(s)) return s;
            s = s.Trim();
            var arr = s.ToCharArray();
            int len = s.Length;
            while (left < right)
            {
                var t = arr[left];
                arr[left++] = arr[right];
                arr[right--] = t;
            }

            return new String(arr);
        }
    }
}
