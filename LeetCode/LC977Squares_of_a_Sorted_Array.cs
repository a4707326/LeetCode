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
    internal class LC977Squares_of_a_Sorted_Array
    {
        public static void Start()
        {
            Console.WriteLine("LC977Squares_of_a_Sorted_Array");

            int[] nums = { -4, -1, 0, 3, 10 };

            var ans = SortedSquares(nums);


            foreach (int i in ans) 
            {
                Console.WriteLine(i.ToString());
            }


        }

        //Input: nums = [-4,-1,0,3,10]
        //Output: [0,1,9,16,100]
        public static int[] SortedSquares(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] =  nums[i]  * nums[i];
            }
            Array.Sort(nums);
            return nums;

        }







    }


}
