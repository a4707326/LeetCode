using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC647_Palindromic_Substrings
    {
        public static void Start()
        {
            Console.WriteLine("LC647_Palindromic_Substrings");


            string str = "abccba";


            var ans = CountSubstrings(str);


            Console.WriteLine(ans);

        }

        //Input: s = "abc"
        //Output: 3
        //Input: s = "aaa"
        //Output: 6
        //Explanation: Six palindromic strings: "a", "a", "a", "aa", "aa", "aaa".

        //Input: s = "cababa"
        //6
        //aba,ababa,bab,aba = 6+4=10

        //猜O(N^2),O(N^2)
        //答O(N^2),O(N^2)
        //演算法DP
        static int CountSubstrings(string s)
        {
            int n = s.Length;
            bool[,] dp =  new bool[n, n]; //紀錄i到j是否為回文
            int count = 0;

            //每個[i,i]都是回文,ex:"a"
            for (int i = 0; i < n; i++)
            {
                dp[i,i] = true;
                count++;
            }

            //每個[i,i+1] 相同都是回文,ex:"aa"
            for (int i = 0; i < n - 1; i++)
            {
                if (s[i] == s[i+1])
                {
                    dp[i, i+1] = true;
                    count++;
                }
            }

            //判斷要檢測範圍長度，ex: 3 = "aaa"
            for (int len = 3; len <= n ; len++)
            {
                //如果內一圈以記錄為回文+前後相同 即為回文，ex: "ab????ba"，內一圈為b????b，因為裡面????都是已記錄為回文就不必重複算
                for (int i = 0; i <= n - len ; i++)
                {
                    int j = i + len - 1;// 為子字串(移動窗)的右指標，i 為左指標
                    if (s[i] == s[j] && dp[i + 1, j - 1])
                    {
                        dp[i, j] = true;
                        count++;
                    }
                }
            }
            return count;
        }


    }



}
