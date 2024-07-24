using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC64_Minimum_Path_Sum
    {

        public static void Start()
        {
            Console.WriteLine("LC64_Minimum_Path_Sum");

            int[][] matrix = new int[][] {
                new int[] {1,3,1},
                new int[] { 1, 5, 1 },
                new int[] { 4, 2, 1 }
            };
            var ans = MinPathSum(matrix);


            Console.WriteLine(ans);


        }
        // Input: grid = [[1,3,1],[1,5,1],[4,2,1]]
        // Output: 7
        //猜O(N*M),O(N*M)
        //O(N*M),O(N*M)
        //DP
        //LC，GPT
        public static int MinPathSum(int[][] grid)
        {
            int rows = grid.Length;
            int cols = grid[0].Length;

            // 初始化DP表格，dp[i][j]表示從(0, 0)到(i, j)的最小路徑的成本
            int[][] dp = new int[rows][];
            for (int i = 0; i < rows; i++)
            {
                dp[i] = new int[cols];
            }
            // 0,0,0
            // 0,0,0
            // 0,0,0

            // 初始化起點
            dp[0][0] = grid[0][0];
            // 1,0,0
            // 0,0,0
            // 0,0,0

            for (int i = 1; i < rows; i++)
            {
                dp[i][0] = dp[i - 1][0] + grid[i][0]; // 1 + 1 = 2//原本的成本+下一步的成本
            }
            // 1,0,0
            // 2,0,0
            // 6,0,0
            for (int i = 1; i < cols; i++)
            {
                dp[0][i] = dp[0][i - 1] + grid[0][i]; // 1 + 3 = 4//原本的成本+下一步的成本
            }
            // 1,4,5
            // 2,0,0
            // 6,0,0

            // 填充DP表格，每個格子的值是左方和上方格子的最小值加上當前格子的值
            for (int i = 1; i < rows; i++)
            {
                for (int j = 1; j < cols; j++)
                {
                    dp[i][j] = Math.Min(dp[i - 1][j], (dp[i][j - 1])) + grid[i][j];
                }
            }
            // 1,4,5
            // 2,7,6
            // 6,8,7

            // 返回右下角格子的最小路徑和
            return dp[rows - 1][cols - 1];

        }

        // 1,4,5
        // 2,7,6
        // 6,8,7


    }


}
