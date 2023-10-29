using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC2269_Find_the_K_Beauty_of_a_Number
    {
        public static void Start()
        {
            Console.WriteLine("LC2269_Find_the_K_Beauty_of_a_Number");

            int num = 430043;
            int k = 2;

            var ans = DivisorSubstrings(num, k);

            Console.WriteLine(ans.ToString());


            Console.WriteLine(430043%43);

        }


        //Input: num = 240, k = 2
        //Output: 2
        public static int DivisorSubstrings(int num, int k)
        {
            var str = num.ToString();
            string subStr;
            int count = 0;

            for (int i = 0; i <= str.Length - k; i++)
            {
                subStr = "";
                for (int j = i; j < k + i; j++)
                {
                    subStr += str[j];
                }

                if (Int32.Parse(subStr) <= 0 )
                {
                    continue;
                }

                if (num % Int32.Parse(subStr) == 0)
                {
                    count++;
                } 
            }

          return count;
        }





    }


}
