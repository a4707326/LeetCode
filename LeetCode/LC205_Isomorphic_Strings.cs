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
    internal class LC205_Isomorphic_Strings
    {
        public static void Start()
        {
            Console.WriteLine("LC205_Isomorphic_Strings");

            string s = "egg",t = "add";



            var ans = IsIsomorphic(s,t);

            Console.WriteLine(ans);



        }

        //Input: s = "egg", t = "add"
        //Output: true
        //還未完全搞懂
        public static bool IsIsomorphic(string s, string t)
        {



            Dictionary<char,char> dic = new Dictionary<char,char>();
            for (int i = 0; i < s.Length; i++)
            {

                if (dic.ContainsKey(s[i]))
                {
                    if (t[i] != dic[s[i]]) return false;
                }
                else
                {
                    if (dic.ContainsValue(t[i])) return false;
                    dic.Add(s[i], t[i]);
                }

            }
            return true;

        }






    }


}
