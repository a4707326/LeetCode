using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class AAA
    {
        public static void Start()
        {
            // 讀取輸入的矩陣大小
            int n = 10;

            // 生成蛇形矩陣
            ;
            Console.WriteLine(GenerateSnakeMatrix(n));
            //// 打印矩陣
            //PrintMatrix(matrix, n);
        }


        static string GenerateSnakeMatrix(int n)
        {
            string ans = "";
            int oriAdd = 2;
            int oriNow = 1;


            for (int i = 0; i < n; i++)
            {
                int add = oriAdd;
                int now = oriNow;
                for (int j = 0; j < n-i; j++)
                {
                    ans += now + " ";
                    now += add;
                    add++;
                }
                oriNow += oriAdd - 1;
                oriAdd++;
                ans += "\n";
            }


            return ans;
        }


        //static void GenerateSnakeMatrix(int n)
        //{

        //    int[,] a = new int[n, n]; // 創建一個 n x n 的矩陣

        //    // 初始化變量
        //    int count = 2; // 填充起始值
        //    int x = 0, y = 0; // 當前座標

        //    a[0, 0] = 1; // 初始化第一個元素

        //    // 填充上三角部分
        //    for (int i = 1; i < n; i++) // 控制每一輪對角線
        //    {
        //        x = i;
        //        y = 0;
        //        while (x >= 0)
        //        {
        //            a[x, y] = count; // 填充當前位置
        //            count++;
        //            x--; // 向左上移動
        //            y++; // 向右移動
        //        }
        //    }

        //    // 打印矩陣
        //    for (int i = 0; i < n; i++)
        //    {
        //        for (int j = 0; j <= i; j++) // 只打印上三角部分
        //        {
        //            Console.Write(a[i, j] + " ");
        //        }
        //        Console.WriteLine(); // 換行
        //    }
        //}



        //// 生成蛇形矩陣的方法
        //static int[,] GenerateSnakeMatrix(int n)
        //{
        //    int[,] matrix = new int[n, n];
        //    int value = 1; // 矩陣中的起始值

        //    // 填充上三角部分（包括主對角線）
        //    for (int start = 0; start < n; start++)
        //    {
        //        for (int row = 0, col = start; col >= 0 && row < n; row++, col--)
        //        {
        //            matrix[row, col] = value++;
        //        }
        //    }

        //    // 填充下三角部分
        //    for (int start = 1; start < n; start++)
        //    {
        //        for (int row = start, col = n - 1; row < n && col >= 0; row++, col--)
        //        {
        //            matrix[row, col] = value++;
        //        }
        //    }

        //    return matrix;
        //}

        //// 打印矩陣的方法
        //static void PrintMatrix(int[,] matrix, int n)
        //{
        //    for (int i = 0; i < n; i++)
        //    {
        //        bool first = true; // 用於控制每行的空格格式
        //        for (int j = 0; j < n; j++)
        //        {
        //            if (matrix[i, j] != 0)
        //            {
        //                if (!first)
        //                    Console.Write(" ");
        //                Console.Write(matrix[i, j]);
        //                first = false;
        //            }
        //        }
        //        Console.WriteLine(); // 每行結束後換行
        //    }
        //}

    }



}
