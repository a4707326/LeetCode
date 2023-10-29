using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC1302_Deepest_Leaves_Sum
    {
        //1
        public static int deep = 0;
        public static Dictionary<int, int> dic = new Dictionary<int, int>();


        //2
        public int deepestSum = 0;
        public int deepestLevel = 0;

        //public static int ans;
        public static void Start()
        {
            Console.WriteLine("LC1302_Deepest_Leaves_Sum");


            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(3);
            root.left.left = new TreeNode(4);
            root.left.right = new TreeNode(5);
            root.right.right = new TreeNode(6);
            root.left.left.left = new TreeNode(7);
            root.right.right.right = new TreeNode(8);

            var ans =  DeepestLeavesSum(root);


            Console.WriteLine(ans);


        }



        //Input: root = [1,2,3,4,5,null,6,7,null,null,null,null,8]
        //Output: 15
        //你的代码的时间复杂度是O(n)，其中n是树中节点的数量
        public static int DeepestLeavesSum(TreeNode root)
        {
            if (root == null) return 0;

            deep += 1;

            if (!dic.TryAdd(deep, root.val))
            {
                dic[deep] += root.val;
            } 
            

            DeepestLeavesSum(root.left);
            DeepestLeavesSum(root.right);
            deep -= 1;


            return dic[dic.Count];
        }




        public int DeepestLeavesSum2(TreeNode root)
        {
            CalculateDeepestSum(root, 0);
            return deepestSum;
        }
        private void CalculateDeepestSum(TreeNode node, int level)
        {
            if (node == null) return;

            if (level > deepestLevel)
            {
                deepestSum = node.val;
                deepestLevel = level;
            }
            else if (level == deepestLevel)
            {
                deepestSum += node.val;
            }

            CalculateDeepestSum(node.left, level + 1);
            CalculateDeepestSum(node.right, level + 1);
        }


    }


}
