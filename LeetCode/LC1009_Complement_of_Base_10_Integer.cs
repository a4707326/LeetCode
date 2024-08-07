﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC1009_Complement_of_Base_10_Integer
    {
        public static void Start()
        {
            Console.WriteLine("LC1009_Complement_of_Base_10_Integer");

            int num = 5;


            var ans = BitwiseComplement(num);


            Console.WriteLine(ans);

        }

        //Input: n = 5
        //Output: 2

        static int BitwiseComplement(int n)
        {
            string strN = Convert.ToString(n,2);
            char[] charsN = strN.ToCharArray();

            for (int i = 0; i < strN.Length; i++)
            {
                if (strN[i] == '0')
                {
                    charsN[i] = '1';
                }
                else
                {
                    charsN[i] = '0';
                }

                
            }
            return Convert.ToInt32(string.Join("", charsN),2);
        }
    }



}
