using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.chapter01
{
    class question0105
    {
        static void NotMain(String[] args)
        {
            Console.WriteLine(Compress("aabcccccaaa"));
            Console.Read();
        }

        static String Compress(String s)
        {
            char[] a = s.ToCharArray();
            StringBuilder sb = new StringBuilder();
            int repeatCount = 1;
            int pointer = 0;
            while (pointer < a.Length - 1)
            {
                if (a[pointer] == a[pointer + 1])
                {
                    repeatCount++;
                }
                else
                {
                    sb.Append(a[pointer]);
                    sb.Append(repeatCount);
                    repeatCount = 1;
                }
                pointer++;
            }
            sb.Append(a[pointer]);
            sb.Append(repeatCount);
            if (sb.Length > s.Length)
                return s;
            return sb.ToString();
        }

        //利用List<char>
        static String Compress2(String s)
        {
            if (string.IsNullOrWhiteSpace(s)) return s;

            var result = new List<char>();
            int i = 0,len=s.Length;
            int count=1;
            while (i < len)
            {
                if (s[i] == s[i + 1])
                {
                    count++;
                }
                else
                {
                    result.Add(s[i]);
                    result.Add(count);
                    count = 1;
                }

                i++;
            }

            result.Add(s[i]);
            result.Add(count);

            if (result.Count > len) return s;
            return result.ToString();
        }
    }
}
