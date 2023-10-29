
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LeetCode
{
     public class BuildArrayfromPermutation
    {

        public static void Start()
        {
            Console.WriteLine("BuildArrayfromPermutation");

            var ints = BuildArray(new int[] { 0, 2, 1, 5, 3, 4 });
            foreach (int i in ints)
            {
                Console.WriteLine(i);
            }

            
        }

        //{ 0, 2, 1, 5, 3, 4 }
        //012
        public static int[] BuildArray(int[] nums)
        {
            int[] ints = new int[nums.Length];
            foreach (int i in nums)
            {
                ints[i] = nums[nums[i]];
            }
            return ints;
        }



    }
}
