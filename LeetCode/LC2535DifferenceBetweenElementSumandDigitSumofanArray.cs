using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC2535DifferenceBetweenElementSumandDigitSumofanArray
    {
        public static void Start()
        {
            Console.WriteLine("LC2535DifferenceBetweenElementSumandDigitSumofanArray");


            var input = new int[] { 1, 15, 6, 3 };


            var ans = DifferenceOfSum2(input);

            Console.WriteLine(ans.ToString());

        }


        //Input: nums = [1,15,6,3]
        //Output: 9
        //Explanation: 
        //The element sum of nums is 1 + 15 + 6 + 3 = 25.
        //The digit sum of nums is 1 + 1 + 5 + 6 + 3 = 16.
        //The absolute difference between the element sum and digit sum is |25 - 16| = 9.

        public static int DifferenceOfSum(int[] nums)
        {
            int elementSum = 0;
            int digitSum = 0;
            string str = "";

            foreach (var item in nums)
            {
                elementSum += item;
                str += item.ToString();
            }
            foreach (var item in str)
            {
                digitSum += int.Parse( item.ToString());

            }


            return Math.Abs(elementSum - digitSum);
        }

        public static int DifferenceOfSum2(int[] nums)
        {
            int elementSum = 0;
            int digitSum = 0;

            foreach (var item in nums)
            {
                elementSum += item;
            }
            foreach (var item in nums)
            {
                int k = item;
                while (k > 0)
                {
                    int j = k % 10;
                    k /= 10;
                    digitSum += j;
                }

            }

            return elementSum - digitSum;
        }

    }



}
