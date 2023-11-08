using Microsoft.VisualBasic;
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
    internal class TestProblem
    {

        // 請實作一個方法在傳入數字(不考慮負數)陣列後將元素進行組合，得出最大的數字，並以字串型別回傳

        // Interface:
        // Input: int[]
        // Output: string

        // Example:
        // Input: [1, 2, 3]; Output: "321";
        // Input: [10, 2]; Output: "210";
        // Input: [3, 30, 34, 5, 9]; Output: "9534330";


        //static List<string> strings = new List<string>();

        public static void Start()
        {
            Console.WriteLine("TestProblem");



            string result1 = Process(new int[] { 1, 2, 3 });
            string result2 = Process(new int[] { 10, 2 });
            string result3 = Process(new int[] { 3, 30, 34, 5, 9 });


            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);


        }



        //這段程式碼的時間複雜度是 O(N!)，其中 N 為 input 數組的長度。這是因為在 DFS 函數中，我們使用了遞迴，每一層的遞迴都會嘗試 N 個不同的數字，因此總共有 N! 種可能的排列組合。在每一種排列組合中，我們需要花費 O(N) 的時間來建立字符串。所以總體時間複雜度為 O(N* N!)，即 O(N!)。
        //所以總體時間複雜度為 O(N* N!)，即 O(N!)。
        public static string Process(int[] input)
        {

            List<string> strings = new List<string>();
            DFS(input, new List<string>(), new bool[input.Length], strings);


            return strings.Max(x => int.Parse(x).ToString());
            //return strings.MaxBy(x => int.Parse(x));
           
        }
        public static void DFS(int[] input,List<string> sub ,bool[] isUsed, List<string> strings )
        {

            if (sub.Count == input.Length)
            {
                strings.Add(string.Join("",sub));
                return;
            }

            for (int i = 0; i < input.Length; i++)
            {
                if (isUsed[i]) continue;
                isUsed[i] = true;
                sub.Add(input[i].ToString());
                DFS(input, sub, isUsed, strings);
                sub.RemoveAt(sub.Count - 1);
                isUsed[i] = false;

            }
        }


    }


}
