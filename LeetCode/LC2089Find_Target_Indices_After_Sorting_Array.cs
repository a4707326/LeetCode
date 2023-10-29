using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC2089Find_Target_Indices_After_Sorting_Array
    {
        public static void Start()
        {
            Console.WriteLine("LC2089Find_Target_Indices_After_Sorting_Array");

            int[] nums = { 1, 2, 5, 2, 3 };
            int target = 2;

            var ans = TargetIndices(nums, target);


            foreach (int i in ans) 
            {
                Console.WriteLine(i.ToString());
            }


        }

        //Input: nums = [1,2,5,2,3], target = 2
        //Output: [1,2]
        //Explanation: After sorting, nums is [1,2,2,3,5].
        public static IList<int> TargetIndices(int[] nums, int target)
        {
            List<int> ans = new();
            Array.Sort(nums);

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                { 
                    ans.Add(i);
                }
            }

            return ans;
        }
        //效率更好但比上面不易閱讀理解
        public static IList<int> TargetIndices2(int[] nums, int target)
        {
            List<int> nos = new List<int>();
            int startSkip = 0;
            int endSkip = 0;
            foreach (int num in nums)
            {
                if (num > target)
                {
                    endSkip++;
                }
                if (num < target)
                {
                    startSkip++;
                }
            }

            for (int i = startSkip; i < nums.Length - endSkip; i++)
            {
                nos.Add(i);
            }

            return nos;
        }





    }


}
