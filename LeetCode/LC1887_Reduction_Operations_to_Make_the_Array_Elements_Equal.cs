using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC1887_Reduction_Operations_to_Make_the_Array_Elements_Equal
    {
        public static void Start()
        {
            Console.WriteLine("LC1887_Reduction_Operations_to_Make_the_Array_Elements_Equal");



            int[] nums = { 5, 1, 3 };
            int[] nums2 = { 2, 2, 3, 3 };
            int num = 5;
            int num2 = 1;
            string str = "cba";
            string str2 = "abcd";

            var ans = ReductionOperations2(nums);


            //foreach ( var i in ans ) 
            //{
            //    Console.WriteLine(i.ToString());
            //}

            Console.WriteLine(ans);

        }

        //Input: nums = [5,1,3]
        //Output: 3
        static int ReductionOperations(int[] nums)
        {
            Array.Sort(nums);
            int count = 0;
            while (nums[0] != nums[nums.Length-1]) 
            {

                //for (int i = nums.Length -1 ; i > 0 ; i--)
                //{
                //    if (nums[i] != nums[i-1])
                //    {
                //        nums[i] = nums[i-1];
                //        count++;
                //        break;
                //    }
                //}
                for (int i = nums.Length - 1; i > 0; i--)
                {
                    if (nums[i] != nums[i - 1])
                    {
                        nums[i] = nums[i - 1];
                        count++;
                    }
                }

            }


            //[5,1,3]
            //[1,3,5]
            //[1,3,3]1
            //[1,1,3]2
            //[1,1,1]3

            //[1,3,3,5]
            //[1,1,3,3]
            return count;
        }

        static int ReductionOperations2(int[] nums)
        {
            Array.Sort(nums);
            int count = 0, change =0;

            for (int i = 1; i < nums.Length; i++)
            {

                if (nums[i] != nums[i -1])
                {
                    change++;

                }
                count += change;
            }


            //[0,0,1,1,2]
            //[0,0,2,0,4]

            //[1,1,2,2,3]
            //[1,1,2,2,2]1
            //[1,1,1,2,2]2
            //[1,1,1,1,2]3
            //[1,1,1,1,1]4


            //[5,1,3]
            //[1,3,5]
            //[1,3,3]1
            //[1,1,3]2
            //[1,1,1]3

            //[1,3,3,5]
            //[1,1,3,3]
            return count;
        }
    }



}
