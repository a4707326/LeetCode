using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC486_Predict_the_Winner
    {
        public static void Start()
        {
            Console.WriteLine("LC486_Predict_the_Winner");

            int[] nums = { 1, 5, 233, 7 };

            var ans = PredictTheWinner(nums);


            Console.WriteLine(ans);

        }

        //Input: nums = [1,5,2]
        //Output: false
        //Input: nums = [1,5,233,7]
        //Output: true
        //演算法dp
        //gpt，unk
        public static bool PredictTheWinner(int[] nums)
        {
            int len = nums.Length;
            int[,] dp = new int[len, len]; // 創建一個二維 dp 陣列，dp[i, j] 表示在子陣列 nums[i..j] 中，先手玩家與後手玩家的最大分數差

            // 初始化：當子陣列只有一個元素時，先手玩家得分為該元素值，後手玩家得分為 0，所以分數差就是該元素值
            for (int i = 0; i < len; i++)
            {
                dp[i, i] = nums[i];
            }

            // 遞推計算：從長度為 2 的子陣列開始，逐步計算到整個陣列
            for (int i = 1; i < len; i++) // i 表示子陣列的長度
            {
                for (int j = 0; j < len - i; j++) // j 表示子陣列的起始索引
                {
                    int k = j + i; // k 表示子陣列的結束索引

                    // 對於子陣列 nums[j..k]，先手玩家有兩種選擇：
                    // 1. 選擇 nums[j]，剩餘子陣列為 nums[j+1..k]，後手玩家將從中獲取最大分數，先手玩家的分數差為 nums[j] - dp[j + 1, k]
                    // 2. 選擇 nums[k]，剩餘子陣列為 nums[j..k-1]，後手玩家將從中獲取最大分數，先手玩家的分數差為 nums[k] - dp[j, k - 1]
                    // 先手玩家會選擇能讓自己分數差最大的選項
                    dp[j, k] = Math.Max(nums[j] - dp[j + 1, k], nums[k] - dp[j, k - 1]);
                }
            }

            // 如果整個陣列的分數差 dp[0, len - 1] 大於等於 0，表示先手玩家可以獲勝
            return dp[0, len - 1] >= 0;
        }



    }



}
