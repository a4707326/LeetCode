using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class WC410_Q2_Count_the_Number_of_Good_Nodes
    {
        public static void Start()
        {
            Console.WriteLine("WC410_Q2_Count_the_Number_of_Good_Nodes");

            //int[][] edges = new int[][]
            //{
            //    new int[] { 0, 1 },
            //    new int[] { 0, 2 },
            //    new int[] { 1, 3 },
            //    new int[] { 1, 4 },
            //    new int[] { 2, 5 },
            //    new int[] { 2, 6 }
            //};

            int[][] edges = new int[][]
            {
                new int[] { 0, 1 },
                new int[] { 1, 2 },
                new int[] { 2, 3 },
                new int[] { 3, 4 },
                new int[] { 0, 5 },
                new int[] { 1, 6 },
                new int[] { 2, 7 },
                new int[] { 3, 8 }
            };

            var ans = CountGoodNodes(edges);


            Console.WriteLine(ans);

        }

        //Input: edges = [[0,1],[0,2],[1,3],[1,4],[2,5],[2,6]]
        //Output: 7
        //Input: edges = [[0,1],[1,2],[2,3],[3,4],[0,5],[1,6],[2,7],[3,8]]
        //Output: 6
        static int CountGoodNodes(int[][] edges)
        {
            int n = edges.Length + 1;  // 節點數量
            List<int>[] tree = new List<int>[n];
            for (int i = 0; i < n; i++)
            {
                tree[i] = new List<int>();
            }
            // 建構鄰接表
            foreach (var edge in edges)
            {
                tree[edge[0]].Add(edge[1]);
                tree[edge[1]].Add(edge[0]);
            }

            int[] subtreeSizes = new int[n];
            bool[] visited = new bool[n];


            // 計算每個節點的子樹大小
            DFS(0, -1, subtreeSizes);

            visited = new bool[n];  // 重置訪問標記
            int goodNodesCount = 0;

            // 再次DFS檢查每個節點是否是好節點
            CheckGoodNodes(0, -1, subtreeSizes);



            int DFS(int node, int parent, int[] subtreeSizes)
            {
                visited[node] = true;
                int size = 1;

                foreach (var neighbor in tree[node])
                {
                    if (neighbor != parent && !visited[neighbor])
                    {
                        size += DFS(neighbor, node, subtreeSizes);
                    }
                }
                subtreeSizes[node] = size;
                return size;
            }

            void CheckGoodNodes(int node, int parent, int[] subtreeSizes)
            {
                visited[node] = true;
                HashSet<int> subSizes = new ();

                //將子節點放入subSizes,ex(7,1)
                foreach (var neighbor in tree[node])
                {
                    if (neighbor != parent)
                    {
                        subSizes.Add(subtreeSizes[neighbor]);
                    }
                }
                //如果所有子樹大小相同或沒有子節點，都是好節點
                if (subSizes.Count <= 1)
                {
                    goodNodesCount++;
                }

                //繼續判斷下一個節點
                foreach (var neighbor in tree[node])
                {
                    if (!visited[neighbor])
                    {
                        CheckGoodNodes(neighbor, node, subtreeSizes);
                    }
                }
            }

            return goodNodesCount;
        }







    }


}
