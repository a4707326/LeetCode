using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC208_Implement_Trie_Prefix_Tree
    {

        public static void Start()
        {
            Console.WriteLine("LC208_Implement_Trie_Prefix_Tree");


            Trie2 trie = new Trie2();
            trie.Insert("apple");
            trie.Search("apple");   // return True
            //trie.Search("app");     // return False
            //trie.StartsWith("app"); // return True
            //trie.Insert("app");
            //trie.Search("app");     // return True

            Console.WriteLine('a'-'a');
            Console.WriteLine('b'-'a');
            Console.WriteLine('c'-'a');

        }



    }


    //小範圍效率更高
    public class Trie
    {
        HashSet<string> values;
        HashSet<string> keys;
        public Trie()
        {
            values = new HashSet<string>();
            keys = new HashSet<string>();
        }

        public void Insert(string word)
        {
            if (!values.Contains(word))
                values.Add(word);
            for (var i = word.Length; i > 0; i--)
            {
                if (!keys.Contains(word.Substring(0, i)))
                    keys.Add(word.Substring(0, i));
                else
                    break;// all prev string are in KEYS
            }
        }

        public bool Search(string word)
        {
            return values.Contains(word);
        }

        public bool StartsWith(string prefix)
        {
            return keys.Contains(prefix);
        }
    }


    ////大範圍效率更高
    //public class TrieNode
    //{
    //    public TrieNode[] Children { get; }
    //    public bool IsEndOfWord { get; set; }

    //    public TrieNode()
    //    {
    //        Children = new TrieNode[26]; // 26个字母
    //        IsEndOfWord = false;
    //    }
    //}
    public class Trie2
    {
        TrieNode root;
        public Trie2()
        {
            root = new TrieNode();
        }

        public void Insert(string word)
        {

            TrieNode node = root;
            foreach (char c in word)
            {
                int idx = word[c] - 'a';
                if (node.Children[idx] == null)
                {
                    node.Children[idx] = new TrieNode();
                }
                node = node.Children[idx];
            }
            node.IsEndOfWord = true;
        }

        public bool Search(string word)
        {
            TrieNode node = root;
            foreach (char c in word)
            {
                int index = c - 'a';
                if (node.Children[index] == null)
                {
                    return false;
                }
                node = node.Children[index];
            }
            return node.IsEndOfWord;
        }

        public bool StartsWith(string prefix)
        {
            TrieNode node = root;
            foreach (char c in prefix)
            {
                int index = c - 'a';
                if (node.Children[index] == null)
                {
                    return false;
                }
                node = node.Children[index];
            }
            return true;

        }

    }

        //public class Trie
        //{
        //    List<string> list;
        //    public Trie()
        //    {
        //        list = new List<string>();
        //    }

        //    public void Insert(string word)
        //    {
        //       list.Add(word);
        //    }

        //    public bool Search(string word)
        //    {
        //        foreach (var s in list) 
        //        {
        //            if (s == word) 
        //            {
        //                Console.WriteLine(true);
        //                return true;
        //            } 

        //        }
        //        Console.WriteLine(false);
        //        return false;
        //    }

        //    public bool StartsWith(string prefix)
        //    {
        //        //int[] ints = new int[list.Count];

        //        for (int i = 0; i < list.Count; i++)
        //        {

        //            if (list[i].Contains(prefix) && list[i][0] == prefix[0])
        //            {
        //                Console.WriteLine(true);
        //                return true; 
        //            }


        //            //for (int j = 0; j < list[i].Length; j++)
        //            //{
        //            //    for (int k = 0; k < prefix.Length; k++)
        //            //    {
        //            //        if (true)
        //            //        {

        //            //        }
        //            //    }
        //            //}
        //        }
        //        Console.WriteLine(false);
        //        return false;

        //    }
        //}



    }
