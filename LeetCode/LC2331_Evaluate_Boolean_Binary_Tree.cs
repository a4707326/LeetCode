using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC2331_Evaluate_Boolean_Binary_Tree
    {
        public static void Start()
        {
            Console.WriteLine("LC2331_Evaluate_Boolean_Binary_Tree");


            TreeNode root = new TreeNode(2);
            root.left = new TreeNode(1);
            root.right = new TreeNode(3);
            root.left.left = null;
            root.left.right = null;
            root.right.left = new TreeNode(0);
            root.right.right = new TreeNode(1);

            Console.WriteLine(EvaluateTree3(root));


        }

        //Input: root = [2,1,3,null,null,0,1]
        //Output: true
        //时间复杂度为 O(n)，其中 n 是节点数；空间复杂度为 O(h)，其中 h 是树的高度。
        public static bool EvaluateTree(TreeNode root)
        {

            if (root.left == null || root.right ==null)
            {
                return root.val == 1 ? true : false;
            }

            bool leftNode = EvaluateTree(root.left);
            bool rightNode = EvaluateTree(root.right);

            if (root.val == 2)
            {
                if (leftNode || rightNode)
                {
                    return true;
                }
            }
            if (root.val == 3)
            {
                if (leftNode && rightNode)
                {
                    return true;
                }
            }
            return root.val == 1 ? true : false;
        }

        //更簡潔
        public static bool EvaluateTree2(TreeNode node) => node.val switch
        {
            0 => false,
            1 => true,
            2 => EvaluateTree(node.left) || EvaluateTree(node.right),
            3 => EvaluateTree(node.left) && EvaluateTree(node.right),
        };


        //符合LeetCode 格式
        public static bool EvaluateTree3(TreeNode root)
        {
            return root.val switch
            {
                0 => false,
                1 => true,
                2 => EvaluateTree(root.left) || EvaluateTree(root.right),
                3 => EvaluateTree(root.left) && EvaluateTree(root.right),
            };
        }


    }


}
