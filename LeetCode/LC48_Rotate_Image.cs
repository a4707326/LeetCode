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
    internal class LC48_Rotate_Image
    {
        public static void Start()
        {
            Console.WriteLine("LC48_Rotate_Image");
                int[][] matrix = new int[][] {
                new int[] {1,2,3},
                new int[] {4,5,6},
                new int[] {7,8,9}
            };

            Rotate(matrix);

            //Console.WriteLine(ans);



        }


        //[1,2,3]
        //[4,5,6]
        //[7,8,9]

        //[1,4,7]
        //[2,5,8]
        //[3,6,9]

        //[7,4,1]
        //[8,5,2]
        //[9,6,3]


        // 0 0
        // 0 1

        //1,0 ,0,1

        // Input: matrix = [[1,2,3],[4,5,6],[7,8,9]]
        // Output: [[7,4,1],[8,5,2],[9,6,3]]
        //O(N^2)， O(1)
        //LC GPT
        public static void Rotate(int[][] matrix)
        {
            int n = matrix.Length;
            // 先對稱翻轉矩陣
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    int temp = matrix[i][j];
                    matrix[i][j] = matrix[j][i];
                    matrix[j][i] = temp;
                }
            }
            // 再對每一行進行反轉
            for (int i = 0; i < n; i++)
            {
                Array.Reverse(matrix[i]);
            }
        }


    }


}
