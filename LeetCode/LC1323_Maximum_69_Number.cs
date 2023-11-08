using System;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC1323_Maximum_69_Number
    {
        public static void Start()
        {



            Console.WriteLine("LC1323_Maximum_69_Number");

            int nums = 9669;


            var ans = Maximum69Number(nums);

            Console.WriteLine(ans);





        }

        //Input: num = 9669
        //Output: 9969
        //猜 O(N)
        //O(N)
        //LC
        //可以被歸類為貪婪算法
        public static int Maximum69Number(int num)
        {
            //取第一個6變成9即答案
            char[] chars = num.ToString().ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == '6')
                {
                    chars[i] = '9';
                    return int.Parse(chars);
                }
            }

            return num;
        }

    }

}
