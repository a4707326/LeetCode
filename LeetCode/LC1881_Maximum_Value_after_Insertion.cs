using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC1881_Maximum_Value_after_Insertion
    {
        public static void Start()
        {
            Console.WriteLine("LC1881_Maximum_Value_after_Insertion");



            int[] nums = { 2, 2, 3, 3 };
            int[] nums2 = { 2, 2, 3, 3 };
            int num = 3;
            int num2 = 1;
            string str = "-132";
            string str2 = "abcd";
            string[] strs = { "eat", "tea", "tan", "ate", "nat", "bat" };

            var ans = MaxValue2(str, num);


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
        //Input: n = "-13", x = 2
        //Output: "-123"
        static string MaxValue(string n, int x)
        {
            BigInteger max = BigInteger.Parse("-9999999999999999999999999999999999999999999999999999999999999999999999");
            for (int i = 0; i < n.Length + 1; i++)
            {
                if (i == 0 && n[i] == '-')
                {
                    continue;
                }

                BigInteger num = BigInteger.Parse(n.Insert(i, x.ToString()));

                if (num > max)
                {
                    max = num;
                }
            }
            return max.ToString();
        }
        static string MaxValue2(string str, int x)
        {
            int idx = str[0] == '-' ? 1 : 0;
            bool neg = str[0] == '-' ? true : false;
            for (int i = idx; i < str.Length; ++i)
            {
                int n = (int)(str[i] - '0');
                if (!neg && x > n)
                {
                    return str.Substring(idx, i) + x.ToString() + str.Substring(i);
                }
                if (neg && x < n)
                {
                    return str.Substring(0, i) + x.ToString() + str.Substring(i);
                }
            }
            return str + x.ToString();
        }
    }
}


