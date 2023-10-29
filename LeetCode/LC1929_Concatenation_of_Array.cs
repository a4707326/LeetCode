using System;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC1929_Concatenation_of_Array
    {
        public static void Start()
        {
            Console.WriteLine("LC1929_Concatenation_of_Array");

            int[] nums = { 1, 2, 1 };

            var ans = GetConcatenation2(nums);


            foreach (int i in ans) 
            {
                Console.WriteLine(i.ToString());
            }


        }
        //Input: nums = [1,2,1]
        //Output: [1,2,1,1,2,1]
        //時間複雜度為 O(n)
        public static int[] GetConcatenation(int[] nums)
        {
            int[] output = new int[nums.Length * 2];

            for (int i = 0; i < nums.Length; i++)
            {
                output[i] = nums[i];
            }
            for (int j = 0; j < nums.Length; j++)
            {
                output[j + (nums.Length)] = nums[j];
            }

            return output;
        }



        public static int[] GetConcatenation2(int[] nums)
        {
            return nums.Concat(nums).ToArray();
        }



    }


}
