using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC561_Array_Partition
    {
        public static void Start()
        {
            Console.WriteLine("LC561_Array_Partition");



            int[] nums = { 6, 2, 6, 5, 1, 2 };

            var ans = ArrayPairSum(nums);


            Console.WriteLine(ans);

        }

        //Input: nums = [6,2,6,5,1,2]
        //Output: 9
        static int ArrayPairSum(int[] nums)
        {
            int sum = 0;
            Array.Sort(nums);
            Array.Reverse(nums);
            for (int i = 0; i < nums.Length; i += 2)
            {
                sum += nums[i + 1];
            }
            return sum;
        }

    }



}
