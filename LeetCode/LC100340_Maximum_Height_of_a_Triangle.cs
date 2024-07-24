using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC100340_Maximum_Height_of_a_Triangle
    {
        public static void Start()
        {
            Console.WriteLine("LC100340_Maximum_Height_of_a_Triangle");



            //int[] nums = { 2, 2, 3, 3 };
            int num = 10;
            int num2 = 1;

            var ans = MaxHeightOfTriangle(num, num2);


            //foreach ( var i in ans ) 
            //{
            //    Console.WriteLine(i.ToString());
            //}

            Console.WriteLine(ans);

        }

        //Input: red = 2, blue = 4
        //Output: 3
        static int MaxHeightOfTriangle(int red, int blue)
        {
            int bkRed = red;
            int bkBlue = blue;
            int max = 0;
            int count = 0;
            int need = 1;

            while (true) 
            {
                if (max == 0) 
                {
                    if (red < need)
                    {
                        break;
                    }
                    red -= need;
                    max = 1;
                }
                else
                {
                    if (blue < need)
                    {
                        break;
                    }
                    blue -= need;
                    max = 0;
                }
                count++;
                need++;
            }

            max = 1;
            red = bkRed;
            blue = bkBlue;
            int count2 = 0;
            need = 1;

            while (true)
            {
                if (max == 0)
                {
                    if (red < need)
                    {
                        break;
                    }
                    red -= need;
                    max = 1;
                }
                else
                {
                    if (blue < need)
                    {
                        break;
                    }
                    blue -= need;
                    max = 0;
                }
                count2++;
                need++;
            }

            return Math.Max(count, count2);

        }

    }



}
