using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC416_Partition_Equal_Subset_Sum
    {
        public static void Start()
        {
            Console.WriteLine("LC416_Partition_Equal_Subset_Sum");

            int[] nums = { 4, 5, 9, 6 };//22 11

            var ans = CanPartition(nums);

            Console.WriteLine(ans);

        }

        //Input: nums = [1,5,11,5]
        //Output: true
        public static bool CanPartition(int[] nums)
        {

            //列出所有可能和出的子集，在看沒有包含答案

            // 計算陣列的總和
            int sum = nums.Sum();
            // 如果總和為奇數，無法平均分割成兩個相等的子集，返回 false
            if (sum % 2 == 1)
            {
                return false;
            }
            // 計算目標和，即總和的一半
            int needsum = sum / 2;

            // 創建一個布林陣列 dp，其中 dp[i] 表示是否能組成和為 i 的子集
            bool[] dp = new bool[needsum + 1];

            // 初始化 dp[0] 為 true，因為和為 0 的子集總是存在的
            dp[0] = true;

            // 遍歷陣列 nums 中的每個數字，更新 dp 陣列
            foreach (int num in nums)
            {
                // 從 needsum 遞減到 num，確保每個數字只能使用一次
                for (int i = needsum; i >= num; i--)
                {
                    // 如果 dp[i-num] 為 true，則表示可以組成和為 i 的子集
                    dp[i] = dp[i] || dp[i - num];
                }
            }

            // 返回 dp[needsum]，即是否能組成和為 needsum 的子集
            return dp[needsum];
        }
    }


    //
    //0
    //for 11



    //Input: nums = [1,5,11,5]
    //bool[11]
    //bool[0] = true;


    //0t 1f 2f 3f 4f 5f 6f 7f 8f 9f 10f 11f
    //


}

