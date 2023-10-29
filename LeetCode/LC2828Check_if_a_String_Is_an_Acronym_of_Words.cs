using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC2828Check_if_a_String_Is_an_Acronym_of_Words
    {
        public static void Start()
        {
            Console.WriteLine("LC2828Check_if_a_String_Is_an_Acronym_of_Words");


            var input1 = new string[] { "alice", "bob", "charlie" };
            var input2 = "abc";



            var ans = IsAcronym(input1, input2);


            Console.WriteLine(ans.ToString());

        }
        //Input: words = ["alice","bob","charlie"], s = "abc"
        //Output: true
        public static bool IsAcronym(IList<string> words, string s)
        {

            if (s.Length != words.Count )
            {
                return false;
            }


            for (int i = 0; i < words.Count; i++)
            {
                if (words[i][0] != s[i])
                {
                    return false;
                }
            }

            return true;
        }


    }



}
