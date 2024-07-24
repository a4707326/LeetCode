using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC695_Max_Area_of_Island
    {

        public static void Start()
        {
            Console.WriteLine("LC695_Max_Area_of_Island");

            int[][] grid = new int[][]
            {
                new int[] { 0,0,1,0,0,0,0,1,0,0,0,0,0 },
                new int[] { 0,0,0,0,0,0,0,1,1,1,0,0,0 },
                new int[] { 0,1,1,0,1,0,0,0,0,0,0,0,0 },
                new int[] { 0,1,0,0,1,1,0,0,1,0,1,0,0 },

                new int[] { 0,1,0,0,1,1,0,0,1,1,1,0,0 },
                new int[] { 0,0,0,0,0,0,0,0,0,0,1,0,0 },
                new int[] { 0,0,0,0,0,0,0,1,1,1,0,0,0 },
                new int[] { 0,0,0,0,0,0,0,1,1,0,0,0,0 },

            };
            var ans = MaxAreaOfIsland(grid);

            Console.WriteLine(ans);

        }

        //     Input: grid = [[0,0,1,0,0,0,0,1,0,0,0,0,0],[0,0,0,0,0,0,0,1,1,1,0,0,0],[0,1,1,0,1,0,0,0,0,0,0,0,0],[0,1,0,0,1,1,0,0,1,0,1,0,0],[0,1,0,0,1,1,0,0,1,1,1,0,0],[0,0,0,0,0,0,0,0,0,0,1,0,0],[0,0,0,0,0,0,0,1,1,1,0,0,0],[0,0,0,0,0,0,0,1,1,0,0,0,0]]
        // Output: 6
        //O(M \times N) 也視為 O(n * m)， O(M * N)
        //DFS
        //LC
        public static int MaxAreaOfIsland(int[][] grid)
        {
            int rowCount = grid.Length;
            int colCount = grid[0].Length;

            int maxIsland = 0;
            int sum = 0;
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < colCount; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        sum = 0;
                        DFS(i, j);
                    }
                }
            }

            //把連接的陸地都變成水，並同時計算最大數
            void DFS(int i, int j)
            {
                if (i < 0 || (i >= rowCount) || j < 0 || (j >= colCount) || (grid[i][j] == 0)) return;
                sum++;
                if (maxIsland < sum) maxIsland = sum;
                grid[i][j] = 0;
                DFS(i + 1, j);
                DFS(i - 1, j);
                DFS(i, j + 1);
                DFS(i, j - 1);
            }
            return maxIsland;
        }
    }
}

