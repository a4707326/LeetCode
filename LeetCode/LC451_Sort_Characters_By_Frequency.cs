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
    internal class LC451_Sort_Characters_By_Frequency
    {
        public static void Start()
        {
            Console.WriteLine("LC451_Sort_Characters_By_Frequency");

            string s = "tree";

            var ans = FrequencySort2(s);

            Console.WriteLine(ans.ToString());



        }
        //Input: s = "tree"
        //Output: "eert"
        //這個實現的時間複雜度是 O(n + k log k)
        public static string FrequencySort(string s)
        {
            Dictionary<char,int> counts = new();
            StringBuilder ans = new(); //有沒有使用StringBuilder 差別巨大(和用string比)
            foreach (char c in s)
            {
                if (!counts.TryAdd(c, 1))
                {
                    counts[c]++;
                } 

            }
            var orderCounts = counts.OrderByDescending(c => c.Value);


            foreach (var item in orderCounts)
            {
                for (int i = 0; i < item.Value; i++)
                {
                    ans.Append(item.Key);
                }
            }

            return ans.ToString();
        }

        //時間複雜度是 O(n log n)
        public static string FrequencySort2(string s)
        {
            //var a = s.GroupBy(x => x);
            //var b = s.GroupBy(x => x).OrderByDescending(x => x.Count());
            //var c = s.GroupBy(x => x).OrderByDescending(x => x.Count()).SelectMany(x => x);
            //var e = s.GroupBy(x => x).OrderByDescending(x => x.Count()).Select(x => x);
            //var d = string.Concat(b.Select(x => x));


            return string.Concat(s.GroupBy(x => x).OrderByDescending(x => x.Count()).SelectMany(x => x));
        }






    }


}
