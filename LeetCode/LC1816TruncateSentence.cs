using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC1816TruncateSentence
    {
        public static void Start()
        {
            Console.WriteLine("LC1816TruncateSentence");


            var input1 = "Hello how are you Contestant";
            var input2 = 4;



            var ans = TruncateSentence(input1, input2);

            Console.WriteLine(ans.ToString());

        }


        //Input: s = "Hello how are you Contestant", k = 4
        //Output: "Hello how are you"

        public static string TruncateSentence(string s, int k)
        {
            int count =0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    count++;
                }

                if (count == k)
                {
                    s = s.Substring(0, i);
                }
            }

            return s;
        }


    }



}
