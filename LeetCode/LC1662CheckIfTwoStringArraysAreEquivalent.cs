using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC1662CheckIfTwoStringArraysAreEquivalent
    {
        public static void Start()
        {
            Console.WriteLine("LC1662CheckIfTwoStringArraysAreEquivalent");


            var input1 = new string[] { "ab", "c" };
            var input2 = new string[] { "a", "bc" };



            var ans = ArrayStringsAreEqual2(input1, input2);

            Console.WriteLine(ans.ToString());

        }

        //Input: word1 = ["ab", "c"], word2 = ["a", "bc"]
        //Output: true
        public static bool ArrayStringsAreEqual(string[] word1, string[] word2)
        {
            string a = "";
            string b = "";

            foreach (var x in word1) 
            {
                a += x;
            }
            foreach (var x in word2)
            {
                b += x;
            }
            
            if (a == b) return true;

            return false;
        }

        public static bool ArrayStringsAreEqual2(string[] word1, string[] word2)
        {
            return String.Join("", word1) == String.Join("", word2);
        }


    }



}
