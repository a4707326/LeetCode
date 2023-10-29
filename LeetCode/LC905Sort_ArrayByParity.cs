using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC905Sort_ArrayByParity
    {
        public static void Start()
        {
            Console.WriteLine("LC905Sort_ArrayByParity");

            int[] nums = { 3, 1, 2, 4 };

            var ans = SortArrayByParity(nums);


            foreach (int i in ans) 
            {
                Console.WriteLine(i.ToString());
            }


        }

        //Input: nums = [3,1,2,4]
        //Output: [2,4,3,1]

        public static int[] SortArrayByParity(int[] nums)
        {
            int[] ans = new int[nums.Length];
            int positive = 0;
            int negative = nums.Length-1;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    ans[positive] = nums[i];
                    positive++;
                }
                else
                {
                    ans[negative] = nums[i];
                    negative--;

                }

            }

            return ans;
        }






    }


}
