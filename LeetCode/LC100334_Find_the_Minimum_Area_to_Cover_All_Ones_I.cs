using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC100334_Find_the_Minimum_Area_to_Cover_All_Ones_I
    {
        static bool isSame = true;
        public static void Start()
        {
            Console.WriteLine("LC100334_Find_the_Minimum_Area_to_Cover_All_Ones_I");

            //int[][] grid = new int[][]
            //{
            //new int[] { 0, 1, 0 },
            //new int[] { 1, 0, 1 }
            //};
//            int[][] grid = new int[][]
//{
//            new int[] { 0, 1 }

//};

            int[][] grid = new int[][]
{
            new int[] { 0, 0, 0 },
            new int[] { 0, 0, 0 },
            new int[] { 0, 0, 1 },
            new int[] { 0, 1, 0 }
};

            var ans = MinimumArea(grid);

            Console.WriteLine(ans);
            //Console.WriteLine{ans.ToString());

            //foreach ( var val in valList) 
            //{
            //    //Console.WriteLine($"{val.ToString()}");
            //}



        }

        //WC
        static int MinimumArea(int[][] grid)
        {
            int h = 0;
            int w = 0;
            int maxW = 0;
            int minW = 99999;
            List<int> list = new List<int>();

            for (int i = 0; i < grid.Length; i++)
            {

                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        maxW = Math.Max(maxW, j);
                        minW = Math.Min(minW, j);
                    }
                }

                for (int j = 0; j < grid[i].Length; j++)
                {
                    if ((grid[i][j]) == 1)
                    {
                        list.Add(i);
                        break;
                    }

                }

            }
            h = (list[list.Count-1] - list[0]) + 1;
            w = (maxW - minW) + 1;

            return w * h;
        }



    }


}
