using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC1584_Min_Cost_to_Connect_All_Points
    {
        public static void Start()
        {
            Console.WriteLine("LC1584_Min_Cost_to_Connect_All_Points");



            int[][] points = new int[][] {
                new int[] {0, 0},
                new int[] {2, 2},
                new int[] {3, 10},
                new int[] {5, 2},
                new int[] {7, 0}
            };
            int[][] points2 = new int[][] {
                new int[] {2, 3},//1 //11+5
                new int[] {-17, -8},//2 //7
                new int[] {13, 8},//1
                new int[] {-17, -15}//2
            };

            var ans = MinCostConnectPoints2(points);


            Console.WriteLine(ans);

        }


        //Input: points = [[0,0],[2,2],[3,10],[5,2],[7,0]]
        //Output: 20
        //此答案不會過
        public static int MinCostConnectPoints(int[][] points)
        {
            if (points.Length < 2)
            {
                return 0;
            }
            int minCostSum = 0;
            Dictionary<int, int> connectedDict = new();

            for (int i = 0; i < points.Length; i++)
            {
                int min = int.MaxValue;
                int minIdx = 0;
                for (int j = 0; j < points.Length; j++)
                {
                    int cost = Math.Abs(points[i][0] - points[j][0]) + Math.Abs(points[i][1] - points[j][1]);

                    if (cost == 0) continue;

                    if (cost < min)
                    {
                        min = cost;
                        minIdx = j;
                    }
                }

                if (connectedDict.ContainsKey(minIdx) && connectedDict[minIdx] == i)
                {
                    continue;
                }

                connectedDict.Add(i, minIdx);
                minCostSum += min;
            }


            return minCostSum;
        }

        //這個解法使用了 Prim's 算法，它的時間複雜度為 O(n^2)，其中 n 是點的數量。這個算法首先選擇一個起始點，
        //然後通過選擇最小的相鄰邊來擴展最小生成樹，直到所有點都被訪問過。在這個過程中，我們紀錄了已經被訪問過的點，
        //以及到達每個點的最小距離。最終，返回所有選擇的邊的總和，這就是連接所有點的最小代價。
        //還未完全理解
        public static int MinCostConnectPoints2(int[][] points)
        {
            int[] minDistances = new int[points.Length];
            bool[] visited = new bool[points.Length];
            for (int i = 0; i < points.Length; i++)
            {
                minDistances[i] = int.MaxValue;
            }

            minDistances[0] = 0;
            int minCost = 0;

            for (int i = 0; i < points.Length; i++)
            {
                int u = -1;
                for (int j = 0; j < points.Length; j++)
                {
                    if (!visited[j] && (u == -1 || minDistances[j] < minDistances[u]))
                    {
                        u = j;
                    }
                }

                visited[u] = true;
                minCost += minDistances[u];

                for (int v = 0; v < points.Length; v++)
                {
                    int distance = Math.Abs(points[u][0] - points[v][0]) + Math.Abs(points[u][1] - points[v][1]);
                    if (!visited[v] && distance < minDistances[v])
                    {
                        minDistances[v] = distance;
                    }
                }
            }

            return minCost;
        }
    }

}

