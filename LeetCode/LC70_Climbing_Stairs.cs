using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC70_Climbing_Stairs
    {
        public static void Start()
        {
            Console.WriteLine("LC70_Climbing_Stairs");

            int num = 1;

            var ans = ClimbStairs(num);



            Console.WriteLine(ans);

        }

        //Input: n = 3
        //Output: 3
        //Explanation: There are three ways to climb to the top.
        //1. 1 step + 1 step + 1 step
        //2. 1 step + 2 steps
        //3. 2 steps + 1 step
        //猜O(n),O(n)
        //猜O(n),O(n)
        //演算法DP
        static int ClimbStairs(int n)
        {
            int[] dp = new int[n];//記憶可走路線數

            //初始化DP 主要是dp[0]跟dp[1]，後面會被覆蓋
            for (int i = 0; i < n; i++)
            {
                dp[i] = i+1;
            }

            //因為一次可走1 or 2步，所以前兩步 + 1次鐵定可以到，所以可以推出下一次
            for (int i = 2; i < n; i++)
            {
                dp[i] = dp[i - 1] + dp[i - 2];
            }
            return dp[dp.Length-1];//返回最後的可走路線數
        }







    }


}
