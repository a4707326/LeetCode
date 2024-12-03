using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class WC409_Q1_Design_Neighbor_Sum_Service
    {
        public static void Start()
        {
            Console.WriteLine("WC409_Q1_Design_Neighbor_Sum_Service");


            int[][] jaggedArray = new int[][]
               {
                new int[] { 0, 1, 2 },
                new int[] { 3, 4, 5 },
                new int[] { 6, 7, 8 }
               };

            //var ans = TFunc(nums, num);
            neighborSum(jaggedArray);
            Console.WriteLine(AdjacentSum(4));
            Console.WriteLine(DiagonalSum(4));

        }

        //        Input:

        //["neighborSum", "adjacentSum", "adjacentSum", "diagonalSum", "diagonalSum"]

        //        [[[[0, 1, 2], [3, 4, 5], [6, 7, 8]]], [1], [4], [4], [8]]

        //Output: [null, 6, 16, 16, 4]

        static int[][] myGrid;
        static void neighborSum(int[][] grid)
        {
            myGrid = grid;

        }

        static int AdjacentSum(int value)
        {
            for (int i = 0; i < myGrid.Length; i++)
            {
                for (int j = 0; j < myGrid[i].Length; j++)
                {
                    if (myGrid[i][j] == value)
                    {
                        int sum = 0;
                        if (i > 0)
                        {
                            sum += myGrid[i - 1][j];
                        }
                        if (i + 1 < myGrid.Length )
                        {
                            sum += myGrid[i + 1][j];
                        }

                        if (j > 0)
                        {
                            sum += myGrid[i][j-1];
                        }
                        if (j + 1 < myGrid.Length)
                        {
                            sum += myGrid[i][j + 1];
                        }
                        return sum;
                    }
                }
            }
            return 0;

        }

        static int DiagonalSum(int value)
        {
            for (int i = 0; i < myGrid.Length; i++)
            {
                for (int j = 0; j < myGrid[i].Length; j++)
                {
                    if (myGrid[i][j] == value)
                    {
                        int sum = 0;
                        if (i > 0 && j > 0)
                        {
                            sum += myGrid[i - 1][j - 1];
                        }
                        if (i > 0 && j + 1 < myGrid.Length)
                        {
                            sum += myGrid[i - 1][j + 1];
                        }
                        if (i + 1 < myGrid.Length && j > 0 )
                        {
                            sum += myGrid[i + 1][j - 1];
                        }
                        if (i + 1 < myGrid.Length && j + 1 < myGrid.Length)
                        {
                            sum += myGrid[i + 1][j +1];
                        }

                        return sum;
                    }
                }
            }
            return 0;

        }
    }



}
