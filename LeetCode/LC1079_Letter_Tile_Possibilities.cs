using System;
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
    internal class LC1079_Letter_Tile_Possibilities
    {
        //public static List<List<int>> ans = new List<List<int>>();
        static List<string> resultList = new();
        static int result = 0;
        public static void Start()
        {
            Console.WriteLine("LC1079_Letter_Tile_Possibilities");

            string tiles = "ABB";

            var ans = NumTilePossibilities(tiles);

            Console.WriteLine(resultList.Distinct().Count()-1);



        }//13*3 =39
        //A
        //AA
        //AAA
        //AAB
        //AAC

        //AB*4

        //AC*4


        //A
        //AB
        //AC

        //B
        //BA
        //BC

        //C
        //CA
        //CB


        //Input: tiles = "AAB"
        //Output: 8
        //Explanation: The possible sequences are "A", "B", "AA", "AB", "BA", "AAB", "ABA", "BAA".
        //總的時間複雜度是 O(2^n * n)
        public static int NumTilePossibilities(string tiles)
        {
            Backtrack(tiles, new List<char>(),new bool[tiles.Length]);

            return resultList.Distinct().Count() - 1;
        }

        public static void Backtrack(string tiles, List<char> sub, bool[] isExists) 
        {
            //中止條件
            if (sub.Count > tiles.Length)
            {
                return;
            }

            //算答案
            resultList.Add(string.Join("", sub));


            //跌代
            for (int i = 0; i < tiles.Length; i++)
            {
                if (isExists[i] == false)
                {
                    sub.Add(tiles[i]);
                    isExists[i] = true;
                    Backtrack(tiles, sub, isExists);
                    isExists[i] = false;
                    sub.RemoveAt(sub.Count - 1);

                }

            }

        }


        //public static void Backtrack(string tiles, List<char> sub, bool[] isExists)
        //{
        //    //中止條件
        //    if (sub.Count > tiles.Length)
        //    {
        //        return;
        //    }

        //    //算答案
        //    result++;
        //    foreach (char c in sub)
        //    {
        //        Console.WriteLine($" {c}");
        //    }
        //    Console.WriteLine("_");

        //    //跌代
        //    for (int i = 0; i < tiles.Length; i++)
        //    {
        //        if (isExists[i] == false)
        //        {
        //            sub.Add(tiles[i]);
        //            isExists[i] = true;
        //            Backtrack(tiles, sub, isExists);
        //            isExists[i] = false;
        //            sub.RemoveAt(sub.Count - 1);

        //        }

        //    }


        //}

    }
}
