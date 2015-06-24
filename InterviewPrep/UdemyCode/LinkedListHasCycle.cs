using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterviewPrep.chapter02;

namespace InterviewPrep.UdemyCode
{
  class LinkedListHasCycle
  {
    static void NotMain(string[] args)
    {
      var arr = new int[] { 2, 7, 6, 5,8, 1, 9, 8 };
      var head = Node.createLinkedList(arr);

      var result = IsLinkedListCycle(head);
      Console.WriteLine("The result: " + result.ToString());
      Console.Read();
    }

    public static bool IsLinkedListCycle(Node head)
    {
      var result = false;
      if (head == null || head.next == null)
      {
        return result;
      }

      var first=head;
      var second = head;

      while (second.next!=null && first.next.next != null)
      {
        second = second.next;
        first = first.next.next;

        if (second == first)
        {
          result = true;
        }
      }

      return result;
    }

  }
}
