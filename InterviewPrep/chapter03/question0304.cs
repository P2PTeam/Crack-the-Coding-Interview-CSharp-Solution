using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.chapter03
{
    class question0304
    {
        public static void NotMain(String[] args)
        {
            //MoveDisk(3, 3, 3, 1);
        }

        //递归解决汉诺塔问题
        public static void MoveDisk(int n, int origin, int dest, int buffer)
        {
            if(n == 1)
                Console.WriteLine(origin+" -> "+dest);
            if (n <= 0)
                return;
            MoveDisk(n - 1, origin, buffer, dest);
            MoveDisk(1, origin, dest, buffer);
            MoveDisk(n - 1, buffer,dest, origin);
        }
    }
}
