using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC392_Is_Subsequence
    {
        public static void Start()
        {
            Console.WriteLine("LC392_Is_Subsequence");



         
            string str = "acb";
            string str2 = "ahbgdc";


            var ans = IsSubsequence(str, str2);
            



            Console.WriteLine(ans);

        }

        //Input: s = "axc", t = "ahbgdc"
        //Output: false
        //猜O(n),O(1)
        //答O(n+m),O(1) 
        //演算法Greedy
        static bool IsSubsequence(string s, string t)
        {
            int count = 0;
            int nowIndex = 0;
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = nowIndex; j < t.Length; j++)
                {
                    if (s[i] == t[j])
                    {
                        count++;
                        nowIndex = j+1;
                        break;
                    }
                }
            }

            return count == s.Length;
        }
    }



}
