using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC2529_Maximum_Count_of_Positive_Integer_and_Negative_Integer
    {
        public static void Start()
        {
            Console.WriteLine("LC2529_Maximum_Count_of_Positive_Integer_and_Negative_Integer");

            int[] nums = { -2, -1, -1, 1, 2, 3 };

            var ans = MaximumCount3(nums);

            Console.WriteLine(ans.ToString());

        }


        //Input: nums = [-2,-1,-1,1,2,3]
        //Output: 3
        public static int MaximumCount(int[] nums)
        {
            int pos = 0;
            int neg = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < 0)
                {
                    neg++;
                }
                else if (nums[i] > 0)
                {
                    pos++;
                }
            }

            return Math.Max(pos, neg);   
        }

        public static int MaximumCount2(int[] nums)
        {
            int pos = 0;
            int neg = 0;
            int zero = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < 0)
                {
                    neg++;
                }
                else if (nums[i] == 0)
                {
                    zero++;
                }
                else 
                {
                    pos = nums.Length - neg - zero;
                    break;
                }
            }

            return Math.Max(pos, neg);
        }

        //Input: nums = [-2,-1,-1,1,2,3]
        //3,1 。
        //1,-1。
        //2,-1。
        //2,-1。
        //R 3
        //L 3
        //MAX = 3 

        //效能更好，但不易閱讀，但是經典2分法收尋
       // 走2變是為了去0
        public static int MaximumCount3(int[] nums)
        {
            int l = 0;
            int r = nums.Length;
            int mid = 0;

            while (l < r)
            {
                mid = (l + r) / 2;

                if (nums[mid] >= 0)
                {
                    r = mid;
                }
                else
                {
                    l = mid + 1;
                }
            }

            var max = l;
            l = 0;
            r = nums.Length;
            mid = 0;

            while (l < r)
            {
                mid = (l + r) / 2;

                if (nums[mid] < 1)
                {
                    l = mid + 1;
                }
                else
                {
                    r = mid;
                }
            }

            return Math.Max(nums.Length - l, max);
        }

    }


}
