using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC2685_Count_the_Number_of_Complete_Components
    {

        //static List<int> componentNodeList;
        public static void Start()
        {
            Console.WriteLine("LC2685_Count_the_Number_of_Complete_Components");

            int n = 6;
            int[][] edges = new int[][] {
                new int[] {0, 1},
                new int[] {0, 2},
                new int[] {1, 2},
                new int[] {3, 4}
            };

            var ans = CountCompleteComponents(n, edges);
            Console.WriteLine(ans);


        }

        //Input: n = 6, edges = [[0,1],[0,2],[1,2],[3,4]]
        //Output: 3
        public static int CountCompleteComponents(int n, int[][] edges)
        {

            int count = 0;

            // 無向圖的初始化 鄰接列表(每個點(起始) 都有 所有到達目的地的點)
            List<int>[] adjList = new List<int>[n];

            //初始化陣列裡的list
            for (int i = 0; i < adjList.Length; i++)
            {
                adjList[i] = new List<int>();
            }
            //遍例所有的邊並加添目的地至對應的點
            foreach (var edge in edges)
            {
                //adjList[edge[0]]添加對應的目的地edge[1] 
                adjList[edge[0]].Add(edge[1]);
                //反過來添加 ，因為是無向的
                adjList[edge[1]].Add(edge[0]);
            }

            //紀錄所有點是否訪問過
            bool[] visiteds = new bool[n];

            for (int i = 0; i < n; i++)
            {
                if (!visiteds[i])
                {
                    //此次走過的點
                    List<int> componentNodeList = new List<int>();

                    DFS(adjList, visiteds,i , componentNodeList);

                    bool flag = false;

                    //遍例所有此次走過的點
                    foreach (int node in componentNodeList)
                    {
                        //如果任一點的邊小於經過的點-1 則不成立
                        if (adjList[node].Count < componentNodeList.Count - 1)
                        {
                            flag = true;
                            break;
                        }
                    }
                    if (!flag)
                        count++;
                }
            }

            return count;
        }
        public static void DFS(List<int>[] adjList, bool[] visiteds, int currNode, List<int> componentNodeList)
        {
            //紀錄此次走過的點
            componentNodeList.Add(currNode);

            //標記所有已走過的點
            visiteds[currNode] = true;

            foreach (var neighbor in adjList[currNode])
            {
                if (!visiteds[neighbor])
                {
                    DFS(adjList, visiteds, neighbor, componentNodeList);
                }
            }

        }





    }


}
