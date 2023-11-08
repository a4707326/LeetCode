using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC104_Maximum_Depth_of_Binary_Tree
    {
        static bool isSame = true;
        public static void Start()
        {
            Console.WriteLine("LC104_Maximum_Depth_of_Binary_Tree");

            int?[] input = new int?[] { 3, 9, 20, null, null, 15, 7 };


            TreeNode root = TreeNode.BuildTree(input);


            var ans = MaxDepth(root);

            Console.WriteLine(ans);

        }

        // Input: root = [3,9,20,null,null,15,7]
        // Output: 3
        //猜O(N)
        //O(N)，O(N)
        //DFS
        //LC
        public static int MaxDepth(TreeNode root)
        {

            //if(root == null) return 0;//防呆

            int max = 0;
            DFS(root, 1);
            return max;

            void DFS(TreeNode node, int layer)
            {
                //終止條件
                if (node == null) return;

                //找答案
                if (layer > max) max = layer;

                //循環
                DFS(node.left, layer +1);
                DFS(node.right, layer +1);

            }
        }


    }


}
