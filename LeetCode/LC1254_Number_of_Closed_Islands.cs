using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC1254_Number_of_Closed_Islands
    {

        public static void Start()
        {
            Console.WriteLine("LC1254_Number_of_Closed_Islands");

            int[][] grid = new int[][]
            {
                new int[] {1, 1, 1, 1, 1, 1, 1, 0},
                new int[] {1, 0, 0, 0, 0, 1, 1, 0},
                new int[] {1, 0, 1, 0, 1, 1, 1, 0},
                new int[] {1, 0, 0, 0, 0, 1, 0, 1},
                new int[] {1, 1, 1, 1, 1, 1, 1, 0}
            };
            var ans = ClosedIsland(grid);

            Console.WriteLine(ans);



        }



        //Input: grid = [[1,1,1,1,1,1,1,0],[1,0,0,0,0,1,1,0],[1,0,1,0,1,1,1,0],[1,0,0,0,0,1,0,1],[1,1,1,1,1,1,1,0]]
        //Output: 2
        //O(M * N)、O(M * N)
        //DFS
        //LC，Sol
        public static int ClosedIsland(int[][] grid)
        {
            //用DFS標記大法

            int rows = grid.Length;
            int cols = grid[0].Length;
            int count = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (grid[i][j] == 0 && DFS(i, j))
                    {
                        count++;
                    }
                }
            }

            bool DFS(int y, int x)
            {

                if (y >= rows || y < 0 || x >= cols || x < 0) return false;//如果碰至邊界則代表不是封閉島

                if (grid[y][x] != 0) return true;//如果不是陸地則返回turn
                grid[y][x] = 2;//將所到之處標記
                return DFS(y + 1, x) & DFS(y - 1, x) & DFS(y, x + 1) & DFS(y, x - 1);//這裡用 && 非 & 是因為 &&具有短路效應(前面false 後面則不會執行)

            }
            return count;
        }
    }
}

