using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC506_Relative_Ranks
    {
        public static void Start()
        {
            Console.WriteLine("LC506_Relative_Ranks");



            int[] nums = { 5, 4, 3, 2, 1 };


            var ans = FindRelativeRanks(nums);


            foreach (var i in ans)
            {
                Console.WriteLine(i.ToString());
            }


        }


        //Input: score = [5,4,3,2,1]
        //Output: ["Gold Medal","Silver Medal","Bronze Medal","4","5"]
        //Explanation: The placements are[1st, 2nd, 3rd, 4th, 5th].
        static string[] FindRelativeRanks(int[] score)
        {
            int[] sorted = new int[score.Length];
            Array.Copy(score, sorted, score.Length);
            Array.Sort(sorted);
            Array.Reverse(sorted);
            string[] ans = new string[score.Length];

            for (int i = 0; i < ans.Length; i++)
            {
                if (sorted.Length > 0 && score[i] == sorted[0])
                {
                    ans[i] = "Gold Medal";
                }
                else if (sorted.Length > 1 && score[i] == sorted[1])
                {
                    ans[i] = "Silver Medal";
                }
                else if (sorted.Length > 2 && score[i] == sorted[2])
                {
                    ans[i] = "Bronze Medal";
                }
                else
                {
                    for (int j = 0; j < sorted.Length; j++)
                    {
                        if (sorted[j] == score[i])
                        {
                            ans[i] = (j+1).ToString();
                        }
                    }
                }
            }


            return ans;
        }
    }



}
