using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC796_Rotate_String
    {
        public static void Start()
        {
            Console.WriteLine("LC796_Rotate_String");

            string str = "abcde";
            string str2 = "cdeab";


            var ans = RotateString(str, str2);
            
 

            Console.WriteLine(ans);

        }

        //Input: s = "abcde", goal = "cdeab"
        //Output: true
        //猜O(n^2),O(n)
        //答O(n^2),O(n)
        //演算法Brute-force
        static bool RotateString(string s, string goal)
        {
            Queue<char> queue = new (s);
            for (int i = 0; i < s.Length; i++)
            {
                char c = queue.Dequeue();
                queue.Enqueue(c);
                if (goal == string.Concat(queue))
                {
                    return true;
                } 
            }
            return false;
        }

    }



}
