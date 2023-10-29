using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class TrieNode
    {

        public TrieNode[] Children;
        public bool IsEndOfWord;

        public TrieNode()
        {
            Children = new TrieNode[26]; // 26个字母
            IsEndOfWord = false;
        }


    }
}
