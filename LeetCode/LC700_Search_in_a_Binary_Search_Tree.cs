using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC700_Search_in_a_Binary_Search_Tree
    {
        public static void Start()
        {
            Console.WriteLine("LC700_Search_in_a_Binary_Search_Tree");

            //TreeNode root = new TreeNode(4);
            //root.left = new TreeNode(2);
            //root.right = new TreeNode(7);
            //root.left.left = new TreeNode(1);
            //root.left.right = new TreeNode(3);


            TreeNode root = new TreeNode(18);
            root.left = new TreeNode(2);
            root.right = new TreeNode(22);
            root.right.right = new TreeNode(63);
            root.right.right.right = new TreeNode(84);


            var ans = SearchBST(root,63);

            Console.WriteLine(ans.val);


        }


        //

        //这个方法的时间复杂度与树的结构相关，最坏情况下可能需要遍历整个树，时间复杂度为 O(n)，其中 n 是树中节点的数量。在平衡二叉搜索树的情况下，时间复杂度会更低，为 O(log n)。你的实现非常简洁且有效。
        //Input: root = [4,2,7,1,3], val = 2
        //Output: [2,1,3]
        public static TreeNode SearchBST(TreeNode root, int val)
        {
            if (root == null) return null;
            if (root.val == val) return root;
            TreeNode left = SearchBST(root.left, val);
            TreeNode right = SearchBST(root.right, val);
            return left == null ? right : left;
        }






    }


}
