using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC1544_Make_The_String_Great
    {
        public static void Start()
        {
            Console.WriteLine("LC1544_Make_The_String_Great");

            string s = "leEeetcode";

            var ans = MakeGood(s);
            Console.WriteLine(ans.ToString());

            //foreach (int i in ans) 
            //{
            //    Console.WriteLine(i.ToString());
            //}


        }

        //Input: s = "leEeetcode"
        //Output: "leetcode"
        public static string MakeGood(string s)
        {
            List<char> ans = s.ToList();
            int i = 0;
            while (i < ans.Count - 1) 
            {
                if (char.ToUpper(ans[i]) == char.ToUpper(ans[i+1]) && char.IsUpper(ans[i]) != char.IsUpper(ans[i+1]))
                { 
                    ans.RemoveAt(i);
                    ans.RemoveAt(i);
                    i = 0;
                }
                else
                {
                    i++;
                }
            }
            return string.Join("", ans);
        }







    }


}
