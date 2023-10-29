using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class FinalValueAfterOperations
    {
        public static void Start()
        {
            Console.WriteLine("FinalValueAfterOperations");

            var input = new string[] { "--X", "X++", "X++" };

            var ans = Solution(input);
  
            Console.WriteLine(ans);



        }

        public static int Solution(string[] operations)
        {
            int num = 0;

            foreach (var item in operations)
            {
                if (item[1] == '+')
                {
                    num++;
                }
                else { num--; }
            }

            return num;
        }
    }



}
