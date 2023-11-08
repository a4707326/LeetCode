using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC1480_Running_Sum_of_1d_Array
    {
        public static void Start()
        {
            Console.WriteLine("LC1480_Running_Sum_of_1d_Array");

            int[] nums = { 1, 2, 3, 4 };

            var ans = RunningSum(nums);


            foreach (int i in ans) 
            {
                //Console.WriteLine(i.ToString());
            }

            int num1 = 5; // 二進制：0101
            int num2 = 3; // 二進制：0011
            int result = num1 ^ num2; // 結果：0110 (6)
            Console.WriteLine(result);
        }
        //10,1,1,6
        //Input: nums = [1,2,3,4]
        //Output: [1,3,6,10]
        public static int[] RunningSum(int[] nums)
        {

            int[] prefixSum = new int[nums.Length];
            prefixSum[0] = nums[0];//第一個因為不需要累加所以一樣

            for (int i = 1; i < nums.Length; i++)
            {
                prefixSum[i] = prefixSum[i - 1] + nums[i]; //會等於前一個(會累積)加當前
            }
            return prefixSum;
        }
    }


}
