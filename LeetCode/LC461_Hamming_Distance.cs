using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC461_Hamming_Distance
    {
        public static void Start()
        {
            Console.WriteLine("LC461_Hamming_Distance");



            int[] nums = { 2, 2, 3, 3 };
            int[] nums2 = { 2, 2, 3, 3 };
            int num = 1;
            int num2 = 4;
            string str = "cba";
            string str2 = "abcd";
            string[] strs = { "eat", "tea", "tan", "ate", "nat", "bat" };

            var ans = HammingDistance(num, num2);


            //foreach ( var i in ans ) 
            //{
            //    Console.WriteLine(i.ToString());
            //}

            ////IList<IList<string>> 
            //foreach (var i in ans)
            //{
            //    foreach (var j in i)
            //    {
            //        Console.WriteLine(j.ToString());
            //    }
            //}

            Console.WriteLine(ans);

        }

        //Input: x = 1, y = 4
        //Output: 2
        static int HammingDistance(int x, int y)
        {
            int m = x ^ y;
            int count = 0;
            while (m > 0)
            {
                count += m & 1;
                m >>= 1;
            }
            return count;
        }

    }



}
