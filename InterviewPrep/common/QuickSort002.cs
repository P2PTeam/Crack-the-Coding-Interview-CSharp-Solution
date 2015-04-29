using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.common
{
    class QuickSort002
    {
        public static void NotMain(String[] args)
        {
            int[] a = new int[] { 1, 3, 2, 5, 3, 2, 3, 4, 5, 3, 2 };
            int[] a2 = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
                a2[i] = a[i];
            QSort(a, 0, a.Length - 1);
            Array.Sort(a2);
            for (int i = 0; i < a.Length; i++)
                if (a[i] != a2[i])
                    Console.WriteLine("false");
            Console.WriteLine("Completed");
            Console.Read();
        }

        public static void QSort(int[] a, int left, int right)
        {
            if (left >= right) return;

            //int index = Parition(a, left, right);
            int index = Parition003(a, left, right);
            QSort(a, left, index - 1);
            QSort(a, index+1, right);
        }

        // Two points:用最左边的元素作为哨兵,从两头同时向中间移动 （全双工）
        //索引lo从左端开始扫描，直到找到第一个大于主元x的元素，索引hi从右端开始扫描，直到找到第一个小于等于x的元素，
        //然后将这两个索引对应的元素进行交换。继续上面的操作，直到lo > hi。        
        public static int Parition(int[] a, int left, int right)
        {
            int pivotData = a[left];
            int lo = left + 1, hi = right;
            while (lo <= hi)
            {
                while (lo <= hi && a[lo] <= pivotData)
                    ++lo;
                while (lo <= hi && a[hi] >= pivotData)
                    --hi;

                if (lo < hi)
                {
                    Swap(a, lo, hi);
                    ++lo;
                    --hi;
                }
            }

            Swap(a, left, hi);

            return hi;
        }

        // Two points:用最左边的元素作为哨兵,从左向右移动hi（半双工）
        //索引lo,hi初始化为序列开始，然后索引hi依次后移，如果遇到A[hi] <= x，那么就交换A[lo + 1]和A[hi]，
        //直到索引hi移动到末尾，这样结果是索引lo左侧的元素都<=x，右侧的元素都>x。
        public static int Parition002(int[] a, int left, int right)
        {
            int pivotData = a[left];
            int lo = left, hi = left+1;
            while (hi <= right)
            {
                if (a[hi] <= pivotData)
                {
                    ++lo;
                    Swap(a, lo, hi);
                }

                ++hi;
            }

            Swap(a, left, lo);

            return lo;
        }

        //Two points:用最左边的元素作为哨兵,从两头交替向中间移动（半双工），不交换而是采用赋值的方式
        //索引lo指向数组开始的位置，索引hi先从右端开始向左扫描，直到遇到第一个<x主元的元素，然后将该元素移动到索引lo所指的位置，
        //然后索引lo从当前下一个元素开始向右扫描，直到遇到一个>x的元素，将该指辅导索引hi所指的位置。如次循环，直到lo = hi，主元存放到该位置。        
        public static int Parition003(int[] a, int left, int right)
        {
            int pivotData = a[left];
            int lo = left, hi = right;
            while (lo < hi)
            {
                while (lo < hi && a[hi] >= pivotData)
                    --hi;

                if (lo < hi)
                    a[lo++] = a[hi];

                while (lo < hi && a[lo] <= pivotData)
                    ++lo;

                if (lo < hi)
                    a[hi--] = a[lo];             
            }

            a[hi]=pivotData;

            return hi;
        }

        public static void Swap(int[] a, int first, int second)
        {
            int temp = a[first];
            a[first] = a[second];
            a[second] = temp;
        }

    }
}
