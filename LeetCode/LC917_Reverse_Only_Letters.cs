using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC917_Reverse_Only_Letters
    {
        public static void Start()
        {
            Console.WriteLine("LC917_Reverse_Only_Letters");

            string str = "ab-cd";


            var ans = ReverseOnlyLetters(str);



            Console.WriteLine(ans);

        }

        //Input: s = "ab-cd"
        //Output: "dc-ba"
        static string ReverseOnlyLetters(string s)
        {
            var sb = new StringBuilder(s);
            char c;

            for (int i = 0,j = sb.Length - 1; i < j ;)
            {
                if (char.IsLetter(sb[i]) && char.IsLetter(sb[j]))
                {
                    c= sb[i];
                    sb[i] = sb[j];
                    sb[j] = c;

                    i++;
                    j--;
                    continue;
                }

                if (!char.IsLetter(sb[i]))
                { 
                    i++;
                }
                if (!char.IsLetter(sb[j]))
                {
                    j--;
                }
            }
            return sb.ToString() ;
        }

    }



}
