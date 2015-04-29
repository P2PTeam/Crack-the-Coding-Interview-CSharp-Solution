using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.chapter02
{
    class question0204
    {
        static void NotMain(String[] args)
        {
            Node l = Node.createLinkedList(new int[] { 3, 1, 2, 4, 5, 6,9, 7, 8, 6 });
            Node.printNodes(partition(6, l));
            Console.Read();
        }

        //n是链表有重复且是最后一个元素
        static Node partition(int n, Node head)
        {
            Node pointer = head;
            Node sHead = new Node(-1);
            Node bHead = new Node(-1);
            //value=n的元素
            Node midHead = new Node(-1);
            Node sPointer = sHead;
            Node bPointer = bHead;
            Node midPointer = midHead;
            while (pointer != null)
            {
                if (pointer.data < n)
                {
                    sPointer.next = pointer;
                    sPointer = sPointer.next;
                }else if(pointer.data==n){
                    midPointer.next = pointer;
                    midPointer = midPointer.next;
                }
                else
                {
                    bPointer.next = pointer;
                    bPointer = bPointer.next;
                }

                pointer = pointer.next;
            }
            bPointer.next = null;//Important!
            sPointer.next = midHead.next;
            midPointer.next= bHead.next;
            return sHead.next;
        }

    }
}
