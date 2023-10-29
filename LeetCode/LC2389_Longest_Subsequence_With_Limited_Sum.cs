using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC2389_Longest_Subsequence_With_Limited_Sum
    {
        public static void Start()
        {
            Console.WriteLine("LC2389_Longest_Subsequence_With_Limited_Sum");

            int[] nums = { 4, 5, 2, 1 };
            int[] queriess = { 3, 10, 21 };

            var ans = AnswerQueries(nums, queriess);


            foreach (int i in ans) 
            {
                Console.WriteLine(i.ToString());
            }


        }

        //Input: nums = [4,5,2,1], queries = [3,10,21]
        //Output: [2,3,4]

        public static int[] AnswerQueries(int[] nums, int[] queries)
        {
            return nums;
        }







    }


}
