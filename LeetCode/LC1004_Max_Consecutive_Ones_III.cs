using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC1004_Max_Consecutive_Ones_III
    {
        public static void Start()
        {
            Console.WriteLine("LC1004_Max_Consecutive_Ones_III");



            int[] nums = { 0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 1, 1, 0, 0, 0, 1, 1, 1, 1 };

            int num = 3;
 

            var ans = LongestOnes2(nums, num);

            Console.WriteLine(ans);

        }
        //Input: nums = [1,1,1,0,0,0,1,1,1,1,0], k = 2
        //Output: 6

        //[0,0,1,1,0,0,1,1,1,0,1,1,0,0,0,1,1,1,1], k = 3
        //Output: 10

        //[0,0,1,1,*,*,1,1,1,*,1,1,0,0,0,1,1,1,1], k = 3
        //[0,1,2,3,4,5,6,7,8,9,0,1,2,3,4,5,6,7,8], 
        //[0,0,1,1,*,*,1,1,1,*,1,1
        //[0,0,1,1,0,*,1,1,1,*,1,1,0,0,*      

        static int LongestOnes(int[] nums, int k)
        {
            int usedK = 0;
            int max = 0;
            int count = 0;
            int right = 0;

            while (right < nums.Length)
            {
                if (nums[right] == 1)
                {
                    count++;
                }
                else if (usedK < k)
                {
                    count++;
                    usedK++;

                }
                else
                {
                    right = right - count;
                    usedK = 0;
                    count = 0;
                }

                max = Math.Max(max, count);
                right++;
            }

            return max;
        }
        static int LongestOnes2(int[] nums, int k)
        {
            int j = 0;
            int counter = 0;
            int max = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    counter++;
                }
                else if (j < k)
                {
                    counter++;
                    j++;
                }
                else
                {
                    i = i - counter;
                    j = 0;
                    counter = 0;
                }
                max = Math.Max(max, counter);
            }
            return max;
        }

    }



}
