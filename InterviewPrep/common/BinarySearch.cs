using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.common
{
    class BinarySearch
    {
        public static void NotMain(String[] args)
        {
            int[] a = new int[] { 1, 1, 2, 2,5, 8,8, 13, 14 };
            int index = BinarySearcher(a, 5);
          
            Console.WriteLine("Completed, index is "+index);
            Console.Read();
        }

        public static int BinarySearcher(int[] A, int target)
        {
          if (A == null || A.Length == 0) return 0;

          int start = 0, end = A.Length - 1;
          int mid;
          while (start + 1 < end)
          {
            mid = start + (end - start) / 2;

            if (A[mid] == target)
            {
              end = mid;
            }
            else if(A[mid]<target)
            {
              start = mid;
            }
            else
            {
              end = mid;
            }
          }

          if (A[start] == target)
          {
            return start;
          }
          else
          {
            return end;
          }
        }

        public static int BiSearch(int[] arr, int target)
        {
            if (arr == null || arr.Length == 0) return -1;
            //如果这里是int right = n 的话，那么下面有两处地方需要修改，以保证一一对应：
            //1、下面循环的条件则是while(left < right)
            //2、循环内当 array[middle] > value 的时候，right = mid
            //int left = 0, right = arr.Length;
            int left = 0, right = arr.Length - 1;

            while(left<=right){
                int mid=left+((right-left)>>1);

                if(arr[mid]>target){
                    right=mid-1;
                }else if(arr[mid]<target){
                    left=mid+1;
                }else
                {
                    return mid;
                }
            }

            return -1;
        }
    }
}
