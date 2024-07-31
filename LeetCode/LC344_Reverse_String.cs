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

            char[] chars = { 'h', 'e', 'l', 'l', 'o' };

            ReverseString(chars);


            foreach (var i in chars)
            {
                Console.WriteLine(i.ToString());
            }


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
