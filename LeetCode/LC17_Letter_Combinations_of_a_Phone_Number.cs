using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC17_Letter_Combinations_of_a_Phone_Number
    {
        public static void Start()
        {
            Console.WriteLine("LC17_Letter_Combinations_of_a_Phone_Number");

            string num = "23";
            //int k = 5;

            var ans = LetterCombinations(num);


            foreach (var i in ans)
            {
                Console.WriteLine(i.ToString());
            }

            //Console.WriteLine(ans);

        }

        //Input: digits = "23"
        //Output: ["ad","ae","af","bd","be","bf","cd","ce","cf"]
        //Backtracking
        //O(N!)
        public static IList<string> LetterCombinations(string digits)
        {
            List<string> ansList = new List<string>();
            //例外
            if (digits == "")
            {
                return ansList;
            }
            //初始化
            Dictionary<int, string> btnDict = new Dictionary<int, string>
            {
                { 2, "abc" },
                { 3, "def" },
                { 4, "ghi" },
                { 5, "jkl" },
                { 6, "mno" },
                { 7, "pqrs" },
                { 8, "tuv" },
                { 9, "wxyz" }
            };

            DFS(0,"");
            //Backtracking
            void DFS(int index,string strList)
            {
                //終止條件//找答案
                if (index >= digits.Count())
                {
                    ansList.Add(strList);
                    return;
                }
                //循環
                int curNum = (int)char.GetNumericValue(digits[index]);
                for (int i = 0; i < btnDict[curNum].Length; i++)
                {
                    DFS(index + 1, strList + btnDict[curNum][i]);
                }
            }
            return ansList;
        }

    }



}
