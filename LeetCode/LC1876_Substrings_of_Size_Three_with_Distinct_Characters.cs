using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC1876_Substrings_of_Size_Three_with_Distinct_Characters
    {
        public static void Start()
        {
            Console.WriteLine("LC1876_Substrings_of_Size_Three_with_Distinct_Characters");

            string s = "aababcabc";

            var ans = CountGoodSubstrings(s);

            Console.WriteLine(ans.ToString());


            //foreach (int i in ans) 
            //{
            //    Console.WriteLine(i.ToString());
            //}


        }

        //Input: s = "xyzzaz"
        //Output: 1
        public static int CountGoodSubstrings(string s)
        {
            int count = 0;
            HashSet<char> set = new HashSet<char>();
            for (int i = 0; i < s.Length - 2; i++)
            {
                set.Clear();

                for (int j = i; j < i+3; j++)
                {
                    set.Add(s[j]);
                }
                if (set.Count == 3)
                {
                    count++;
                }
            }
            return count;
        }





    }


}
