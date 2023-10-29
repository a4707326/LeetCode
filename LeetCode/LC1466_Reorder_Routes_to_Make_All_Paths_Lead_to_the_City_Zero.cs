using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC1466_Reorder_Routes_to_Make_All_Paths_Lead_to_the_City_Zero
    {
        static int count = 0; 
        public static void Start()
        {
            Console.WriteLine("LC1466_Reorder_Routes_to_Make_All_Paths_Lead_to_the_City_Zero");


            int n = 6;
            int[][] connections = { new int[] { 0, 1 }, new int[] { 1, 3 }, new int[] { 2, 3 }, new int[] { 4, 0 }, new int[] { 4, 5 } };

            var ans = MinReorder2(n,connections);


            Console.WriteLine(ans);

        }

        //Input: n = 6, connections = [[0,1],[1,3],[2,3],[4,0],[4,5]]
        //Output: 3
        //Time Limit Exceeded
        public static int MinReorder(int n, int[][] connections)
        {

            List<int[]> connectionsList = new List<int[]>(connections);

            //從0開始遍例所有的邊 (,當前位置，記錄我走過的地方)
            DFS(connectionsList, 0, -1);
            //判斷方向 如果有方向不正確即count++
            return count;
        }
        public static void DFS(List<int[]> connectionsList, int nowCity,int isArrivedEdge)
        {

            for (int i = 0; i < connectionsList.Count; i++)
            {
                if (isArrivedEdge == i)
                {
                    continue;
                }

                if (connectionsList[i][0] == nowCity)
                {
                    DFS(connectionsList, connectionsList[i][1], i);
                    count++;
                }
                else if (connectionsList[i][1] == nowCity)
                {
                    DFS(connectionsList, connectionsList[i][0], i);
                }

            }
        }

        public static int MinReorder2(int n, int[][] roads)
        {
            //int sign：這是一個指示道路方向的變數，1 表示正向，0 表示反向。
            //int conn：這是一個與當前城市相鄰的城市的編號。
            List<List<(int sign, int conn)>> adjList = new(); 
            int count = 0;

            //初始化
            for (int i = 0; i < n; i++) 
            {
                adjList.Add(new List<(int sign, int conn)>()); 
            }

            //遍例每一條路添加到對應的adjList
            foreach (int[] road in roads)
            {
                adjList[road[0]].Add((1, road[1])); //添加正向，連接城市
                adjList[road[1]].Add((0, road[0])); //添加反向，連接城市
            }

            DFS2(0, -1); //DFS from 0. 

            return count;

            void DFS2(int curr, int par)
            {
                foreach ((int sign, int conn) nei in adjList[curr])
                {
                    if (nei.conn == par) continue; //Don't want to go in a loop => skip parent in child

                    count += nei.sign; //Keep adding sign
                    DFS2(nei.conn, curr); //Do DFS on child using curr as parent
                }
            }
        }

    }



}
