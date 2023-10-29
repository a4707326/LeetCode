using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC2103_Rings_and_Rods
    {
        public static void Start()
        {
            Console.WriteLine("LC2103_Rings_and_Rods");


            var input1 = "B0B6G0R6R0R6G9";




            var ans = CountPoints(input1);


            Console.WriteLine(ans.ToString());

        }

        //Input: rings = "B0B6G0R6R0R6G9"
        //Output: 1
        public static int CountPoints(string rings)
        {
            int count = 0;
            Dictionary<int,string> map = new Dictionary<int, string>();

            for (int i = 0; i < rings.Length; i += 2)
            {
                int key = Convert.ToInt32(rings[i + 1].ToString());  // 將實際數值作為鍵
                if (map.ContainsKey(key))
                {
                    map[key] += rings[i].ToString();
                }
                else
                {

                   map.Add(key, rings[i].ToString());

                }
            }


            foreach (var item in map)
            {
                count += item.Value.Distinct().Count() >= 3 ? 1 :0 ;
            }

            return count;

        }

    }



}
