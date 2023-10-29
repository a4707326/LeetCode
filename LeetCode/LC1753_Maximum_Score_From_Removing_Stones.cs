using System;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC1753_Maximum_Score_From_Removing_Stones
    {
        public static void Start()
        {
            Console.WriteLine("LC1753_Maximum_Score_From_Removing_Stones");

            //int a = 2;
            //int b = 4;
            //int c = 6;

            //221
            //111 1
            //001 2

            int a = 6;
            int b = 2;
            int c = 1;
            var ans = MaximumScore(a,b,c);

            Console.WriteLine(ans.ToString());




        }

        //Input: a = 2, b = 4, c = 6
        //Output: 6
        //時間複雜度是 O(1),空間複雜度是 O(1)
        public static int MaximumScore(int a, int b, int c)
        {
            int sum = a + b + c;
            int max = new int[3] { a, b, c }.Max();
            int other = sum - max;

            return (sum - (other < max? max - other : 0))/2;
        }







    }


}
