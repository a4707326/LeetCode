using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class WC414_Q3_Reach_End_of_Array_With_Max_Score
    {
        public static void Start()
        {
            Console.WriteLine("WC414_Q3_Reach_End_of_Array_With_Max_Score");



            int[] nums = { 4, 3, 1, 3, 2 };


            var ans = FindMaximumScore(nums);
            var ans2 = MaxScore(nums);
            
 


            Console.WriteLine(ans);

        }

        //Input: nums = [1,3,1,5]
        //Output: 7
        //Input: nums = [4,3,1,3,2]
        //Output: 16

        static long FindMaximumScore(IList<int> nums)
        {
            // (j - i) * nums[i].
            //1-0 = 1 *1 =1   
            //3-1 = 2 *3 =6
            //6+1 =7   

            //0- 0 = 0 * 14 = 0

            int n = nums.Count;
            int[] dp = new int[n];
            int max = 0;
            int maxIdx = 0;

            for (int i = 1; i < n; i++)
            {
  

                dp[i] = dp[maxIdx] + (i - maxIdx) * nums[maxIdx];
 

                if (max < dp[i])
                {
                    max = dp[i];
                    maxIdx = i;
                }
            }

            return dp[n - 1];





            //int n = nums.Count();
            //int[] dp = new int[n];
            //dp[0] = 0; // 到達索引 0 的分數為 0

            //for (int i = 1; i < n; i++)
            //{
            //    dp[i] = 0; // 初始化為 0
            //    for (int j = 0; j < i; j++)
            //    {
            //        dp[i] = Math.Max(dp[i], dp[j] + (i - j) * nums[j]);
            //    }
            //}

            //return dp[n - 1]; // 返回到達最後一個索引的最大分數

        }
        static int MaxScore(int[] nums)
        {
            int n = nums.Length;
            int[] dp = new int[n];
            dp[0] = 0;

            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    dp[i] = Math.Max(dp[i], dp[j] + (i - j) * nums[j]);
                }
            }

            return dp[n - 1];
        }
    }



}
