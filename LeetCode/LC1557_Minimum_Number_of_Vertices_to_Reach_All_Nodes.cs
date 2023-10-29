using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC1557_Minimum_Number_of_Vertices_to_Reach_All_Nodes
    {
        public static void Start()
        {
            Console.WriteLine("LC1557_Minimum_Number_of_Vertices_to_Reach_All_Nodes");

            List<IList<int>> edges = new List<IList<int>> {
            new List<int> {0, 1},
            new List<int> {0, 2},
            new List<int> {2, 5},
            new List<int> {3, 4},
            new List<int> {4, 2}
            };

            int n = 6;

            var ans = FindSmallestSetOfVertices(n, edges);


            foreach (var i in ans) 
            {
                Console.WriteLine(i);
            }

        }

        //Input: n = 6, edges = [[0,1],[0,2],[2,5],[3,4],[4,2]]
        //Output: [0,3]
        //时间复杂度是O(n)，其中n是节点的数量//兩者的性能應該是相當的
        public static IList<int> FindSmallestSetOfVertices(int n, IList<IList<int>> edges)
        {
            List<int> ans = new List<int>();

            for (int i = 0; i < n; i++)
            {
                ans.Add(i);
            }

            for (int i = 0; i < edges.Count; i++)
            {
                if (ans.Contains(edges[i][1]))
                {
                    ans.Remove(edges[i][1]);
                }
            }
            return ans;
        }
        //的时间复杂度也是O(n)，其中n是节点的数//兩者的性能應該是相當的
        public static IList<int> FindSmallestSetOfVertices2(int n, IList<IList<int>> edges)
        {

            HashSet<int> hashSet = new();
            foreach (var edge in edges)
            {
                hashSet.Add(edge[1]);
            }

            List<int> ans = new ();
            for (int i = 0; i < n; i++)
            {
                if (!hashSet.Contains(i))
                {
                    ans.Add(i);
                }
            }

            return ans;
        }

    }



}
