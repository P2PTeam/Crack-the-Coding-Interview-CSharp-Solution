using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.chapter05
{
    class question0505
    {
        static void NotMain(String[] args)
        {
            int a = 31;
            int b = 14;
            BitUtil.PrintNumBinary(a);
            BitUtil.PrintNumBinary(b);
            Console.WriteLine(getDiff(a, b));
            Console.Read();
        }

        static int getDiff(int a, int b)
        {
            int c = a ^ b;
            Console.WriteLine("c： " + Convert.ToString(c, 2));
            int count = 0;
            while (c != 0)
            {
                c &= (c - 1);
                Console.WriteLine("C&=(c-1) ： " + Convert.ToString(c, 2));
                count++;
            }
            return count;
        }
    }
}
