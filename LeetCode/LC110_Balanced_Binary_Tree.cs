using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace LeetCode
{
    internal class LC110_Balanced_Binary_Tree
    {
        static bool isSame = true;
        public static void Start()
        {
            Console.WriteLine("LC110_Balanced_Binary_Tree");




            int?[] ints = new int?[] { 3, 9, 20, null, null, 15, 7 };
            //int?[] ints = new int?[] { 1, 2, 3, 4, 5, 6, null, 8 };

            TreeNode root = TreeNode.BuildTree(ints);

            bool ans = IsBalanced(root);

            Console.WriteLine(ans);


            TreeNode.PrintTree(root);

        }
        //Input: root = [3,9,20,null,null,15,7]
        //Output: true

        public static bool IsBalanced(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }

            int leftHeight = GetHeight(root.left);
            int rightHeight = GetHeight(root.right);

            if (Math.Abs(leftHeight - rightHeight) > 1)
                return false;

            return IsBalanced(root.left) && IsBalanced(root.right);

            int GetHeight(TreeNode node)
            {
                if (node == null)
                {
                    return 0;
                }

                int leftHeight = GetHeight(node.left);
                int rightHeight = GetHeight(node.right);

                return Math.Max(leftHeight, rightHeight) + 1;
            }

        }




    }


}
