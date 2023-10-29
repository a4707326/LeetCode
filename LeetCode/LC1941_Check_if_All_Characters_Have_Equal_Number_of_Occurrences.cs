using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC1941_Check_if_All_Characters_Have_Equal_Number_of_Occurrences
    {
        public static void Start()
        {
            Console.WriteLine("LC1941_Check_if_All_Characters_Have_Equal_Number_of_Occurrences");



            var input1 = "abcdefghijklmnopqrstuvwxyzz";

            var ans = AreOccurrencesEqual(input1);
            Console.WriteLine(ans.ToString());

        }

        //Input: s = "abacbc"
        //Output: true
        public static  bool AreOccurrencesEqual(string s)
        {
            Dictionary<char, int> map = new();   

            foreach (char c in s) 
            {


                if (map.ContainsKey(c))
                {
                    map[c]++;
                }
                else { map[c] = 1; }
            }
            var max = map.Max(x => x.Value);

            foreach (var c in map)
            {
                if (c.Value != max)
                {
                    return false;
                }
            }

            return true;
        }
    }



}
