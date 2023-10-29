using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class SumMultiples
    {
        public static void Start()
        {
            Console.WriteLine("SumMultiples");

            //var input = new string[] { "alice and bob love leetcode", "i think so too", "this is great thanks very much" };
            var input = 14;

            var ans = Solution(input);

            Console.WriteLine(ans);



        }

        //Input: n = 10
        //Output: 40
        //Explanation: Numbers in the range[1, 10] that are divisible by 3, 5, or 7 are 3, 5, 6, 7, 9, 10. The sum of these numbers is 40.

        public static int Solution(int n)
        {
            int sum = 0;
            for (int i = 0; i <= n; i += 3)
            {
                sum += i;
            }
            for (int i = 0; i <= n; i += 5)
            {
                if (i % 3 != 0 )
                {
                    sum += i;
                }
            }
            for (int i = 0; i <= n; i += 7)
            {
                if (i % 3 != 0 && i % 5 != 0)
                {
                    sum += i;
                }
            }
            return sum;
        }

 
        public static int Solution2(int n)
        {
            int sum = 0;

            for (int i = 1; i < n + 1; i++)
            {
                if (i % 3 == 0 | i % 5 == 0 | i % 7 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
    }



}
