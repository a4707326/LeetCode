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
    internal class LC1572_Matrix_Diagonal_Sum
    {
        public static void Start()
        {
            Console.WriteLine("LC1572_Matrix_Diagonal_Sum");
            int[][] matrix = new int[][] {
            new int[] {7, 3, 1, 9},
            new int[] {3, 4, 6, 9},
            new int[] {6, 9, 6, 6},
            new int[] {9, 5, 8, 5}
        };

            var ans = DiagonalSum(matrix);

            Console.WriteLine(ans);



        }


        // Input: mat = [[1,2,3],
        //               [4,5,6],
        //               [7,8,9]]
        // Output: 25
        //猜O(N),O[N]
        //O(N),O(1) 空間因為只算而外使用，所以是1
        //BF
        //LC
        public static int DiagonalSum(int[][] mat)
        {
            //遍例1次 最後依int[].Length來判斷要不要去中間的

            int sum = 0;
            int rowLen = mat[0].Length;
            for (int i = 0, j = rowLen - 1; i < rowLen; i++, j--)
            {
                sum += mat[i][i];//左上至右下
                sum += mat[i][j];//右上至左下
            }
            if (rowLen % 2 == 1)
            {
                sum -= mat[rowLen / 2][rowLen / 2];//因為為單數中間會重複2次所以去掉一次
            }

            return sum;
        }
        //7 +4 +6 +5  =22
        //9+6+9+9 = 33
        //[7,3,1,9]
        //[3,4,6,9]
        //[6,9,6,6]
        //[9,5,8,5]



    }


}
