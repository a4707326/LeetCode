using System;
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
    internal class LC26_Remove_Duplicates_from_Sorted_Array
    {
        public static void Start()
        {
            Console.WriteLine("LC26_Remove_Duplicates_from_Sorted_Array");

            int[] nums = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };

            var ans = RemoveDuplicates(nums);


            Console.WriteLine(ans.ToString());

            foreach (int i in nums)
            {
                Console.WriteLine(i.ToString());
            }




        }
        //Input: nums = [0,0,1,1,1,2,2,3,3,4]
        //Output: 5, nums = [0,1,2,3,4, _, _, _, _, _]


        //public static int RemoveDuplicates(int[] nums)
        //{
        //    //int index = 0;

        //    //List<int> newNums = new();
        //    int cutNun = -1;
        //    int count = 0;


        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        if (nums[i] != cutNun)
        //        {
        //            count++;
        //            cutNun = nums[i];
        //            //newNums.Add(cutNun);
        //        }
        //        //index++;
        //    }

        //    //while (nums.Length > 0) 
        //    //{


        //    //    if (nums[index] != cutNun) 
        //    //    {
        //    //        count++;
        //    //    }
        //    //    index++;
        //    //}
        //    //nums = newNums.ToArray();
        //    return count ;
        //}

        public static int RemoveDuplicates(int[] nums)
        {
            int i = 0;
            for (int j = 1; j < nums.Length; j++)
            {
                if (nums[i] != nums[j])
                {
                    i++;
                    nums[i] = nums[j];
                }
            }
            return i + 1;

        }

    }


}
