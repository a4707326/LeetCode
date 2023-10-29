using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC692_Top_K_Frequent_Words
    {
        public static void Start()
        {
            Console.WriteLine("LC692_Top_K_Frequent_Words");

            string[] words = {"i","love","leetcode","i","love","coding","a", "a", "ab", "b", "b", "ab" };
            int k = 2;

            var ans = TopKFrequent(words,k);


            foreach (var i in ans) 
            {
                Console.WriteLine(i.ToString());
            }


        }

        //Input: words = ["i","love","leetcode","i","love","coding"], k = 2
        //Output: ["i","love"]
        public static IList<string> TopKFrequent(string[] words, int k)
        {
            //TrieNode root = new();
            //foreach (var word in words) 
            //{
            //    TrieNode node = root;
            //    foreach(var c in word) 
            //    {
            //        int index = c - 'a';
            //        if (node.Children[index] == null)
            //        {
            //            node.Children[index] = new TrieNode();
            //        }
            //        node = node.Children[index];
            //    }
            //    node.IsEndOfWord = true;
            //}

            //HashSet<string> ans = new HashSet<string>();
            //Dictionary<string,int> dic = new ();
            //int max = 0;
            //foreach (var word in words) 
            //{
            //    if (!dic.TryAdd(word,1))
            //    {
            //        dic[word]++;
            //    }
            //    if (dic[word] > max)
            //    {
            //        max = dic[word];
            //    }

            //}

            ////List<string> maxList = dic.Where(x => x.Value == max).ToList();

            //List<string> maxList = dic.Where(x => x.Value == max).Select(x => x.Key).ToList();












            //var ss1 = words.GroupBy(word => word);
            //var ss2 = words.GroupBy(word => word).OrderByDescending(freq => freq.Count());
            //var ss3 = words.GroupBy(word => word).OrderByDescending(freq => freq.Count()).ThenBy(freq => freq.Key);
            //var ss4 = words.GroupBy(word => word).OrderByDescending(freq => freq.Count()).ThenBy(freq => freq.Key).Take(k);
            //var ss5 = words.GroupBy(word => word).OrderByDescending(freq => freq.Count()).ThenBy(freq => freq.Key).Take(k).Select(x => x.Key);
            var ss6 = words.GroupBy(word => word).OrderByDescending(freq => freq.Count()).ThenBy(freq => freq.Key).Take(k).Select(x => x.Key).ToList();


            return ss6;
        }







    }


}
