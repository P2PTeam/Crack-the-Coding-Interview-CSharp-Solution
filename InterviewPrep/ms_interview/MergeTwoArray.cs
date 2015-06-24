using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.ms_interview
{

  /*
   * Given 2 sorted arrays, A and B. Int A = new Int[4], A= {1,3,5,7}. Int B = new Int[7], 
   * B = {2,4,8}; Merge these 2 arrays and in sorted order and in most performant. Array B 
   * will always have room to fit array A.
   */
  class MergeTwoArray
  {
    static void Main(string[] args)
    {
      var A = new int[] { 1,3,5,7 };
      var B = new int[7];
      B[0] = 2;
      B[1] = 4;
      B[2] = 8;
      var result = MergeTwoArray2B(A, B,4,3);
      Console.WriteLine("The result: ");
      Console.Read();
    }

    public static int[] MergeTwoArray2B(int[] A, int[] B,int lenA,int lenB)
    {
      if (A == null || A.Length == 0) return B;
      int i = lenA - 1, j = lenB - 1;
      int k = lenA + lenB - 1;

      while (i >= 0 && j >= 0)
      {
        if (A[i] > B[j])
        {
          B[k--] = A[i--];
        }else if (A[i] < B[j])
        {
          B[k--] = B[j--];
        }
        else
        {
          B[k--] = A[i--];
          B[k--] = B[j--];
        }
      }

      while (i >= 0)
      {
        B[k--] = A[i--];
      }

      return B;
    }
  }
}
