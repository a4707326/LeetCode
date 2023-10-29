using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC704_Binary_Search
    {
        public static void Start()
        {
            Console.WriteLine("LC704_Binary_Search");

            int[] nums = { -1, 0, 3, 5, 9 };
            int target = 9;

            var ans = Search(nums, target);
            Console.WriteLine(ans.ToString());


            //foreach (int i in ans) 
            //{
            //    Console.WriteLine(i.ToString());
            //}


        }

        //Input: nums = [-1,0,3,5,9,12], target = 9
        //Input: nums = [-1,0,3,5,9], target = 9
        //Output: 4
        public static int Search(int[] nums, int target)
        {

            int right = nums.Length - 1;
            int left = 0;
            int mid = 0;

            while (left <= right) //這裡的條件可防止超出(找不到目標)，如果不會超出用 ture也是可以的
            {
                mid = (left + right) / 2;

                if (nums[mid] > target)
                {
                    right = mid - 1;

                }else if (nums[mid] < target) 
                {
                    left = mid + 1;
                }
                else 
                {
                    return mid;
                }

            }
            return -1; //條件可防止超出(找不到目標)返回-1
        }







    }


}
