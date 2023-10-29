using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC961_NRepeated_Element_in_Size_2N_Array
    {
        public static void Start()
        {
            Console.WriteLine("LC961_NRepeated_Element_in_Size_2N_Array");



            int[] nums = { 1, 2, 3, 3 };

            var ans = RepeatedNTimes(nums);


            Console.WriteLine(ans.ToString());

        }

        //Input: nums = [1,2,3,3]
        //Output: 3
        public static int RepeatedNTimes(int[] nums)
        {
            Dictionary<int,int> map = new Dictionary<int,int>();

            foreach (int num in nums)
            {
                if (!map.TryAdd(num, 1))
                {
                    map[num]++;
                }
            }

            foreach (var num in map)
            {
                if (num.Value > 1)
                {
                    return num.Key;
                }
            }

            return 0;
        }

    }



}
