using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC145BinaryTreePostorderTraversal
    {

        static List<int> list = new List<int>();
        public static void Start()
        {
            Console.WriteLine("LC145BinaryTreePostorderTraversal");

            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(3);
            root.left.left = new TreeNode(4);
            root.left.right = new TreeNode(5);

            //Output:[4, 5, 2, 3, 1]



            //TreeNode root = new TreeNode(1);
            //root.right = new TreeNode(2);
            //root.right.left = new TreeNode(3);
            //Output: [3,2,1]


            var ans = PostorderTraversal(root);


            foreach (int i in ans) 
            {
                Console.WriteLine(i.ToString());
            }



        }

        //Input: root = [1,null,2,3]
        //Output: [3,2,1]
        public static IList<int> PostorderTraversal(TreeNode root)
        {

            PostorderTraversalStart(root);
            return list;

        }

        public static void PostorderTraversalStart(TreeNode root)
        {
            if (root == null) return;
            PostorderTraversalStart(root.left);
            PostorderTraversalStart(root.right);
            list.Add(root.val);
        }





    }


}
