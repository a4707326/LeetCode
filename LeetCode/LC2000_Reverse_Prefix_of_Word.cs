using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC2000_Reverse_Prefix_of_Word
    {
        public static void Start()
        {
            Console.WriteLine("LC2000_Reverse_Prefix_of_Word");



            string word = "abcdefd";
            char ch = 'd';

            var ans = ReversePrefix(word, ch);




            Console.WriteLine(ans.ToString());

        }

        //Input: word = "abcdefd", ch = "d"
        //Output: "dcbaefd"
        public static string ReversePrefix(string word, char ch)
        {
            int chIdx =  word.IndexOf(ch);
            if (chIdx == -1)
            {
                return word;
            }
            char[] chars = word.ToCharArray();


            for (int i = 0 ,j = chIdx; i <= j; i++,j--)
            {
                chars[i] = word[j];
                chars[j] = word[i];
            }

            return new string(chars);
        }
    }



}
