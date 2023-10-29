using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC938_Range_Sum_of_BST
    {

        public static int ans = 0;
        public static void Start()
        {
            Console.WriteLine("LC938_Range_Sum_of_BST");



            TreeNode root = new TreeNode(10);
            root.left = new TreeNode(5);
            root.right = new TreeNode(15);
            root.left.left = new TreeNode(3);
            root.left.right = new TreeNode(7);
            root.right.right = new TreeNode(18);


            var ans = RangeSumBST2(root,7,15);



            Console.WriteLine(ans);


        }


        //Input: root = [10,5,15,3,7,null,18], low = 7, high = 15
        //Output: 32
        public static int RangeSumBST(TreeNode root, int low, int high)
        {
            if (root == null)
            {
                return 0;
            }
            if (root.val >= low && root.val <= high)
            {
                ans += root.val;
            }

            RangeSumBST(root.left, low, high);
            RangeSumBST(root.right, low, high);
            return ans;

        }


        //间复杂度是 O(N)，空间复杂度在最坏情况下是 O(N)，在平衡的树中是 O(log N)
        //效能和上面差不多，但不需要在外面額外新增一個變數
        public static int RangeSumBST2(TreeNode root, int low, int high)
        {
            int sum = 0;
            if (root == null)
                return sum;
            if (root.val >= low && root.val <= high)
                sum += root.val;

            sum += RangeSumBST2(root.left, low, high);
            sum += RangeSumBST2(root.right, low, high);
            return sum;
        }




    }


}
