using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC94Binary_Tree_Inorder_Traversal
    {
        static List<int> resultList = new ();
        public static void Start()
        {
            Console.WriteLine("LC94Binary_Tree_Inorder_Traversal");



            //TreeNode root = new TreeNode(1);
            //root.right = new TreeNode(2);
            //root.right.left = new TreeNode(3);
            //Output: [1,3,2]


            TreeNode root = new TreeNode(5);
            root.left = new TreeNode(3);
            root.right = new TreeNode(8);
            root.left.left = new TreeNode(1);
            root.left.right = new TreeNode(4);
            root.right.right = new TreeNode(10);
            root.left.left.left = new TreeNode(0);
            //Output 0 -> 1 -> 3 -> 4 -> 5 -> 8 -> 10


            //Console.WriteLine(root.val);
            //Console.WriteLine(root.right);
            //Console.WriteLine(root.left);



            var ans = InorderTraversal(root);


            foreach (int i in ans) 
            {
                Console.WriteLine(i.ToString());
            }

        }

        //Input: root = [1,null,2,3]
        //Output: [1,3,2]
        public static IList<int> InorderTraversal(TreeNode root)
        {

            InorderTraversalStart(root);
            return resultList;
        }

        public static void InorderTraversalStart(TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            InorderTraversalStart(root.left);
            resultList.Add(root.val);
            InorderTraversalStart(root.right);
        }





    }


}
