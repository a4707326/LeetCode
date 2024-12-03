using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC746_Min_Cost_Climbing_Stairs
    {
        public static void Start()
        {
            Console.WriteLine("LC746_Min_Cost_Climbing_Stairs");



            int[] nums = { 10, 15, 20 };


            var ans = MinCostClimbingStairs2(nums);




            Console.WriteLine(ans);

        }
        //Input: cost = [1 ,2 ,1000 ,1]
        //Output: 3
        static int MinCostClimbingStairs(int[] cost)
        {
            //[1 ,2 ,1000 ,1]
            //[0,0,0,0,0]

            int n = cost.Length;//樓頂的Index
            int[] dp = new int[n + 1]; // 建立 dp 陣列儲存到達每階的最小成本

            for (int i = 2; i <= n; i++)// 
            {
                dp[i] = Math.Min(dp[i - 1] + cost[i - 1], dp[i - 2] + cost[i - 2]);
            }

            //[0,0,1,0,0]
            //[0,0,1,2,0]
            //[0,0,1,2,3]
            return dp[n]; // 返回到達樓頂的最小成本

        }

        //Input: cost = [1,100,1,1,1,100,1,1,100,1]
        //Input: cost = [1,100,0,0,0,0,0,0,0,0]
        //Input: cost = [1,100,2,3,3,103,4,5,104,6]

        //Input: cost = [1 ,2 ,1000 ,1]
        //Input: cost = [0,0,0,0]
        //Input: cost = [1,2,1001,3]


        //Output: 6
        static int MinCostClimbingStairs2(int[] cost)
        {
            int[] dp = new int[cost.Length + 1];
            Array.Copy(cost, dp, cost.Length);


            for (int i = 2; i < dp.Length; i++)
            {
                dp[i] = Math.Min(dp[i - 1], dp[i - 2]) + dp[i];

            }
            return dp[dp.Length-1];
        }

    }



}
