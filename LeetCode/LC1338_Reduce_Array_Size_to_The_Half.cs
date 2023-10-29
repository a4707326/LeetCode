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
    internal class LC1338_Reduce_Array_Size_to_The_Half
    {
        public static void Start()
        {
            Console.WriteLine("LC1338_Reduce_Array_Size_to_The_Half");

            int[] arr = { 3, 3, 3, 3, 5, 5, 5, 2, 2, 7 };

            var ans = MinSetSize(arr);

            Console.WriteLine(ans.ToString());




        }

        //Input: arr = [3,3,3,3,5,5,5,2,2,7]
        //Output: 2
        //整體的時間複雜度是 O(n log n)
        public static int MinSetSize(int[] arr)
        {
            var frequency = arr.GroupBy(x => x).Select(x => x.Count()).OrderByDescending(x => x);//時間複雜度主要取決於排序的操作，通常情況下是 O(n log n)
            int sum = 0;
            int step = 0;

            foreach (var item in frequency)
            {
                step++;
                sum += item;
                if (sum >= arr.Length / 2)
                {
                    return step;
                }

            }

            return step;
        }





    }


}
