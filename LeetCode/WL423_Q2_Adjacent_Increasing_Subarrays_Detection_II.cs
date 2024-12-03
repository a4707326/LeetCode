using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class WL423_Q2_Adjacent_Increasing_Subarrays_Detection_II
    {
        public static void Start()
        {
            Console.WriteLine("WL423_Q2_Adjacent_Increasing_Subarrays_Detection_II");


            int[] nums = { 2, 5, 7, 8, 9, 2, 3, 4, 3, 1 };
            //int[] nums = { 1, 2, 3, 4, 4, 4, 4, 5, 6, 7 };

            var ans = MaxIncreasingSubarrays(nums);
            
 


            Console.WriteLine(ans);

        }


        //Input: nums = [2,5,7,8,9,2,3,4,3,1], k = 3
        //Output: true
        static int MaxIncreasingSubarrays(IList<int> nums)
        {
            int n = nums.Count;
            
            //n = 10
            // 計算每個inc的最大遞增長度
            int[] incLen = new int[n];
            incLen[0] = 1;
            for (int i = 1; i < n; i++)
            {
                //後面大於前面
                if (nums[i] > nums[i - 1])
                {
                    //前一個++
                    incLen[i] = incLen[i - 1] + 1;
                }
                else
                {
                    //否則為1
                    incLen[i] = 1;
                }
            }

            //incLen[1, 2, 3, 4, 5, 1, 2, 3, 1, 1]
            // 二分搜索
            int left = 1, right = n / 2;
            int maxK = 0;

            while (left <= right)
            {
                int k = left + (right - left) / 2;
                bool isFound = false;
                for (int i = 0; i + 2 * k - 1 < n; i++)
                {
                    // 檢查條件
                    if (incLen[i + k - 1] >= k && incLen[i + 2 * k - 1] >= k)
                    {
                        isFound = true;
                        break;
                    }
                }
                if (isFound)
                {
                    maxK = k;
                    left = k + 1;
                }
                else
                {

                    right = k - 1;
                }
            }


            return maxK;
        }

    }



}
