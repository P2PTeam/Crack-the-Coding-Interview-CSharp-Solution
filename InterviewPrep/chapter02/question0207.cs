using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.chapter02
{
    class question0207
    {
        static void NotMain(String[] args)
        {
            Node n = Node.createLinkedList(new int[]{1,2,3,2,1});
            Console.WriteLine(isPalindrome(n));
            var str = new int[] { 1, 2, 3, 2, 1 };
            Console.WriteLine(isPalindrome(str));
            var num = 12321;
            Console.WriteLine(reverse(num)==num);
            Console.WriteLine(isPalindrome(12321));
            Console.Read();
        }

        static Boolean isPalindrome(Node n)
        {
            Node fastRunner = n;
            Node slowRunner = n;
            Stack<int> stack = new Stack<int>();
            while (fastRunner != null && fastRunner.next != null)
            {
                fastRunner = fastRunner.next.next;
                stack.Push(slowRunner.data);
                slowRunner = slowRunner.next;
            }
            if (fastRunner != null && fastRunner.next == null)//Odd number of nodes
                if (stack.Count > 0)//Check case of only one node
                    stack.Pop();

            while (stack.Count > 0)
            {
                int num = stack.Pop();
                 if (num != slowRunner.data)
                     return false;
                 slowRunner = slowRunner.next;
            }
            return true;
        }

        //字符串对称
        static bool isPalindrome(int[] str)  
        {  
            int begin = 0, end = str.Length-1;  
            while (begin < end) {  
                if (str[begin] == str[end]) {  
                    begin++;  
                    end--;  
                } else {  
                    return false;  
                }  
            }  
            return true;  
        }  

        //数字翻转法
        static int reverse(int num)
        {
            //assert(num >= 0);
            if (num <= 0) return 0;

            int rev = 0;
            while (num != 0)
            {
                rev = rev * 10 + num % 10;
                num /= 10;
            }
            return rev;
        }
 
       //数字位判断法
        static bool isPalindrome(int x)
        {
            if (x < 0) return false;
            int div = 1;
            while (x / div >= 10)
            {
                div *= 10;
            }
            while (x != 0)
            {
                int l = x / div;
                int r = x % 10;
                if (l != r) return false;
                x = (x % div) / 10;
                div /= 100;
            }
            return true;
        }  

    }
}
