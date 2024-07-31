using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace LeetCode
{
    internal class LC49_Group_Anagrams
    {
        public static void Start()
        {
            Console.WriteLine("LC49_Group_Anagrams");


            string[] strs = { "eat", "tea", "tan", "ate", "nat", "bat" };

            var ans = GroupAnagrams(strs);


            foreach (var i in ans)
            {
                foreach (var j in i)
                {
                    Console.WriteLine(j.ToString());
                }
            }



        }
        
        //Input: strs = ["eat","tea","tan","ate","nat","bat"]
        //Output: [["bat"],["nat","tan"],["ate","eat","tea"]]
        static IList<IList<string>> GroupAnagrams(string[] strs)
        {

            var data = new Dictionary<string, List<string>>();

            foreach (var item in strs)
            {

                var str = item.ToCharArray();
                Array.Sort(str);

                if (!data.ContainsKey(new string(str)))
                    data.Add(new string(str), new List<string>());

                data[new string(str)].Add(item);
            }

            var result = new List<IList<string>>();

            foreach (List<string> list in data.Values)
                result.Add(list.Cast<string>().ToList().AsReadOnly());

            return result;
        }

    }



}
