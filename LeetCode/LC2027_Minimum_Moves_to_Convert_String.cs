using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC2027_Minimum_Moves_to_Convert_String
    {
        public static void Start()
        {
            Console.WriteLine("LC2027_Minimum_Moves_to_Convert_String");


            string str = "XXOX";


            var ans = MinimumMoves(str);
            

            Console.WriteLine(ans);

        }
        //Input: s = "XXOX"
        //Output: 2
        //猜O(1),O(1)
        //答O(1),O(1)
        //演算法Greedy
        static int MinimumMoves(string s)
        {
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'X')
                {
                    count++;
                    i += 2;
                }
            }
            return count;
        }

    }



}
