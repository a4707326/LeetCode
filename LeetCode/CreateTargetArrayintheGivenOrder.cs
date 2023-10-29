using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class CreateTargetArrayintheGivenOrder
    {
        public static void Start()
        {
            Console.WriteLine("CreateTargetArrayintheGivenOrder");


            var input = new int[] { 0, 1, 2, 3, 4 };
            var input2 = new int[] { 0, 1, 2, 2, 1 };

            var ans = Solution(input, input2);


            foreach (var item in ans)
            {
                Console.WriteLine(item);
            }




        }


        //Input: nums = [0,1,2,3,4], index = [0,1,2,2,1]
        //Output: [0,4,1,3,2]

        public static int[] Solution(int[] nums, int[] index)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                list.Insert(index[i], nums[i]);
            }
            return list.ToArray();
        }
    }



}
