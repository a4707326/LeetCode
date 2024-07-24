using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class ArrayInt_Int
    {
        public static void Start()
        {
            Console.WriteLine("LC2079_Watering_Plants");



            int[] nums = { 2, 2, 3, 3 };
            int[] nums2 = { 2, 2, 3, 3 };
            int num = 5;
            int num2 = 1;
            string str = "cba";
            string str2 = "abcd";
            string[] strs = { "eat", "tea", "tan", "ate", "nat", "bat" };

            var ans = ArrayInt_IntF(nums, num);


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
        static int ArrayInt_IntF(int[] plants, int capacity)
        {
            return 0;
        }

    }



}
