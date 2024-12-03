using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC1641_Count_Sorted_Vowel_Strings
    {
        public static void Start()
        {
            Console.WriteLine("LC1641_Count_Sorted_Vowel_Strings");


            int num = 33;


            var ans = CountVowelStrings2(num);



            Console.WriteLine(ans);

        }

        //Input: n = 2
        //Output: 15
        static int CountVowelStrings(int n)
        {
            char[] vowels = new char[]{ 'a', 'e', 'i','o', 'u' };
            List<string> ansList = new();

            if (n > 0)
            {
                for (int i = 0; i < vowels.Length; i++)
                {
                    ansList.Add(vowels[i].ToString());
                }
            }

            for (int i = 1; i < n; i++)
            {
                var list = new List<string>();
                for (int j = 0; j < ansList.Count(); j++)
                {
                    list.AddRange(Fun(ansList[j]));
                }
                ansList = list;
            }


            List<string> Fun(string str)
            {
                var list = new List<string>();
    
                
                for (int i = 0; i < vowels.Length; i++)
                {
                    if (str[str.Length-1] <= vowels[i])
                    {
                        list.Add(str + vowels[i]);
                    }
 

                }
                return list;
            }
            return ansList.Count();
        }

        static int CountVowelStrings2(int n)
        {
            var s = 0;

            for (int i = 0; i < 5; i++)
            {
                Recursion(i, 1);
            }

            return s;

            void Recursion(int c, int l)
            {
                //終止條件
                if (l >= n)
                {
                    s++;
                    return;
                }

                //循環
                for (int i = c; i < 5; i++)
                {
                    Recursion(i, l + 1);
                }
            }
        }

    }



}
