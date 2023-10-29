using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC1047_Remove_All_Adjacent_Duplicates_In_String
    {
        public static void Start()
        {
            Console.WriteLine("LC1047_Remove_All_Adjacent_Duplicates_In_String");

            string s = "abbaca";

            var ans = RemoveDuplicates2(s);

            Console.WriteLine(ans);


        }
       
        //Input: s = "abbaca"
        //Output: "ca"
        public static string RemoveDuplicates(string s)
        {

            List<char> list = new();

            for (int i = 0; i < s.Length; i++)
            {
                list.Add(s[i]);
                if (list.Count >= 2)
                {
                    if (list[list.Count - 1] == list[list.Count - 2])
                    {
                        list.RemoveAt(list.Count - 1);
                        list.RemoveAt(list.Count - 1);
                    }
                }

            }

            return string.Join("", list);
        }
        //Input: s = "abbaca"
        //Output: "ca"
        //記憶體使用的更少
        public static string RemoveDuplicates2(string s)
        {
            Stack<char> st = new();

            foreach (char c in s)
            {
                if (st.TryPeek(out char d) && d == c)
                {
                    st.Pop();
                    continue;
                }

                st.Push(c);
            }

            return string.Concat(st.Reverse());
        }





    }


}
