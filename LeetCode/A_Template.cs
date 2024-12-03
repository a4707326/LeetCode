using System;
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


            //int?[] input = new int?[] { 1, 2, 3, null, 4 };
            //TreeNode root = TreeNode.BuildTree(input);


            //int[][] m = new int[][]
            //{
            //    new int[] { 0, 1, 2 },
            //    new int[] { 3, 4, 5 },
            //    new int[] { 6, 7, 8 }
            //};


            int[] nums = { 2, 2, 3, 3 };
            //int[] nums2 = { 2, 2, 3, 3 };
            int num = 5;
            //int num2 = 1;
            //string str = "cba";
            //string str2 = "abcd";
            //string[] strs = { "eat", "tea", "tan", "ate", "nat", "bat" };

            var ans = TFunc(nums, num);
            
 

            //foreach ( var i in ans ) 
            //{
            //    Console.WriteLine(i.ToString());
            //}

            //foreach (var i in ans)
            //{
            //    string a = "";
            //    foreach (var j in i)
            //    {
            //        a += j;

            //    }
            //    Console.WriteLine(a.ToString());
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
