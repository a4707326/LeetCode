using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class NumberOfEmployeesWhoMetTarget
    {
        public static void Start()
        {
            Console.WriteLine("NumberOfEmployeesWhoMetTarget");

            var ans = Solution(new int[] { 0, 1, 2, 3,4 },2);
  
            Console.WriteLine(ans);



        }

        public static int Solution(int[] hours, int target)
        {
            int num = 0;
            foreach (var hour in hours) 
            {
                if (hour >= target)
                {
                    num++;
                }
            }
            return num;
        }
    }



}
