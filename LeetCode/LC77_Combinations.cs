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
    internal class LC77_Combinations
    {

        public static void Start()
        {
            Console.WriteLine("LC77_Combinations");

            int n = 4;
            int k = 2;

            var ans = Combine(n,k);


            foreach (var i in ans)  
            {
                Console.WriteLine("_");

                foreach (var j in i)
                {
                    Console.WriteLine(j);

                }
            }


        }
        //Input: n = 4, k = 2
        //Output: [[1,2],[1,3],[1,4],[2,3],[2,4],[3,4]]
        public static IList<IList<int>> Combine(int n, int k)
        {
            List<IList<int>> ans = new();
            Backtracking(n, k, new List<int>(), ans, 1);
            return ans;
        }


        public static void Backtracking(int n, int k, List<int> sub, IList<IList<int>> ans, int start )
        {
            //中止條件
            if (sub.Count > k)
            {
                return;
            }
            //找答案
            if (sub.Count == k)
            {
                ans.Add(new List<int>(sub));
                return;
            }


            //循環

            for (int i = start; i < n+1; i++)
            {
                sub.Add(i);
                Backtracking(n, k, sub, ans, start+1);
                sub.RemoveAt(sub.Count-1);
                start += 1;
            }
        }

    }


}
