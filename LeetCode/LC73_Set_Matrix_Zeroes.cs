using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC73_Set_Matrix_Zeroes
    {

        public static void Start()
        {
            Console.WriteLine("LC73_Set_Matrix_Zeroes");

            int[][] matrix = new int[][] {
                new int[] {1,3,1},
                new int[] { 1, 5, 1 },
                new int[] { 4, 2, 1 }
            };
            //var ans = SetZeroes(matrix);


            //Console.WriteLine(ans);


        }
        // Input: matrix = [[1,1,1],[1,0,1],[1,1,1]]
        // Output: [[1,0,1],[0,0,0],[1,0,1]]
        //猜O(N*M)，O(N*M)
        //O(N*M)，O(N*M)
        //LC ，Sol
        public void SetZeroes(int[][] matrix)
        {
            int rowCount = matrix.Length;
            int colCount = matrix[0].Length;

            HashSet<int> rowSet = new();
            HashSet<int> colSet = new();

            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < colCount; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        rowSet.Add(i);
                        colSet.Add(j);
                    }
                }
            }

            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < colCount; j++)
                {
                    if (rowSet.Contains(i) || colSet.Contains(j))
                        matrix[i][j] = 0;
                }
            }
        }


    }


}
