using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC345_Reverse_Vowels_of_a_String
    {
        public static void Start()
        {
            Console.WriteLine("LC345_Reverse_Vowels_of_a_String");


            string str = "leetcode";
            var ans = ReverseVowels(str);
            Console.WriteLine(ans);

        }

        //Input: s = "leetcode"
        //Output: "leotcede"
        static string ReverseVowels(string s)
        {
            var sb = new StringBuilder(s);
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            char c;
            for (int i = 0,j = sb.Length - 1; i <= j;)
            {

                if (vowels.Contains(sb[i]) && vowels.Contains(sb[j]))
                {
                    c = sb[i];
                    sb[i] = sb[j];
                    sb[j] = c;

                    i++;
                    j--;
                    continue;
                }

                if (!vowels.Contains(sb[i]))
                {
                    i++;
                }

                if (!vowels.Contains(sb[j]))
                {
                    j--;
                }

            }
            return sb.ToString();
        }
    }



}
