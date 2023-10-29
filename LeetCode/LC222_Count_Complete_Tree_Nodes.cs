using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC222_Count_Complete_Tree_Nodes
    {
        static int count = 0;

        public static void Start()
        {
            Console.WriteLine("LC222_Count_Complete_Tree_Nodes");


            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(3);
            root.left.left = new TreeNode(4);
            root.left.right = new TreeNode(5);
            root.right.left = new TreeNode(6);


            var ans = CountNodes2(root);

            Console.WriteLine(ans.ToString());


        }

        //Input: root = [1,2,3,4,5,6]
        //Output: 6
        public static int CountNodes(TreeNode root)
        {
            CountNodesStart(root);
            return count;
        }

        public static void CountNodesStart(TreeNode root)
        {
           if (root == null) return;
            count ++;
            CountNodesStart(root.left);
            CountNodesStart(root.right);

        }


        public static int CountNodes2(TreeNode n) => n is null ? 0 : 1 + CountNodes2(n.left) + CountNodes2(n.right);

    }


}
