using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC383_Ransom_Note
    {
        public static void Start()
        {
            Console.WriteLine("LC383_Ransom_Note");



            string str = "aa";
            string str2 = "aab";


            var ans = CanConstruct2(str, str2);



            Console.WriteLine(ans);

        }

        //Input: ransomNote = "aa", magazine = "ab"
        //Output: true
        //Input: ransomNote = "aa", magazine = "aab"
        //Output: true
        static bool CanConstruct(string ransomNote, string magazine)
        {
            List<char> ransomList = new (ransomNote);
            List<char> magazineList = new (magazine);

            while (ransomList.Count > 0) 
            {
                if (magazineList.Contains(ransomList[0]))
                {
                    magazineList.Remove(ransomList[0]);
                    ransomList.RemoveAt(0);
                }
                else
                {
                    return false;
                }

            }


            return true;
        }
        static bool CanConstruct2(string ransomNote, string magazine)
        {
            List<char> list = new(magazine);
            foreach (char c in ransomNote) 
            {
                if (!list.Remove(c))
                {
                    return false;
                }
            }
            return true;
        }
    }



}
