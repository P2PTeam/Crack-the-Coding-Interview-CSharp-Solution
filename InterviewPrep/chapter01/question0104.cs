using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.chapter01
{
    class question0104
    {
        static void NotMain(String[] args)
        {
            Console.WriteLine(ReplaceSpace("Mr John Smith    "));
            Console.Read();
        }

        //two points: from end to start
        static String ReplaceSpace(String s)
        {
            char[] a = s.ToCharArray();
            int endPointer = a.Length - 1;
            int nonSpacePointer = a.Length - 1;
            while (a[nonSpacePointer] == ' ')
                nonSpacePointer--;
            while (endPointer != 0)
            {
                if (a[nonSpacePointer] != ' ')
                {
                    a[endPointer] = a[nonSpacePointer];
                    endPointer--;
                }
                else
                {
                    a[endPointer] = '0';
                    endPointer--;
                    a[endPointer] = '2';
                    endPointer--;
                    a[endPointer] = '%';
                    endPointer--;
                }
                nonSpacePointer--;
            }
            return new String(a);
        }

        static String ReplaceSpace2(String s)
        {
            if (string.IsNullOrWhiteSpace(s)) return s;
            int len = s.Length;
            int count = 0;
            for (int i = 0; i < len; i++)
            {
                if (s[i] == ' ')
                {
                    count++;
                }
            }

            int newLen = len + 2 * count;
            int newEnd = newLen - 1, end = len - 1;
            while (newEnd >= 0 && end >= 0)
            {
                if (s[end] != ' ')
                {
                    s[newEnd] = s[end];
                    newEnd--;
                }
                else
                {
                    s[newEnd] = '0';
                    newEnd--;
                    s[newEnd] = '2';
                    newEnd--;
                    s[newEnd] = '%';
                    newEnd--;
                }

                end--;
            }
        }
    }
}
