using System;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC39_Combination_Sum
    {
        //static List<IList<int>> ans = new();
        public static void Start()
        {
            Console.WriteLine("LC39_Combination_Sum");

            int[] candidates = { 2, 3, 6, 7 } ;
            int target = 7;
            var ans = CombinationSum2(candidates, target);

            foreach (var i in ans)
            {

                foreach (var j in i)
                {
                    Console.WriteLine(j);

                }
                Console.WriteLine("_");
            }





        }

        //Input: candidates = [2,3,6,7], target = 7
        //Output: [[2,2,3],[7]]
        //還未完成        //未解決重複問題
        public static IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            List<IList<int>> ans = new ();
            Backtracking(candidates, target, 0 ,new List<int>(), ans);


            return ans;
        }

        public static void Backtracking(int[] candidates, int target, int sum, List<int> sub, List<IList<int>> ans)
        {
            //中止條件
            if (sum > target )
            {
                return;
            }
            //找答案
            if (sum == target)
            {
                ans.Add(new List<int>(sub));
                return;
            }


            //循環
            for (int i = 0; i < candidates.Length; i++)
            {
                sum += candidates[i];
                sub.Add(candidates[i]);
                Backtracking(candidates, target, sum, sub, ans);
                sum -= candidates[i];
                sub.RemoveAt(sub.Count-1);

            }

        }


        //解決重複問題
        public static IList<IList<int>> CombinationSum2(int[] candidates, int target)
        {
            List<IList<int>> ans = new();
            Backtracking2(candidates, target, 0, new List<int>(), ans, 0);
            return ans;
        }
        public static void Backtracking2(int[] candidates, int target, int sum, List<int> sub, List<IList<int>> ans, int start)
        {
            //中止條件
            if (sum > target)
            {
                return;
            }
            //找答案
            if (sum == target)
            {
                ans.Add(new List<int>(sub));
                return;
            }

            //循環
            for (int i = start; i < candidates.Length; i++)
            {
                sum += candidates[i];
                sub.Add(candidates[i]);
                Backtracking2(candidates, target, sum, sub, ans, i);
                sum -= candidates[i];
                sub.RemoveAt(sub.Count - 1);
            }

        }




    }


}
