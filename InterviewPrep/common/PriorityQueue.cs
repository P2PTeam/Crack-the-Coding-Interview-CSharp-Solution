using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.common
{
    class PriorityQueue
    {
        static void NotMain(String[] args)
        {
            PriorityQueue q = new PriorityQueue(new int[] { 5, 6, 8, 1 });
            //q.Debug();
            Console.WriteLine(q.GetMax());
            //q.Debug();
            Console.WriteLine(q.GetMax());
            Console.WriteLine(q.GetMax());
            Console.WriteLine(q.GetMax());
            Console.Read();
        }

        int[] a;
        int heapSize;
        public PriorityQueue(int[] a)
        {
            this.a = a;
            heapSize = a.Length;
            BuildMaxHeap();
        }

        public void Debug()
        {
            for (int i = 0; i < heapSize;i++ )
                Console.Write(a[i] + " ");
            Console.WriteLine();
        }

        public int GetMax()
        {
            if (heapSize == 0)
                throw new Exception("Queue is empty");
            int result = a[0];
            Swap(0, heapSize-1);
            heapSize--;
            MaxHeapify(0);
            return result;
        }

        private void MaxHeapify(int i)
        {
            int l = LeftChild(i);
            int r = RightChild(i);
            int max = i;
            int maxValue = a[i];
            if (l < heapSize && a[l] > maxValue)
            {
                max = l;
                maxValue = a[l];
            }
            if (r < heapSize && a[r] > maxValue)
                max = r;
            if (max != i)
            {
                Swap(max, i);
                MaxHeapify(max);
            }
        }

        //步骤：
        //1.构造最大堆（Build_Max_Heap）：若数组下标范围为0~n，考虑到单独一个元素是大根堆，则从下标n/2开始的元素均为大根堆。
        //于是只要从n/2-1开始，向前依次构造大根堆，这样就能保证，构造到某个节点时，它的左右子树都已经是大根堆。
        //2.堆排序（HeapSort）：由于堆是用数组模拟的。得到一个大根堆后，数组内部并不是有序的。因此需要将堆化数组有序化。
        //思想是移除根节点，并做最大堆调整的递归运算。第一次将heap[0]与heap[n-1]交换，再对heap[0...n-2]做最大堆调整。第二次将heap[0]与heap[n-2]交换，再对heap[0...n-3]做最大堆调整。重复该操作直至heap[0]和heap[1]交换。由于每次都是将最大的数并入到后面的有序区间，故操作完后整个数组就是有序的了。
        //3.最大堆调整（Max_Heapify）：该方法是提供给上述两个过程调用的。目的是将堆的末端子节点作调整，使得子节点永远小于父节点 
        private void BuildMaxHeap()
        {
            int middle = (a.Length+1)/ 2-1;
            for (int i = middle; i >= 0; i--)
                MaxHeapify(i);
        }

        private void Swap(int m, int n)
        {
            int temp = a[m];
            a[m] = a[n];
            a[n] = temp;
        }

        private static int Parent(int i)
        {
            return (i + 1) / 2 - 1;
        }

        private static int LeftChild(int i)
        {
            return 2 * i + 1;
        }

        private static int RightChild(int i)
        {
            return 2 * i + 2;
        }
    }
}
