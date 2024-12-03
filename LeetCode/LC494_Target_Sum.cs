using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC494_Target_Sum
    {
        public static void Start()
        {
            Console.WriteLine("LC494_Target_Sum");



            int[] nums = { 1, 1, 1, 1, 1 };

            int num = 3;


            var ans = FindTargetSumWays(nums, num);
            
 


            Console.WriteLine(ans);

        }

        //Input: nums = [1,1,1,1,1], target = 3
        //Output: 5
        //猜O(N!),O(N^2)
        //答O(N^2),O(N^2)
        //演算法DP
        static int FindTargetSumWays(int[] nums, int target)
        {
            List<List<int>> dp = new();
            int n = nums.Length;

            //初始化DB
            for (int i = 0; i < n; i++)
            {
                dp.Add(new List<int>());
            }
            dp[0].Add(nums[0]);
            dp[0].Add(-nums[0]);

            //計算前一個list每個值+或-到下一個
            for (int i = 0; i < n-1; i++)
            {
                for (int j = 0; j < dp[i].Count; j++)
                {
                    dp[i + 1].Add(dp[i][j] + nums[i + 1]);
                    dp[i + 1].Add(dp[i][j] - nums[i + 1]);
                }
            }

            //計算次數
            int count = 0;
            foreach (var item in dp[n-1])
            {
                if (item == target)
                {
                    count++;
                }
            }

            return count;
        }

    }



}
