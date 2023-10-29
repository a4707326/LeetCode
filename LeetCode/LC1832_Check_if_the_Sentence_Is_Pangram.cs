using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC1832_Check_if_the_Sentence_Is_Pangram
    {
        public static void Start()
        {
            Console.WriteLine("LC1832_Check_if_the_Sentence_Is_Pangram");


            var input1 = "thequickbrownfoxjumpsoverthelazydog";




            var ans = CheckIfPangram3(input1);


            Console.WriteLine(ans.ToString());

        }
        //Input: sentence = "thequickbrownfoxjumpsoverthelazydog"
        //Output: true
        public static bool CheckIfPangram(string sentence)
        {
            int count = 0;

            for (int i = 97; i <= 122; i++)
            {
                count += sentence.Contains(Convert.ToChar(i)) == true ? 1 : 0;
            }
            //Console.WriteLine(count);
            return count == 26 ? true:false ;
        }

        public static bool CheckIfPangram2(string sentence)
        {
            var hashSet = new HashSet<char>(sentence);
            for (int i = 97; i <= 122; i++)
            {
                if (!hashSet.Contains((char)i))
                    return false;
            }
            return true;
        }



        public static bool CheckIfPangram3(string sentence)
        {
            return sentence.Distinct().Count() == 26;
        }
    }



}
