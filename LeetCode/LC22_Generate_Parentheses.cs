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
    internal class LC22_Generate_Parentheses
    {

        public static void Start()
        {
            Console.WriteLine("LC22_Generate_Parentheses");

            int n = 3;

            var ans = GenerateParenthesis(n);


            foreach (var i in ans)  
            {
                Console.WriteLine(i.ToString());
            }


        }
        //()
        //()() ,(())
        //()()(),((())),()(()),(())()

        //Input: n = 3
        //Output: ["((()))","(()())","(())()","()(())","()()()"]
        //時間複雜度O(2×2N)
        public static IList<string> GenerateParenthesis(int n)
        {
            List<string> ans = new();
            Backtracking(n, 1, 0, new StringBuilder("("), ans);
            return ans;
        }


        public static void Backtracking(int n, int left, int right, StringBuilder sub, IList<string> ans)
        {
            //中止條件
            if (right > left)
            {
                return;
            }
            //找答案
            if (sub.Length == n * 2)
            {
                ans.Add(sub.ToString());
                return;
            }


            //循環
            if (left < n)
            {
                sub.Append('(');
                Backtracking(n, left + 1, right, sub, ans);
                sub.Remove(sub.Length - 1, 1);
            }

            if (right < n)
            {
                sub.Append(')');
                Backtracking(n, left, right + 1, sub, ans);
                sub.Remove(sub.Length - 1, 1);
            }

        }

    }


}
