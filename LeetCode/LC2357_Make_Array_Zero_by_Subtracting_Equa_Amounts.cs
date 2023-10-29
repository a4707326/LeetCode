using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC2357_Make_Array_Zero_by_Subtracting_Equa_Amounts
    {
        public static void Start()
        {
            Console.WriteLine("LC2357_Make_Array_Zero_by_Subtracting_Equa_Amounts");

            int[] nums = { 1, 5, 0, 3, 5 };

            var ans = MinimumOperations2(nums);
            Console.WriteLine(ans);


        }

        //Input: nums = [1,5,0,3,5]
        //Output: 3
        //Explanation:
        //In the first operation, choose x = 1. Now, nums = [0,4,0,2,4].
        //In the second operation, choose x = 2. Now, nums = [0,2,0,0,2].
        //In the third operation, choose x = 2. Now, nums = [0,0,0,0,0].
        //0,1,3,5,5

        //整个函数的时间复杂度是 O(n log n)。空间复杂度是 O(1)
        public static int MinimumOperations(int[] nums)
        {
            int count = 0;
            int max = 0;
            Array.Sort(nums);

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    count++;
                    max = nums[i];
                }
            }

            return count; 
        }

        //其时间复杂度为 O(n)，其中 n 是数组的长度。空间复杂度是 O(n)
        public static  int MinimumOperations2(int[] nums)
        {
            //var a = nums.Distinct();
            //var b = nums.Distinct().Where(x => x>0).Count();
            //var c = nums.Distinct().Count(x => x > 0);
            //var d = nums.Count(x => x > 0);


            return nums.Distinct().Count(x => x > 0);
        }







    }


}
