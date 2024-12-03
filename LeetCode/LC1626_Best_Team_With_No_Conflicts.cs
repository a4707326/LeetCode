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
    internal class LC1626_Best_Team_With_No_Conflicts
    {
        public static void Start()
        {
            Console.WriteLine("LC1626_Best_Team_With_No_Conflicts");



            int[] nums = { 4, 5, 6, 5 };
            int[] nums2 = { 2, 1, 2, 1 };

            var ans = BestTeamScore(nums, nums2);
            
 


            Console.WriteLine(ans);

        }

        //Input: scores = [4,5,6,5], ages = [2,1,2,1]
        //Output: 16

        static int BestTeamScore(int[] scores, int[] ages)
        {
            var res = ages.Zip(scores, (a, s) => (Age: a, Score: s))
            .OrderBy(p => p.Age)//主要排序
            .ThenBy(p => p.Score)//次要排序
            .Select(p => (Score: p.Score, Dp: p.Score))
            .ToArray();

            int n = scores.Length;

            for (int i = 0; i < n; i++)
            {

                foreach (var (score, dp) in res[..i])//[..i]  = 從0到i
                {
                    if (score <= res[i].Score)
                    {
                        res[i].Dp = Math.Max(dp + res[i].Score, res[i].Dp);
                    }
                }
            }

            return res.Max(x => x.Dp);
        }

    }



}
