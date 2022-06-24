using System;

namespace Maximum_Length_of_Repeated_Subarray
{
  class Program
  {
    static void Main(string[] args)
    {
      //Input: nums1 = [1,2,3,2,1], nums2 = [3,2,1,4,7]
      Console.WriteLine("Hello World!");
    }
  }

  public class Solution
  {
    public int FindLength(int[] nums1, int[] nums2)
    {
      // will solve this using 2 D dp
      // using bottom up approach
      // plot nums1 in rows of 2 D DP
      // plot nums2 in column of 2 D DP
      int row = nums1.Length;
      int column = nums2.Length;
      // we need extra one row and column
      // coz for a current i and j if found match in both the array then the max would be 1 + dp[i + 1][j + 1]
      int[][] dp = new int[row + 1][];
      int max = 0;
      for (int i = dp.Length - 1; i >= 0; i--)
      {
        dp[i] = new int[column + 1];
        for (int j = dp[i].Length - 1; j >= 0; j--)
        {
          // for last row and column in DP will assign 0
          if (i == dp.Length - 1 || j == dp[i].Length - 1)
          {
            dp[i][j] = 0;
            continue;
          }
          // if the no in both the array maching ?
          // the max is 1 + previous dp position
          if (nums1[i] == nums2[j])
          {
            dp[i][j] = 1 + dp[i + 1][j + 1];
          }
          // max to get the final answer
          max = Math.Max(max, dp[i][j]);
        }
      }

      return max;
    }
  }
}
