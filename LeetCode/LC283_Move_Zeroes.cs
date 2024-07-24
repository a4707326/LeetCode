using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC283_Move_Zeroes
    {
        public static void Start()
        {
            Console.WriteLine("LC283_Move_Zeroes");



            //int[] nums = { 1,1,1, 0, 1 };
            //int[] nums = { 2,1};
            int[] nums = { 0, 1, 0, 3, 12 };
            int[] nums2 = { 2, 2, 3, 3 };
            int num = 5;
            int num2 = 1;
            string str = "cba";
            string str2 = "abcd";
            string[] strs = { "eat", "tea", "tan", "ate", "nat", "bat" };

            MoveZeroes(nums);


            foreach (var i in nums)
            {
                Console.WriteLine(i.ToString());
            }

            ////IList<IList<string>> 
            //foreach (var i in ans)
            //{
            //    foreach (var j in i)
            //    {
            //        Console.WriteLine(j.ToString());
            //    }
            //}

            //Console.WriteLine(ans);

        }

        //Input: nums = [0,1,0,3,12]
        //Input: nums = [1,3,12,3,12]
        //Output: [1,3,12,0,0]
        static void MoveZeroes(int[] nums)
        {

            for (int i = 1,j = 0; i < nums.Length; i++)
            {
                if (nums[j] != 0)
                {
                    j++;
                    continue;
                }

                if (nums[i] != 0 )
                {
                    nums[j] = nums[i];
                    nums[i] = 0;
                    j++;
                }
            }
        }

    }



}
