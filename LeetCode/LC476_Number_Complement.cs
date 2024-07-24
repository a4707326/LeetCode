using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC476_Number_Complement
    {
        public static void Start()
        {
            Console.WriteLine("LC476_Number_Complement");



            int num = 5;

            var ans = FindComplement(num);


            //foreach ( var i in ans ) 
            //{
            //    Console.WriteLine(i.ToString());
            //}

            Console.WriteLine(ans);

        }

        //Input: num = 5
        //Output: 2
        static int FindComplement(int num)
        {
            string s = Convert.ToString(num, 2);
            char[] chars = new char[s.Length];

            for (int i = 0; i < s.Length; i++)
            {
                chars[i] = (s[i] == '0') ? '1' : '0';
            }

            return Convert.ToInt32(new string(chars), 2);
        }
    }



}
