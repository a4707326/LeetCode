using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC200_Number_of_Islands
    {

        public static void Start()
        {
            Console.WriteLine("LC200_Number_of_Islands");

            char[][] grid = new char[][]
            {
                new char[] { '1', '1', '0', '0', '0' },
                new char[] { '1', '1', '0', '0', '0' },
                new char[] { '0', '0', '1', '0', '0' },
                new char[] { '0', '0', '0', '1', '1' }
            };
            var ans = NumIslands(grid);


            Console.WriteLine(ans);


        }
        // Input: grid = [
        //   ["1","1","0","0","0"],
        //   ["1","1","0","0","0"],
        //   ["0","0","1","0","0"],
        //   ["0","0","0","1","1"]
        // ]
        // Output: 3
        //猜O[N],O[N]
        //O(m * n),O(m * n)
        //DFS
        //LC ，Sol
        public static int NumIslands(char[][] grid)
        {
            int rowCount = grid.Length;
            int colCount = grid[0].Length;

            int islandCount = 0;

            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < colCount; j++)
                {
                    if (grid[i][j] == '1')
                    {
                        ToWater(i, j);
                        islandCount++;
                    }
                }
            }

            //把連接的陸地都變成水
            void ToWater(int i, int j)
            {
                if (i < 0 || (i >= rowCount) || j < 0 || (j >= colCount) || (grid[i][j] == '0')) return;
                grid[i][j] = '0';
                ToWater(i + 1, j);
                ToWater(i - 1, j);
                ToWater(i, j + 1);
                ToWater(i, j - 1);
            }
            return islandCount;
        }
    }

}
