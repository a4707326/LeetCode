using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC2418Sort_the_People
    {
        public static void Start()
        {
            Console.WriteLine("LC2418Sort_the_People");


            var input1 = new string[] { "Mary", "John", "Emma" };
            var input2 = new int[] { 180, 165, 170 };



            var ans = SortPeople(input1, input2);

            foreach (var item in ans)
            {

                Console.WriteLine(item.ToString());
            }


        }

        //Input: names = ["Mary", "John", "Emma"], heights = [180, 165, 170]
        //Output: ["Mary","Emma","John"]
        public static string[] SortPeople(string[] names, int[] heights)
        {
            Dictionary<int, string> map = new();

            for (int i = 0; i < heights.Length; i++)
            {
                map.Add(heights[i], names[i]);
            }

            //map.OrderByDescending(x => x.Key);
            map = new Dictionary<int, string>(map.OrderByDescending(x => x.Key));

            return map.Values.ToArray();
        }

        //記憶體好一點
        public static string[] SortPeople2(string[] names, int[] heights)
        {
            Array.Sort(heights, names);
            var name = names.ToList<string>();
            name.Reverse();
            return name.ToArray();
        }


    }

}
