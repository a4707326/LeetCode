using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC648_Replace_Words
    {
        public static void Start()
        {
            Console.WriteLine("LC648_Replace_Words");

            string[] dictionary = { "cat", "bat", "rat" };
            string sentence = "the cattle was rattled by the battery";

            var ans = ReplaceWords2(dictionary, sentence);

            Console.WriteLine(ans);

            //foreach (int i in ans) 
            //{
            //    Console.WriteLine(i.ToString());
            //}


        }

        //Input: dictionary = ["cat","bat","rat"], sentence = "the cattle was rattled by the battery"
        //Output: "the cat was rat by the bat"
        //你的 ReplaceWords 方法的时间复杂度是 O(N* M * K)，其中 N 是句子中的单词数量，M 是字典中的单词数量，K 是单词的平均长度。
        public static string ReplaceWords(IList<string> dictionary, string sentence)
        {
            string[] words = sentence.Split(" ");
            StringBuilder sb = new StringBuilder();


            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < dictionary.Count; j++)
                {
                    if (words[i].Length < dictionary[j].Length)
                    {
                        continue;
                    }

                    for (int k = 0; k < dictionary[j].Length; k++)
                    {

                        if (words[i][k] != dictionary[j][k])
                        {
                            break;
                        }
                        if (k == dictionary[j].Length - 1)
                        {
                            words[i] = dictionary[j];
                        }

                    }

                }
            }

            for (int i = 0; i < words.Length; i++)
            {
                sb.Append(words[i] + " ");
            }

            return sb.ToString().TrimEnd();



        }


        public static string ReplaceWords2(IList<string> dictionary, string sentence)
        {
            TrieNode root = new TrieNode();


            foreach (var word in dictionary)
            {
                TrieNode node = root;
                foreach (var c in word) 
                {
                    int index = c - 'a';
                    if (node.Children[index] == null)
                    {
                        node.Children[index] = new TrieNode();
                    }
                    node = node.Children[index];
                }
                node.IsEndOfWord = true;
            }

            string[] words = sentence.Split(" ");
            StringBuilder sb = new StringBuilder();

            foreach (var word in words) 
            {
                TrieNode node = root;
                StringBuilder prefix = new StringBuilder();


                foreach (char c in word)
                {
                    int index = c - 'a';
                    if (node.Children[index] == null || node.IsEndOfWord)
                    {
                        break;
                    }

                    prefix.Append(c);
                    node = node.Children[index];
                }
                sb.Append(node.IsEndOfWord ? prefix.ToString() : word);
                sb.Append(' ');
            }

            return sb.ToString().TrimEnd();
        }





        //sentence += " ";
        //for (int i = 0; i < dictionary.Count; i++)
        //{
        //    int bIndex = sentence.IndexOf(dictionary[i]);
        //    int nIndex = sentence.IndexOf(' ', bIndex);
        //    string word = sentence.Substring(bIndex, nIndex - bIndex);
        //    sentence = new string(sentence.Replace(word, dictionary[i]));
        //}
        //return sentence.TrimEnd();


    }


}
