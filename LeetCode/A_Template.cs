﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class A_Template
    {
        public static void Start()
        {
            Console.WriteLine("Template");



            int[] nums = { 2, 2, 3, 3 };
            int[] nums2 = { 2, 2, 3, 3 };
            int num = 5;
            int num2 = 1;
            string str = "cba";
            string str2 = "abcd";
            string[] strs = { "eat", "tea", "tan", "ate", "nat", "bat" };

            var ans = TFunc(nums, num);


            //foreach ( var i in ans ) 
            //{
            //    Console.WriteLine(i.ToString());
            //}

            ////IList<IList<string>> 
            //foreach (var i in ans)
            //{
            //    foreach (var j in i)
            //    {
            //        Console.WriteLine(j.ToString());
            //    }
            //}

            Console.WriteLine(ans);

        }

        //Input: plants = [2,2,3,3], capacity = 5
        //Output: 14
        //猜O(1),O(1)
        //答O(1),O(1)
        //演算法Greedy
        static int TFunc(int[] plants, int capacity)
        {
            return 0;
        }

    }



}
