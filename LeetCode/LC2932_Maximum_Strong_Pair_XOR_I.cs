using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC2932_Maximum_Strong_Pair_XOR_I
    {
        public static void Start()
        {
            Console.WriteLine("LC2932_Maximum_Strong_Pair_XOR_I");

            int[] nums = { 5, 6, 25, 30 };

            var ans = MaximumStrongPairXor(nums);

            //Console.WriteLine(ans);


            int cur = 0;
            Dictionary<int, int> dict = new();
            //2
            dict.Add(0, nums[0]);

            foreach (var item in dict)
            {
                for (int i = 1; i <= item.Value; i++)
                {
                    dict.Add(item.Key, nums[0]);

                    dict.TryAdd(item.Key + i, nums[item.Key + i]);
                    //dict.ContainsKey
                }
            }

        }

        //Input: nums = [5,6,25,30]
        //Output: 7
        public static int MaximumStrongPairXor(int[] nums)
        {
            //0011 3
            //0100 4
            //0111 7


            //0100
            //0101
            // 

            //0101 5
            //0110 6
            //0010 3

            int max = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (Math.Abs(nums[i] - nums[j]) <= Math.Min(nums[i], nums[j]))
                    {
                        if ((nums[i] ^ nums[j]) > max) max = nums[i] ^ nums[j];
                    }
                }
            }
            return max;
        }
    }


}

