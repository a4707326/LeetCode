using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC1351_Count_Negative_Numbers_in_a_Sorted_Matrix
    {
        public static void Start()
        {
            Console.WriteLine("LC1351_Count_Negative_Numbers_in_a_Sorted_Matrix");

            int[][] grid = new int[][]
            {
                new int[] { 4, 3, 2, -1 },
                new int[] { 3, 2, 1, -1 },
                new int[] { 1, 1, -1, -2 },
                new int[] { -1, -1, -2, -3 }
            };

            int[][] grid2 = new int[][]
            {
                new int[] { 5,1,0 },
                new int[] { -5,-5,-5 },

            };



            var ans = CountNegatives2(grid2);

            Console.WriteLine(ans.ToString());



        }
        //[[3,2],[1,0]]
        //1
        //1
        //max = 2
        //mix = 1


        //[1,1,0,-1,-2,-3,-4,-5]
        //4,-2
        //2,0
        //3,-1
        //
        //max = 3
        //mix = 2

        //Input: grid = [[4,3,2,-1],[3,2,1,-1],[1,1,-1,-2],[-1,-1,-2,-3]]
        //Output: 8
        public static int CountNegatives(int[][] grid)
        {
            int count = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                int max = grid[i].Length;
                int mix = 0;
                int mid = grid[i].Length / 2;


                if (grid[i][max - 1] >= 0)
                {
                    continue;
                }
                if (grid[i][0] < 0)
                {
                    count += grid[i].Length;
                    continue;
                }

                while (true)
                {

                    if (grid[i][mid] < 0)
                    {
                        max = mid;
                        mid -= (mid - mix) / 2;

                    }
                    else
                    if (grid[i][mid] >= 0)
                    {
                        mix = mid;
                        mid += (max - mid) / 2;

                    }



                    if (max - mix < 2)
                    {
                        count += grid[i].Length - max;

                        break;
                    }

                }

            }

            return count;
        }

        //更容易閱讀
        public static int CountNegatives2(int[][] grid)
        {
            int count = 0;

            for (int i = 0; i < grid.Length; i++)
            {
                count += grid[i].Count(x => x < 0);
            }

            return count;
        }







    }


}
