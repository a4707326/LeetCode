using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC111_Minimum_Depth_of_Binary_Tree
    {
        static bool isSame = true;
        public static void Start()
        {
            Console.WriteLine("LC111_Minimum_Depth_of_Binary_Tree");



            int?[] input = new int?[] { 3, 9, 20, null, null, 15, 7 };


            TreeNode root = TreeNode.BuildTree(input);


            var ans = MinDepth(root);


            //Console.WriteLine(ans);

        }

        // Input: root = [3,9,20,null,null,15,7]
        // Output: 2
        //猜O(N),O(N)
        //O(N),O(N) ，如果二叉樹是平衡的，空間是O(logN)。
        //DFS
        //LC
        public static int MinDepth(TreeNode root)
        {
            //遍例
            //找出離root最短的Leef深度

            if (root == null) return 0;
            int midDepth = int.MaxValue;

            DFS(root, 1);

            void DFS(TreeNode node, int depth)
            {
                //中止條件
                if (node == null) return;
                //找答案
                if (node.left == null && node.right == null)
                {
                    if (depth < midDepth)
                    {
                        midDepth = depth;
                    }
                }
                //循環
                DFS(node.left, depth + 1);
                DFS(node.right, depth + 1);

            }

            return midDepth;
            //2
            //n3
            //n4 n5
            //n6   
        }

    }


}
