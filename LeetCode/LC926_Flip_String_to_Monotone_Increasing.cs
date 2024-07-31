using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC926_Flip_String_to_Monotone_Increasing
    {
        public static void Start()
        {
            Console.WriteLine("LC926_Flip_String_to_Monotone_Increasing");

            string str = "10011111110010111011";

            var ans = MinFlipsMonoIncr(str);

            Console.WriteLine(ans);

        }
        //Input: s = "00110"
        //Output: 1

        //Input: s = "010110"
        //Output: 2

        //Input: s = "0101100011"
        //Output: 3

        //Input: s = "10011111110010111011"
        //Output: 5

        //猜O(N),O(N)
        //答O(N),O(1)
        //演算法Greedy
        
        static int MinFlipsMonoIncr(string s)
        {
            int onesCount = 0;
            int flipsCount = 0;

            foreach (char c in s)
            {
                if (c == '0')
                {
                    flipsCount++;
                }else 
                {
                    onesCount++;
                }

                if (flipsCount > onesCount)
                {
                    flipsCount = onesCount;
                }
            }
            return flipsCount;

        }
    }



}
