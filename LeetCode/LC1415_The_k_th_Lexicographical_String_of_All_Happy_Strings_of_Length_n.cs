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
    internal class LC1415_The_k_th_Lexicographical_String_of_All_Happy_Strings_of_Length_n
    {

        public static void Start()
        {
            Console.WriteLine("LC1415_The_k_th_Lexicographical_String_of_All_Happy_Strings_of_Length_n");

            int n = 1 ,k = 4;

            var ans = GetHappyString(n,k);
            Console.WriteLine(ans);




        }
        //Input: n = 3, k = 9
        //Output: "cab"
        //时间复杂度是O(3^n)
        public static string GetHappyString(int n, int k)
        {
            List<string> list = new();
            Backtracking(n, new StringBuilder(), list);     
            return list.Count < k ? "" : list[k-1];
        }


        public static void Backtracking(int n,StringBuilder sub,List<string> list)
        {
            //中止條件
            if (sub.Length > 1 && sub[sub.Length -1] == sub[sub.Length - 2])
            {
                return;
            }
            //找答案
            if (sub.Length == n)
            {
                list.Add(sub.ToString());
                return;
            }


            //循環
            for (int i = 0; i < 3; i++)
            {
                sub.Append((char)(97 + i));
                Backtracking(n, sub, list);
                sub.Remove(sub.Length - 1, 1);
            }

        }

    }


}
