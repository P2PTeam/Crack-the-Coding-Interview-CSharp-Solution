using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.ms_interview
{
  class CompareVersionNumber
  {
    static void Main(String[] args)
    {
      var version1 = "123.222.103";
      var version2 = "123.222.003";
      var result = CompareVersion(version1,version2);
      Console.WriteLine("The result is: " + result.ToString());

      Console.Read();
    }

    /// <summary>
    /// 1: if ver1 > ver2; 
    /// 0: if ver1 == ver2
    /// -1: if ver1 < ver2
    /// </summary>
    /// <param name="version1"></param>
    /// <param name="version2"></param>
    /// <returns></returns>
    private static int CompareVersion(string version1, string version2)
    {
       if(string.IsNullOrWhiteSpace(version1) && string.IsNullOrWhiteSpace(version2)) {
         return 0;
       }

      if(string.IsNullOrWhiteSpace(version1)) return -1;
      if(string.IsNullOrWhiteSpace(version2)) return 1;

      var numberArr1= version1.Split('.');
      var numberArr2= version2.Split('.');
      int len1=numberArr1.Length, len2=numberArr2.Length;
      if (len1 != len2)
      {
        throw new Exception("Invalid input!");
      }

      int i=0;
      while(i<len1 || i<len2){
        if(i<len1 && i<len2){
          int a=int.Parse(numberArr1[i]);
          int b=int.Parse(numberArr2[i]);
          if(a>b){
            return 1;
          }else if(a<b){
            return -1;
          }
        }else if(i<len1){
          if(int.Parse(numberArr1[i]) !=0){
            return 1;
          }
        }else if(i<len2){
          if(int.Parse(numberArr2[i])!=0){
            return -1;
          }
        }

        i++;
      }

      return 0;
    }
  }
}
