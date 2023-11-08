using System;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC463_Island_Perimeter
    {
        public static void Start()
        {
            Console.WriteLine("LC463_Island_Perimeter");
            int[][] matrix = new int[][] {
            new int[] {0,1,0,0},
            new int[] {1,1,1,0},
            new int[] {0,1,0,0},
            new int[] { 1, 1, 0, 0 }
        };


            var ans = IslandPerimeter(matrix);

            Console.WriteLine(ans);



        }



        // Input: grid = [[0,1,0,0],[1,1,1,0],[0,1,0,0],[1,1,0,0]]
        // Output: 16
        //猜O(N*N),O[1]
        //O(N),O[1]
        //BF
        //LC
        public static int IslandPerimeter(int[][] grid)
        {

            int colLen = grid.Length;
            int rowLen = grid[0].Length;
            int sum = 0;

            for (int i = 0; i < colLen; i++)
            {
                for (int j = 0; j < rowLen; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        //上邊 
                        if (i == 0 || (grid[i - 1][j] == 0))
                        {
                            sum++;
                        }

                        //下邊 
                        if (i == colLen - 1 || (grid[i + 1][j] == 0))
                        {
                            sum++;
                        }

                        //左邊 
                        if (j == 0 || (grid[i][j - 1] == 0))
                        {
                            sum++;
                        }

                        //右邊 
                        if (j == rowLen - 1 || (grid[i][j + 1] == 0))
                        {
                            sum++;
                        }

                    }
                }
            }
            return sum;
        }


    }


}
