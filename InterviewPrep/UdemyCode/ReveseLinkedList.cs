using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterviewPrep.chapter02;

namespace InterviewPrep.UdemyCode
{
  class ReveseLinkedList
  {
    static void NotMain(string[] args)
    {
      var arr = new int[] { 2, 7, 6, 5, 8, 1, 9 };
      var head = Node.createLinkedList(arr);

      var result = ReverseList(head);
      Console.WriteLine("The result: " + result.data.ToString());
      Console.Read();
    }

    public static Node ReverseList(Node head)
    {
      if (head == null || head.next == null)
      {
        return head;
      }

      Node pre = null;
      var current = head;
      while (current != null)
      {
        var next = current.next;
        current.next = pre;
        pre = current;
        current = next;
      }

      return pre;
    }

    //recurse
    private static Node ReverseListRecurse(Node head)
    {
      var current = head;      
      current.next = head;
      var oldNext = head.next;
      if (oldNext == null)
      {
        return current;
      }

      return ReverseListRecurse(current);
    }
  }
}
