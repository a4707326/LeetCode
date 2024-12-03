using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class WL423_Q1_Adjacent_Increasing_Subarrays_Detection_I
    {
        public static void Start()
        {
            Console.WriteLine("WL423_Q1_Adjacent_Increasing_Subarrays_Detection_I");


            int[] nums = { -15, 19 };
            //int[] nums = { 1, 2, 3, 4, 4, 4, 4, 5, 6, 7 };

            int num = 1;

            var ans = HasIncreasingSubarrays(nums, num);
            
 


            Console.WriteLine(ans);

        }


        //Input: nums = [2,5,7,8,9,2,3,4,3,1], k = 3
        //Output: true
        //static bool HasIncreasingSubarrays(IList<int> nums, int k)
        //{
        //    int n = nums.Count;
        //    int count = 0;


        //    //n = 10
        //    for (int i = 0; i <= n - k - 1; i++)
        //    {

        //        if (IsIncreasing(i, k))
        //        {
        //            count++;
        //        }

        //        //if (IsIncreasing(i, k) && IsIncreasing(i + k, k))
        //        //{
        //        //    return true;
        //        //}
        //    }



        //    // 判斷一個子數組是否遞增
        //    bool IsIncreasing(int start, int len)
        //    {
        //        for (int i = start; i < start + len; i++)
        //        {
        //            if (nums[i] >= nums[i + 1])
        //            {
        //                return false;
        //            }
        //        }
        //        return true;
        //    }

        //    if (count >= 2)return true;

        //    return false;
        //}

        static bool HasIncreasingSubarrays(IList<int> nums, int k)
        {
            int n = nums.Count;


            for (int i = 0; i <= n - 2 * k; i++)
            {
                if (IsIncreasing(i, k) && IsIncreasing(i + k, k))
                {
                    return true;
                }
            }

            // 判斷一個子數組是否嚴格遞增
            bool IsIncreasing(int start, int len)
            {
                for (int i = start; i < start + len - 1; i++)
                {
                    if (nums[i] >= nums[i + 1])
                    {
                        return false;
                    }
                }
                return true;
            }

            return false;
        }

    }



}
