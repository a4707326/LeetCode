using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC2108_Find_First_Palindromic_String_in_the_Array
    {
        public static void Start()
        {
            Console.WriteLine("LC2108_Find_First_Palindromic_String_in_the_Array");



            string[] words = { "abc", "car", "ada", "racecar", "cool" };


            var ans = FirstPalindrome(words);




            Console.WriteLine(ans.ToString());

        }


        //Input: words = ["abc","car","ada","racecar","cool"]
        //Output: "ada"
        public static string FirstPalindrome(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                int count = 0;
                for (int j = 0,k = words[i].Length - 1 ; j < k; j++,k--)
                {
                    if (words[i][j] != words[i][k])
                    {
                        break;
                    }
                    count ++;
                }

                if (count == words[i].Length / 2)
                {
                    return words[i];
                }
            }

            return "";
        }
    }



}
