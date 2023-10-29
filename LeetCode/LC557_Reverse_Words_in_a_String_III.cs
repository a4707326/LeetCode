using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC557_Reverse_Words_in_a_String_III
    {
        public static void Start()
        {
            Console.WriteLine("LC557_Reverse_Words_in_a_String_III");



            string str = "Let's take LeetCode contest";

            var ans = ReverseWords(str);




            Console.WriteLine(ans.ToString());

        }

        //Input: s = "Let's take LeetCode contest"
        //Output: "s'teL ekat edoCteeL tsetnoc"
        public static string ReverseWords(string s)
        {
            string[] str = s.Split(" ");
            string ans = "";

            for (int i = 0; i < str.Length; i++)
            {
                var chars = str[i].Reverse().ToArray();
                ans += new string(chars);

                if (i != str.Length - 1)
                { 
                    ans += " ";
                }
            }

            return ans;
        }

        public string ReverseWords2(string s)
        {
            string[] str = s.Split(' ');
            for (int i = 0; i < str.Length; i++)
            {
                char[] chArray = new char[str[i].Length];
                chArray = str[i].ToCharArray();
                Array.Reverse(chArray);
                str[i] = new string(chArray);
            }
            return string.Join(" ", str);
        }
    }



}
