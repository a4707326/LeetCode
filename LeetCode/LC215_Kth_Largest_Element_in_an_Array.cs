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
    internal class LC215_Kth_Largest_Element_in_an_Array
    {
        public static void Start()
        {
            Console.WriteLine("LC215_Kth_Largest_Element_in_an_Array");

            //int[] nums = { 3, 2, 1, 5, 6, 4 };
            //int k = 2;
            int[] nums = { 3, 2, 1, 5, 6, 4 };
            int k = 2;

            var ans = FindKthLargest3(nums,k);
            Console.WriteLine(ans);


        }

        //Input: nums = [3,2,1,5,6,4], k = 2
        //Output: 5
        //timeout
        public static int FindKthLargest(int[] nums, int k)
        {
            int lastMax = 1000000;
            int max = -1000000;
            int same;


            for (int i = 0; i < k; i++)
            {
                max = -1000000;
                same = 0;
                for (int j = 0; j < nums.Length; j++)
                {
                    //if (nums[j] > max && nums[j] < lastMax) max = nums[j];
                    if (max > -1000000 && max == nums[j])
                    {
                        same ++;
                    }
                    else if (nums[j] > max && nums[j] < lastMax)
                    {
                        max = nums[j];
                        same = 0;
                    }
                }
                k -= same;
                lastMax = max;
            }
            
            return max;
        }
        //未修正
        //public static int FindKthLargest2(int[] nums, int k)
        //{

        //    Dictionary<int,int> numCount = new();

        //    int max = -1000000;
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        if (nums[i] > max)
        //        {
        //            max = nums[i];
        //        }
        //        if (!numCount.TryAdd(nums[i],1))
        //        {
        //            numCount[nums[i]]++;
        //        }
        //    }

        //    int value;
        //    for (int i = max, j = 1; j < k; i--,j++)
        //    {
        //        numCount.TryGetValue(max,out value);

        //        if (true)
        //        {
                    
        //        }
        //        //if (value == 0)
        //        //{
        //        //    j++;
        //        //}
        //        //else
        //        if (value > 1)
        //        {
        //            j += numCount[max]-1;
        //        }
        //        if (j< k)
        //        {
        //            max--;
        //        }
        //    }
            
        //    return max;
        //}


        public static int FindKthLargest3(int[] nums, int k)
        {
            //to track frequency of each number
            //20001 size because each nums[i] is in range -10^4 to 10^4
            int[] numCount = new int[20001];
            for (int i = 0; i < nums.Length; i++)
            {
                //adding 10000 to all numbers
                //especially to make negetive number as positive, to avoid negetive index issue
                int idx = nums[i] + 10000;
                numCount[idx]++;
            }

            //find Kth largest element
            int kthLarge = 0;
            for (int i = numCount.Length - 1; i >= 0 && k > 0; i--)
            {
                //reduce 'k' by found number's frequency (frequency will be 0 if number was not present in nums)
                k -= numCount[i];
                kthLarge = i - 10000;
            }

            return kthLarge;
        }



    }


}
