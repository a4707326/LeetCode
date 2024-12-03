using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC650_2_Keys_Keyboard
    {
        public static void Start()
        {
            Console.WriteLine("LC650_2_Keys_Keyboard");

            int num = 7;


            var ans = MinSteps(num);
            

            Console.WriteLine(ans);

        }

        //Input: n = 6
        //Output: 5
        //猜O(1),O(1)
        //答O(1),O(1)
        //演算法Greedy
        static int MinSteps(int n)
        {
            if (n == 1) return 0; // 如果 n 是 1，不需要任何操作

            int[] dp = new int[n + 1]; // 創建一個 dp 陣列，dp[i] 表示生成長度為 i 的字串所需的最少操作次數

            for (int i = 2; i <= n; i++)
            {
                dp[i] = i; // 初始化為最壞情況，即全部使用 "Paste" 操作
                for (int j = i / 2; j >= 1; j--) // 從 i/2 往下檢查是否有可以複製貼上的長度
                {
                    if (i % j == 0) // 如果 i 可以被 j 整除，表示可以複製長度為 j 的字串，然後貼上 i/j 次
                    {
                        dp[i] = dp[j] + (i / j); // 更新 dp[i] 為更小的操作次數：複製全部 (dp[j]) + 貼上 (i/j 次)
                        break; // 一旦找到一種可行的 "複製全部 + 貼上" 組合，就跳出內層迴圈
                    }
                }
            }

            return dp[n]; // 返回生成長度為 n 的字串所需的最少操作次數
        }
    }
    



}
