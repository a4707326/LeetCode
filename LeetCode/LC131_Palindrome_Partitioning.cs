using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC131_Palindrome_Partitioning
    {
        public static void Start()
        {
            Console.WriteLine("LC131_Palindrome_Partitioning");

            string str = "cba";


            var ans = Partition(str);




            foreach (var i in ans)
            {
                string a = "";
                foreach (var j in i)
                {
                    a += j;

                }
                Console.WriteLine(a.ToString());
            }

            //Console.WriteLine(ans);


        }

        //Input: s = "aab"
        //Output: [["a","a","b"],["aa","b"]]
        //猜O(1),O(1)
        //答O(1),O(1)
        //演算法Greedy
        static IList<IList<string>> Partition(string s)
        {
            HashSet<string> list = new HashSet<string>();


            return new List<IList<string>>();
        }

        static bool IsPalindrome(string s)
        {
            string str = Regex.Replace(s, @"[^a-zA-Z0-9]", "").ToLower();
            int n = str.Length;
            bool ans = true;

            for (int i = 0, j = n - 1; i >= j; i++, j--)
            {

                if (str[i] != str[j])
                {
                    ans = false;
                    break;
                }
            }
            return ans;

        }
    }



}
