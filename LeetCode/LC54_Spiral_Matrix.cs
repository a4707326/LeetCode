using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC54_Spiral_Matrix
    {

        public static void Start()
        {
            Console.WriteLine("LC100_Same_Tree");

            int[][] matrix = new int[][] {
                new int[] {1,2,3},
                new int[] {4,5,6},
                new int[] {7,8,9}
            };
            var ans = SpiralOrder(matrix);



            foreach (var val in ans)
            {
                Console.WriteLine($"{val.ToString()}");
            }



        }
        // Input: matrix = [[1,2,3],[4,5,6],[7,8,9]]
        // Output: [1,2,3,6,9,8,7,4,5]
        //猜O(N),O(N)
        //
        //LC
        public static IList<int> SpiralOrder(int[][] matrix)
        {
            List<int> list = new();
            int maxSteps = 0;
            for (int i = 0; i < matrix.Length; i++)
            {
                maxSteps += matrix[i].Length;
            }
            // int i = matrix[0].Length;

            int dir = 0;
            int x = -1;
            int y = 0;

            int rBorder = matrix[0].Length - 1;
            int lBorder = 0;
            int tBorder = 1;
            int dBorder = matrix.Length - 1;
            while (maxSteps > 0)
            {

                bool isGo = false;
                //>>
                if (dir == 0 && isGo == false)
                {
                    if (x < rBorder)//1
                    {
                        x++;
                        isGo = true;
                    }
                    if (x == rBorder)
                    {
                        dir = 1;
                        rBorder -= 1;
                    }
                }
                //__
                if (dir == 1 && isGo == false)
                {
                    if (y < dBorder)
                    {
                        y++;
                        isGo = true;
                    }
                    if (y == dBorder)
                    {
                        dir = 2;
                        dBorder -= 1;
                    }
                }
                //<<
                if (dir == 2 && isGo == false)
                {
                    if (x > lBorder)
                    {
                        x--;
                        isGo = true;
                    }
                    if (x == lBorder)
                    {
                        dir = 3;
                        lBorder += 1;
                    }
                }
                //^^
                if (dir == 3 && isGo == false)
                {
                    if (y > tBorder)
                    {
                        y--;
                        isGo = true;
                    }
                    if (y == tBorder)
                    {
                        dir = 0;
                        tBorder += 1;
                    }
                }
                list.Add(matrix[y][x]);
                maxSteps -= 1;

            }

            return list;
        }


    }


}
