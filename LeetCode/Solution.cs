using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Solution
    {
        //{ 0, 2, 1, 5, 3, 4 }
        //012
        public int[] BuildArray(int[] nums)
        {
            Console.WriteLine("BuildArray");

            int[] ints = new int[nums.Length];
            foreach (int i in nums) 
            {
                ints[i] = nums[nums[i]];
            }

            foreach (int i in ints)
            {
                Console.WriteLine(i);

            }
            return ints;
        }

    }
}
