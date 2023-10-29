using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC2500_Delete_Greatest_Value_in_Each_Row
    {
        public static void Start()
        {
            Console.WriteLine("LC2500_Delete_Greatest_Value_in_Each_Row");

            int[][] grid = { new int[] { 1, 2, 4 }, new int[] { 3,3,1} };

            var ans = DeleteGreatestValue(grid);

            Console.WriteLine(ans);

            //foreach (int i in ans) 
            //{
            //    Console.WriteLine(i.ToString());
            //}


        }
        //Input: grid = [[1,2,4],[3,3,1]]
        //Output: 8
        public static int DeleteGreatestValue(int[][] grid)
        {
            int maxSum = 0;
            int max = 0;
            foreach (int[] row in grid ) 
            {
                Array.Sort(row);
            }


            for (int i = 0; i < grid[0].Length; i++)
            {
                max = 0;
                for (int j = 0; j < grid.Length; j++)
                {
                    if (grid[j][i] > max)
                    {
                        max = grid[j][i];
                    }
                }

                maxSum += max;
            }


            return maxSum;
        }






    }


}
