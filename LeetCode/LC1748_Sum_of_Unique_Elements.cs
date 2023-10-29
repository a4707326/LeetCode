using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC1748_Sum_of_Unique_Elements
    {
        public static void Start()
        {
            Console.WriteLine("LC1748_Sum_of_Unique_Elements");



            int[] nums = { 1, 2, 3, 2 };

            var ans = SumOfUnique(nums);


            Console.WriteLine(ans.ToString());

        }

        //Input: nums = [1,2,3,2]
        //Output: 4

        public static int SumOfUnique(int[] nums)
        {
            Dictionary<int,int> map = new Dictionary<int,int>();

            foreach (int num in nums) 
            {
                if (!map.TryAdd(num, 1))
                {
                    map[num] ++;
                }
            }

            int sum = 0;
            foreach (var num in map)
            {
                if (num.Value == 1)
                {
                    sum += num.Key;
                }
            }
            return sum;
        }

    }



}
