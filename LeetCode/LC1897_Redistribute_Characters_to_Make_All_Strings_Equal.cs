using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC1897_Redistribute_Characters_to_Make_All_Strings_Equal
    {
        public static void Start()
        {
           Console.WriteLine("LC1897_Redistribute_Characters_to_Make_All_Strings_Equal");




           string[] strs = { "abc", "aabc", "bca" };

            var ans = MakeEqual(strs);
            
 


            Console.WriteLine(ans);

        }

        //Input: words = ["abc","aabc","bc"]
        //Output: true
        //猜O(N*M),O(M)
        //答O(N*M),O(1)
        //演算法Greedy
        static bool MakeEqual(string[] words)
        {
            Dictionary<char,int> dict = new Dictionary<char,int>();


            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words[i].Length; j++)
                {
                    if (!dict.TryAdd(words[i][j], 1))
                    {
                        dict[words[i][j]]++;
                    }
                }
            }

            foreach (var num in dict)
            {
                if (num.Value % words.Length  != 0)
                {
                    return false;
                }
            }

            return true;
        }

    }



}
