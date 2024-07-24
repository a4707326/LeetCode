using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC100357_Find_the_Maximum_Length_of_Valid_Subsequence_I
    {
        public static void Start()
        {
            Console.WriteLine("LC100357_Find_the_Maximum_Length_of_Valid_Subsequence_I");



            int[] nums = { 2, 2, 3, 3 };
            int[] nums2 = { 2, 2, 3, 3 };
            int num = 5;
            int num2 = 1;

            var ans = MaximumLength(nums);


            //foreach ( var i in ans ) 
            //{
            //    Console.WriteLine(i.ToString());
            //}

            Console.WriteLine(ans);

        }

        //Input: nums = [1,2,1,1,2,1,2]
        //Output: 6l
        static int MaximumLength(int[] nums)
        {
            List<int> sub = new List<int>(nums);

            //for (int i = 0; i < sub.Count; i++)
            //{
            //    if ((sub[i] + sub[i+1])%2  != (sub[i+1] + sub[i+2]) % 2) 
            //    {
                    
            //    }


            //}
            return 0;
        }

    }



}
