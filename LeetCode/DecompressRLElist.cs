using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class DecompressRLElist
    {
        public static void Start()
        {
            Console.WriteLine("DecompressRLElist");

            var input = new int[] { 1, 2, 3, 4 };


            var ans = Solution(input);

            foreach (int i in ans)
            {
                Console.WriteLine(i);
            }




        }




        //Input: nums = [1,2,3,4]
        //Output: [2,4,4,4]
        //Explanation: The first pair[1, 2] means we have freq = 1 and val = 2 so we generate the array[2].
        //The second pair[3, 4] means we have freq = 3 and val = 4 so we generate[4, 4, 4].
        //At the end the concatenation[2] + [4,4,4] is [2,4,4,4].

        public static int[] Solution(int[] nums)
        {
            List<int> ans = new List<int>();
            for (int i = 0; i < nums.Length; i+=2)
            {
                for (int j = 0; j < nums[i]; j++)
                {
                    ans.Add(nums[i+1]);
                }
            }
            return ans.ToArray();
        }


        //此方法效能和Solution一至
        public static int[] Solution2(int[] nums)
        {
            var result = new List<int>();
            for (var i = 0; i < nums.Length; i += 2)
            {
                result.AddRange(Enumerable.Repeat(nums[i + 1], nums[i]));
            }
            return result.ToArray();
        }




    }



}
