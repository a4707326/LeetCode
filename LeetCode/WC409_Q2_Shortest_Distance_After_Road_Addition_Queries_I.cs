using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class WC409_Q2_Shortest_Distance_After_Road_Addition_Queries_I
    {
        public static void Start()
        {
            Console.WriteLine("WC409_Q2_Shortest_Distance_After_Road_Addition_Queries_I");


            int num = 5;

            int[][] jaggedArray = new int[][]
            {
                new int[] { 1,3 },
                new int[] { 2,4},
            };
            var ans = ShortestPath(num, jaggedArray);


            foreach (var i in ans)
            {
                Console.WriteLine(i.ToString());
            }



        }

        //Input: n = 5, queries = [[2,4],[0,2],[0,4]]

        //Output: [3,2,1]
        static int[] ShortestDistanceAfterQueries(int n, int[][] queries)
        {
            int[] road = new int[n];
            List<int> ans = new();


            for (int i = 0; i < n; i++)
            {
                road[i] = i;
            }

            for (int i = 0; i < queries.Length; i++)
            {

                for (int j = 0; j < road.Length; j++)
                {

                    if (road[j] > queries[i][0] && road[j] < queries[i][1] )
                    {
                        road[j] = -1;
                    }
                }

                int count = 0;
                for (int j = 1; j < road.Length; j++)
                {
                    if (road[j] != -1 )
                    {
                        count++;
                    }
                }
                ans.Add(count);
            }


            return ans.ToArray();
        }

        static int[] ShortestPath(int n, int[][] queries)
        {
            int[] ans = new int[queries.Length];
            List<int>[] graph = new List<int>[n];

            // 初始化圖
            for (int i = 0; i < n; i++)
            {
                graph[i] = new List<int>();
                if (i < n - 1)
                {
                    graph[i].Add(i + 1);
                }
            }

            for (int i = 0; i < queries.Length; i++)
            {
                int ui = queries[i][0];
                int vi = queries[i][1];
                graph[ui].Add(vi);

                ans[i] = BFS(graph, n);
            }

            int BFS(List<int>[] graph, int n)
            {
                Queue<int> queue = new Queue<int>();
                bool[] visited = new bool[n];
                int[] distance = new int[n];

                queue.Enqueue(0);
                visited[0] = true;

                while (queue.Count > 0)
                {
                    int current = queue.Dequeue();
                    foreach (int neighbor in graph[current])
                    {
                        if (!visited[neighbor])
                        {
                            visited[neighbor] = true;
                            distance[neighbor] = distance[current] + 1;
                            queue.Enqueue(neighbor);
                        }
                    }
                }

                return visited[n - 1] ? distance[n - 1] : -1;
            }

            return ans;
        }



    }



}
