using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class WC422_Q1_Check_Balanced_String
    {
        public static void Start()
        {
            Console.WriteLine("WC422_Q1_Check_Balanced_String");


            string str = "11";


            var ans = IsBalanced(str);
            
 

            Console.WriteLine(ans);

        }

        //Input: num = "1234"
        //Output: false
        static bool IsBalanced(string num)
        {
            int even = 0;
            int odd = 0;


            if (num.Length == 0)
            {
                return true;
            }

            if (num.Length == 1)
            {
                return false;
            }

            odd += int.Parse(num[0].ToString());

            for (int i = 1; i < num.Length; i++)
            {


                if ((i + 1) % 2 == 0 )
                {
                    even += int.Parse(num[i].ToString());
                }
                else
                {
                    odd += int.Parse(num[i].ToString());
                }
            }


            if (odd != even)
            {
                return false;
            }
            else
            {
                return true;
            }

            
        }

    }



}
