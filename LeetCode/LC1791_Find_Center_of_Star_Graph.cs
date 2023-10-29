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
    internal class LC1791_Find_Center_of_Star_Graph
    {
        public static void Start()
        {
            Console.WriteLine("LC1791_Find_Center_of_Star_Graph");

            //int[] nums = { -4, -1, 0, 3, 10 };

            int[][] edges = new int[][] {
                new int[] {1, 4},
                new int[] {4, 3},
                new int[] {2, 4},
            };

            var ans = FindCenter2(edges);

            Console.WriteLine(ans);

            //foreach (int i in ans) 
            //{
            //    Console.WriteLine(i.ToString());
            //}


        }

        //Input: edges = [[1,2],[2,3],[4,2]]
        //Output: 2
        //時間複雜度是 O(E * V)，其中 E 是邊的數量，V 是點的數量
        public static int FindCenter(int[][] edges)
        {
            for (int i = 0; i < 2; i++)
            {
                int target = edges[0][i];

                int count = 0;
                foreach (var edge in edges)
                {
                    if (edge[0] == target || edge[1] == target)
                    {
                        count++;
                        if (count == edges.Length) return target;
                    }
                }
            }
            return 0;
        }

        //這段代碼的時間複雜度是 O(1)，
        public static int FindCenter2(int[][] edges)
        {
            if (edges[0][0] == edges[1][0] || edges[0][0] == edges[1][1])
            {
                return edges[0][0];
            }
            else
            {
                return edges[0][1];
            }
        }




    }


}
