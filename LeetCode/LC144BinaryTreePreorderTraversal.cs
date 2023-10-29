using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC144BinaryTreePreorderTraversal
    {

        static List<int> list = new List<int>();
        public static void Start()
        {
            Console.WriteLine("LC144BinaryTreePreorderTraversal");





            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(3);
            root.left.left = new TreeNode(4);
            root.left.right = new TreeNode(5);


            //TreeNode root = new TreeNode(1);
            //root.left = new TreeNode(4);
            //root.right = new TreeNode(3);
            //root.left.left = new TreeNode(2);

            //TreeNode root = new TreeNode(1);
            //root.right = new TreeNode(2);
            //root.right.left = new TreeNode(3);
            ////Output: [1,2,3]


            var ans = PreorderTraversal(root);


            foreach (int i in ans) 
            {
                Console.WriteLine(i.ToString());
            }



        }

        //Input: root = [1,null,2,3]
        //Output: [1,2,3]
        public static IList<int> PreorderTraversal(TreeNode root)
        {
            if (root == null) return list;
            
            PreorderTraversalStart(root);
            return list;

        }

        public static void PreorderTraversalStart(TreeNode root)
        {
            if (root == null) return;
            list.Add(root.val);
            PreorderTraversalStart(root.left);
            PreorderTraversalStart(root.right);

        }





    }


}
