using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class MostWordsFound
    {
        public static void Start()
        {
            Console.WriteLine("MostWordsFound");

            var input = new string[] { "alice and bob love leetcode", "i think so too", "this is great thanks very much" };

            var ans = Solution(input);
  
            Console.WriteLine(ans);



        }

        public static int Solution(string[] sentences)
        {
            int num = 0;
            int tempNum ; 

            foreach (string sentence in sentences) 
            {
                tempNum = sentence.Split(" ").Length;

                //int count = sentence.Count(c => c == ' ');
                if (tempNum > num) 
                {
                     num = tempNum;
                }
            }
            return num;
        }
    }



}
