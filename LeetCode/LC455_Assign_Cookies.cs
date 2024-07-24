using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC455_Assign_Cookies
    {
        public static void Start()
        {
            Console.WriteLine("LC455_Assign_Cookies");



            int[] nums = { 1, 2};
            int[] nums2 = { 1, 2, 3 };


            //Input: g = [1, 2], s = [1, 2, 3]

            var ans = FindContentChildren(nums, nums2);


            //foreach ( var i in ans ) 
            //{
            //    Console.WriteLine(i.ToString());
            //}

            Console.WriteLine(ans);

        }

        //Input: g = [1,2,3], s = [1,1]
        //Output: 1
        //貪婪演算法
        static int FindContentChildren(int[] g, int[] s)
        {
            int count = 0;
            
            Array.Sort(g);
            Array.Sort(s);

            for (int i = 0; i < s.Length; i++)
            {
                if (count >= g.Length)
                {
                    return count;
                }
                if (g[count] <= s[i])
                {
                    count++;
                }
            }


            return count;
        }

    }



}
