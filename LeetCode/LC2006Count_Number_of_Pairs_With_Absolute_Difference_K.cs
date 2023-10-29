using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC2006Count_Number_of_Pairs_With_Absolute_Difference_K
    {
        public static void Start()
        {
            Console.WriteLine("LC2006Count_Number_of_Pairs_With_Absolute_Difference_K");


            var input1 = new int[] { 1, 2, 2, 1 };
            var input2 = 1;



            var ans = CountKDifference(input1, input2);


            Console.WriteLine(ans.ToString());

        }

        //Input: nums = [1,2,2,1], k = 1
        //Output: 4
        public static int CountKDifference(int[] nums, int k)
        {
            int count = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i+1; j < nums.Length; j++)
                {
                    if (Math.Abs(nums[i] - nums[j]) == k)
                    {
                        count++;
                    }
                }
            }

            return count;
        }


    }



}
