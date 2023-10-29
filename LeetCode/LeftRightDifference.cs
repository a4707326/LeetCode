using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class LeftRightDifference
    {
        public static void Start()
        {
            Console.WriteLine("LeftRightDifference");

            var input = new int[] { 10, 4, 8, 3 };

            var ans = Solution(input);
  
            foreach (int i in ans) 
            {
                Console.WriteLine(i);
            }




        }

        //Input: nums = [10,4,8,3]
        //Output: [15,1,11,22]

        public static int[] Solution(int[] nums)
        {
            int[] reNums = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {

                for (int j = 0; j < nums.Length; j++)
                {
                    if (i > j)
                    {
                        reNums[i] += nums[j];
                    }
                    else if(i < j)
                    {
                        reNums[i] -= nums[j];
                    }

                }
                reNums[i] = Math.Abs(reNums[i]);
            }


            return reNums;
        }

        public int[] Solution2(int[] nums)
        {
            var leftSum = 0;
            var rightSum = nums.Sum();

            for (var i = 0; i < nums.Length; i++)
            {
                var val = nums[i];
                rightSum -= val;

                nums[i] = Math.Abs(leftSum - rightSum);
                leftSum += val;
            }

            return nums;
        }
    }



}
