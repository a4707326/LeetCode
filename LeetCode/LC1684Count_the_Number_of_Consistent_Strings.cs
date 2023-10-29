using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC1684Count_the_Number_of_Consistent_Strings
    {
        public static void Start()
        {
            Console.WriteLine("LC1684Count_the_Number_of_Consistent_Strings");


            var input1 = "ab";
            var input2 = new string[] { "ad", "bd", "aaab", "baa", "badab" };



            var ans = CountConsistentStrings2(input1, input2);


            Console.WriteLine(ans.ToString());



        }



        //Input: allowed = "ab", words = ["ad","bd","aaab","baa","badab"]
        //Output: 2
        public static int CountConsistentStrings(string allowed, string[] words)
        {
            int ans = 0;

            for (int i = 0; i < words.Length; i++)//5
            {
                int count = 0;
                for (int j = 0; j < words[i].Length; j++)
                {

                    foreach (var item in allowed)
                    {
                        if (words[i][j] == item)
                        {
                            count++;

                            break;
                        }

                    }


                    if (count == words[i].Length)
                    {
                        ans++;
                        break;
                    }
                }

            }
            return ans;
        }

        //效能同上但更精簡
        public static int CountConsistentStrings2(string allowed, string[] words)
        {
            int count = words.Length;
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words[i].Length; j++)
                {
                    if (!allowed.Contains(words[i][j]))
                    {
                        count--;
                        break;
                    }
                }
            }
            return count;
        }


    }



}
