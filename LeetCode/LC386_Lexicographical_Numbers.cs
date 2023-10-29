using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC386_Lexicographical_Numbers
    {
        public static List<int> ans = new List<int>();
        public static void Start()
        {
            Console.WriteLine("LC386_Lexicographical_Numbers");


            int n = 100;

            var arr = LexicalOrder2(n);


            foreach (int i in arr) 
            {
                Console.WriteLine(i.ToString());
            }


        }
        //Input: n = 13
        //Output: [1,10,11,12,13,2,3,4,5,6,7,8,9]
        public static IList<int> LexicalOrder(int n)
        {

            TrieNode2 root = new TrieNode2();


            for (int i = 1; i < n + 1; i++)
            {
                TrieNode2 node = root;
                for (int j = 0; j < i.ToString().Length; j++)
                {

                    int index = i.ToString()[j]-48;
                    if (node.Children[index] == null)
                    {
                        node.Children[index] = new TrieNode2();
                    }
                    node = node.Children[index];
                }
                node.IsEndOfWord = true;
            }


            StartAdd(root,0);


            return ans;
        }
        public static void StartAdd(TrieNode2 node, int lastNum = 0)
        {
            if (node == null) return;


            for (int i = 0; i < node.Children.Length; i++)
            {
                if (node.Children[i] != null)
                {
                    ans.Add(i + lastNum);
                    StartAdd(node.Children[i], (i + lastNum) * 10);
                }


            }
        }

        public static IList<int> LexicalOrder2(int n)
        {
            var arr = new int[n];
            arr[0] = 1;
            for (int i = 1, num = 1; i < n; i++)
            {
                if (num * 10 <= n)
                {
                    num *= 10;
                    arr[i] = num;
                }
                else
                {
                    if (num >= n)
                        num /= 10;
                    while ((num % 10) == 9)
                        num /= 10;
                    num++;
                    arr[i] = num;
                }
            }
            return arr;
        }
    }



    internal class TrieNode2
    {

        public TrieNode2[] Children;
        public bool IsEndOfWord;

        public TrieNode2()
        {
            Children = new TrieNode2[10]; // 10個數字
            IsEndOfWord = false;
        }


    }




}
