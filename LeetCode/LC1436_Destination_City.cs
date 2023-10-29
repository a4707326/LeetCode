using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC1436_Destination_City
    {
        public static void Start()
        {
            Console.WriteLine("LC1436_Destination_City");


            List<IList<string>> input1 = new()
            {
                new List<string> { "London", "New York" },
                new List<string> { "New York", "Lima" },
                new List<string> { "Lima", "Sao Paulo" }
            };

            var ans = DestCity2(input1);
            Console.WriteLine(ans.ToString());

        }
        //Input: paths = [["London","New York"],["New York","Lima"],["Lima","Sao Paulo"]]
        //Output: "Sao Paulo" 
        public static string DestCity(IList<IList<string>> paths)
        {

            Dictionary<string, int> directory = new();

            foreach (var path in paths) 
            {

                foreach (var item in path) 
                {

                    if (directory.ContainsKey(item)) 
                    {
                        directory[item] ++ ;
                    }
                    else
                    {
                        //directory.Add(item, 1);
                        directory[item] = 1;
                        if (path[0] == item)
                        {
                            directory[item]++;
                        }
                    }

                }
            }

            foreach (var kvp in directory)
            {
                if (kvp.Value == 1)
                {
                    return kvp.Key;
                }
            }
            return "" ;
        }



        public static string DestCity2(IList<IList<string>> paths)
        {
            Dictionary<string, string> dc = new();
            foreach (var path in paths)
                dc[path[0]] = path[1];
            string station = paths[0][0];
            while (dc.ContainsKey(station))
                station = dc[station];
            return station;
        }
    }



}
