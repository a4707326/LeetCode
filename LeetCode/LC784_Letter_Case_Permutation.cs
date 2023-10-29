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
    internal class LC784_Letter_Case_Permutation
    {
        
        static List<string> letterList  = new();
        public static void Start()
        {
            Console.WriteLine("LC784_Letter_Case_Permutation");

            string s = "a1b2";

            var ans = LetterCasePermutation(s);

            //Console.WriteLine(ans);

            foreach (var i in ans)
            {
                Console.WriteLine(i.ToString());
            }


        }

        //
        //a



        //Input: s = "a1b2"
        //Output: ["a1b2","a1B2","A1b2","A1B2"]
        //算法的时间复杂度是 O(2^N)，其中 N 是输入字符串的长度
        public static IList<string> LetterCasePermutation(string s)
        {
            Backtracking(new List<char>(s),0 );
            return letterList;
        }

        public static void Backtracking(List<char> sub,int start)
        {
            //中止//找答案
            if (sub.Count == start)
            {
                letterList.Add(string.Join("", sub));

                return;
            }



            //循環
            if (char.IsLetter(sub[start]))
            {
                sub[start] = char.ToUpper(sub[start]);
                Backtracking(sub, start+1);
                sub[start] = char.ToLower(sub[start]);
                Backtracking(sub, start+1);
            }
            else 
            {
                Backtracking(sub, start + 1);
            }

        }
    }

}


