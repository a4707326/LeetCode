using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC326_Power_of_Three
    {
        public static void Start()
        {
            Console.WriteLine("LC326_Power_of_Three");

            int num = 27;


            var ans = IsPowerOfThree(num);



            Console.WriteLine(ans);

        }


        static bool IsPowerOfThree(int n)
        {
            bool ans = false;

            if (n == 1 )
            {
                ans = true;
            }

            if (n == 3 && n % 3 == 0)
            {
                ans = true;
            }

            if (n > 1 && n % 3 == 0)
            {
                ans = IsPowerOfThree(n / 3);
            }

            return ans;


        }
    }



}
