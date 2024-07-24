using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC344_Reverse_String
    {
        public static void Start()
        {
            Console.WriteLine("LC344_Reverse_String");



            int[] nums = { 2, 2, 3, 3 };
            int[] nums2 = { 2, 2, 3, 3 };
            int num = 5;
            int num2 = 1;
            string str = "cba";
            string str2 = "abcd";
            string[] strs = { "eat", "tea", "tan", "ate", "nat", "bat" };
            char[] chars = { 'h', 'e', 'l', 'l', 'o' };

            ReverseString(chars);


            foreach (var i in chars)
            {
                Console.WriteLine(i.ToString());
            }

            ////IList<IList<string>> 
            //foreach (var i in ans)
            //{
            //    foreach (var j in i)
            //    {
            //        Console.WriteLine(j.ToString());
            //    }
            //}

            //Console.WriteLine(ans);

        }

        //Input: s = ["h","e","l","l","o"]
        //Output: ["o","l","l","e","h"]
        static void ReverseString(char[] s)
        {
            char temp = ' ';
            for (int i = 0; i < s.Length/2; i++)
            {
                temp = s[i];
                s[i] = s[^(i+1)];
                s[^(i + 1)] = temp;
            }
        }

    }



}
