using System;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC547_Number_of_Provinces
    {

        public static void Start()
        {
            Console.WriteLine("LC547_Number_of_Provinces");

            int[][] isConnected = new int[][] {
                new int[] {1,0,0,1},
                new int[] {0,1,1,0},
                new int[] {0,1,1,1},
                new int[] {1,0,1,1}
            };

            var ans = FindCircleNum(isConnected);

            Console.WriteLine(ans);



        }

        //Input: isConnected = [[1,1,0],[1,1,0],[0,0,1]]
        //Output: 2
        //你的算法的时间复杂度是 O(N^2)，其中 N 是城市的数量，因为你需要遍历每对城市来检查它们是否连接。在最坏的情况下，即所有城市互相连接，你需要遍历 N^2 个元素。
        //空间复杂度是 O(N)，用于存储 isArrived 数组。
        public static int FindCircleNum(int[][] isConnected)
        {
            int provincesCount = 0;
            bool[] isArrived = new bool[isConnected.Length];

            for (int i = 0; i < isConnected.Length; i++)
            {
                if (!isArrived[i])
                {
                    DFS(isArrived, isConnected, i);
                    provincesCount++;
                }
            }



            return provincesCount;
        }
        public static void DFS(bool[] isArrived ,int[][] isConnected,int nowCity) 
        {

            isArrived[nowCity] = true;//紀錄已到達城市

            for (int i = 0; i < isConnected[nowCity].Length; i++)//遍歷該城市所有連接的路
            {
                if (!isArrived[i] && isConnected[nowCity][i] == 1)//確認要去的城市有沒有去過，且該城市連接的路
                {
                    DFS(isArrived, isConnected, i);//出發
                }

            }


        }






    }


}
