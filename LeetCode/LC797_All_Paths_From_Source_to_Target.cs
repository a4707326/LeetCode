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
    internal class LC797_All_Paths_From_Source_to_Target
    {
        public static void Start()
        {
            Console.WriteLine("LC797_All_Paths_From_Source_to_Target");

            int[][] graph = new int[][]
            {
                new int[] {1, 2},
                new int[] {3},
                new int[] {3},
                new int[] {}
            };

            var ans = AllPathsSourceTarget(graph);


            foreach (var i in ans) 
            {

                foreach (var j in i)
                {
                    Console.WriteLine(j);
                }
                Console.WriteLine(",");
            }


        }

        //0 > 1or2 > 

        //Input: graph = [[1,2],[3],[3],[]]
        //Output: [[0,1,3],[0,2,3]]
        //Explanation: There are two paths: 0 -> 1 -> 3 and 0 -> 2 -> 3.

        //
        //Input: graph = [[4,3,1],[3,2,4],[3],[4],[]]
        //Output: [[0,4],[0,3,4],[0,1,3,4],[0,1,2,3,4],[0,1,4]]

        // 時間和空間都為 O(2^N)
        public static IList<IList<int>> AllPathsSourceTarget(int[][] graph)
        {
            List<IList<int>> result = new List<IList<int>>();
            List<int> path = new List<int>();
            path.Add(0);
            DFS(graph, 0, graph.Length - 1, path, result);
            return result;
        }

        private static void DFS(int[][] graph, int node, int target, List<int> path, List<IList<int>> result)
        {
            if (node == target)
            {
                result.Add(new List<int>(path));
                return;
            }
            //0>1>3
            //
            foreach (int neighbor in graph[node])
            {
                path.Add(neighbor);
                DFS(graph, neighbor, target, path, result);
                path.RemoveAt(path.Count - 1);
            }
        }






    }


}
