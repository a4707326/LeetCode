using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC398_Random_Pick_Index
    {
        public static void Start()
        {
            Console.WriteLine("LC398_Random_Pick_Index");



            int[] nums = { 1, 2, 3, 3, 3 };
            int[] nums2 = { 2, 2, 3, 3 };
            int num = 5;
            int num2 = 1;
            string str = "cba";
            string str2 = "abcd";
            string[] strs = { "eat", "tea", "tan", "ate", "nat", "bat" };

            Solution2(nums);

            Console.WriteLine(Pick2(3));
            Console.WriteLine(Pick2(1));
            Console.WriteLine(Pick2(3));

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

            //Console.WriteLine(nums);

            //List<int> numList = new List<int>();
            //var numList ;

        }
        static int[] nums1;

        //Input
        //["Solution", "pick", "pick", "pick"]
        //[[[1, 2, 3, 3, 3]], [3], [1], [3]]
        //Output
        //[null, 4, 0, 2]
        public static void Solution(int[] nums)
        {
            nums1 = nums;
        }

        public static int Pick(int target)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < nums1.Length; i++)
            {
                if (target == nums1[i])
                {
                    list.Add(i);
                }
            }

            Random random = new Random();

            return list[random.Next(0, list.Count())];
        }

        static Dictionary<int,List<int>> dict = new();
        static Random random;

        public static void Solution2(int[] nums)
        {
            random = new Random();
            for (int i = 0; i < nums.Length; i++)
            {
                int n = nums[i];
                if (!dict.ContainsKey(n))
                {
                    dict.Add(n, new List<int>());
                }
                dict[n].Add(i);
            }
        }

        public static int Pick2(int target)
        {
            return dict[target][random.Next(0, dict[target].Count())];
        }

    }



}
