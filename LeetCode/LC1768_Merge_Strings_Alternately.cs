using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC1768_Merge_Strings_Alternately
    {
        public static void Start()
        {
            Console.WriteLine("LC1768_Merge_Strings_Alternately");



            string word1 = "abc";
            string word2 = "pqr";

            var ans = MergeAlternately(word1, word2);




            Console.WriteLine(ans.ToString());

        }

        //Input: word1 = "abc", word2 = "pqr"
        //Output: "apbqcr"
        public static string MergeAlternately(string word1, string word2)
        {

            int len = word1.Length > word2.Length ? word1.Length : word2.Length;
            string ans = "";

            for (int i = 0; i < len ; i++)
            {
                if (word1.Length > i)
                {
                    ans += word1[i];
                }
                if (word2.Length > i)
                {
                    ans += word2[i];
                }
            }

            return ans;

        }
    }



}
