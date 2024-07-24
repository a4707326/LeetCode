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
    internal class LC791_Custom_Sort_String
    {
        public static void Start()
        {
            Console.WriteLine("LC791_Custom_Sort_String");



            int[] nums = { 2, 2, 3, 3 };
            int[] nums2 = { 2, 2, 3, 3 };
            int num = 5;
            int num2 = 1;
            string str = "cba";
            string str2 = "abcdd";

            var ans = CustomSortString(str, str2);


            //foreach ( var i in ans ) 
            //{
            //    Console.WriteLine(i.ToString());
            //}

            Console.WriteLine(ans);

        }

        //Input: order = "cba", s = "abcd"
        //Output: "cbad"
        static string CustomSortString(string order, string s)
        {
            //Hashtable hashtable = new Hashtable();
            //Dictionary<char,int> dict = new ();

            List<char> list = new (s);
            string ans = "";

            for (int i = 0; i < order.Length; i++)
            {
                for (int j = 0; j < list.Count(); j++)
                {
                    if (order[i] == list[j])
                    {
                        ans += list[j];
                        list.RemoveAt(j);
                        j--;
                    }
                }
            }


            return ans + string.Join("",list);
        }

    }



}
