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
    internal class LC2305_Fair_Distribution_of_Cookies
    {

        static int[] children;
        static int minUnfairness;
        public static void Start()
        {
            Console.WriteLine("LC2305_Fair_Distribution_of_Cookies");

            int[] cookies = { 60,45,20 };

            int k = 2;

            var ans = DistributeCookies3(cookies, k);

            Console.WriteLine(ans);



        }

        //Input: cookies = [8,15,10,20,8], k = 2
        //Output: 31
        public static int DistributeCookies(int[] cookies, int k)
        {
            return 0;
        }

        public static void Backtracking()
        {
            //中止條件

            //找答案



            //循環


        }


        public static int DistributeCookies2(int[] cookies, int k)
        {
            return FindOptimalSol(0, cookies, new int[k]);
        }

        private static int FindOptimalSol(int i, int[] cookies, int[] childs)
        {
            if (i == cookies.Length)
            {
                return childs.Max();
            }

            int res = Int32.MaxValue;
            for (int c = 0; c < childs.Length; c++)
            {
                childs[c] += cookies[i];
                res = Math.Min(FindOptimalSol(i + 1, cookies, childs), res);
                childs[c] -= cookies[i];
            }

            return res;
        }




        public static int DistributeCookies3(int[] cookies, int k)
        {
            children = new int[k];
            minUnfairness = int.MaxValue;
            Helper(cookies, 0, k);
            return minUnfairness;
        }

        private static void Helper(int[] cookies, int idx, int k)
        {
            if (idx >= cookies.Length)
            {
                minUnfairness = Math.Min(children.Max(), minUnfairness);
                return;
            }

            for (int i = 0; i < k; i++)
            {
                children[i] += cookies[idx];
                Helper(cookies, idx + 1, k);
                children[i] -= cookies[idx];
            }
        }

    }


}
