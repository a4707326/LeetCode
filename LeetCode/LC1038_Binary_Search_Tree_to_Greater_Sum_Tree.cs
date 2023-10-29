using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC1038_Binary_Search_Tree_to_Greater_Sum_Tree
    {

        static Array[] sumArr = new Array[100];
        static List<int>  valList = new();
        public static void Start()
        {
            Console.WriteLine("LC1038_Binary_Search_Tree_to_Greater_Sum_Tree");

            int[] nums = { -4, -1, 0, 3, 10 };

            TreeNode root = new TreeNode(4,
                            new TreeNode(1,
                            new TreeNode(0),
                            new TreeNode(2, null, new TreeNode(3))),
                            new TreeNode(6,
                            new TreeNode(5),
                            new TreeNode(7, null, new TreeNode(8)))
            );

            var ans = BstToGst(root);


            foreach ( var val in valList) 
            {
                //Console.WriteLine($"{val.ToString()}");
            }



        }



        //Input: root = [4,1,6,0,2,5,7,null,null,null,3,null,null,null,8]
        //Output: [30,36,21,36,35,26,15,null,null,null,33,null,null,null,8]
        //这个算法的时间复杂度是 O(N)，其中 N 是BST中的节点数量，因为它需要遍历每个节点一次。这个算法在空间上使用了递归调用堆栈，其深度取决于BST的高度，最坏情况下是 O(N)。
        public static TreeNode BstToGst(TreeNode root)
        {
            BstToGstStart(root);
            return root;
        }
        static int num = 0;
        public static void BstToGstStart(TreeNode root)
        {
            if (root == null) return;
            BstToGstStart(root.right);
            valList.Add(root.val);
            num += root.val;
            root.val = num;
            BstToGstStart(root.left);

        }





    }


}
