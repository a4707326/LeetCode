using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class TreeNode
    {

        //Definition for a binary tree node.

        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }


        //public static TreeNode BuildTree(int[] nums)
        //{
        //    if (nums == null || nums.Length == 0)
        //    {
        //        return null;
        //    }
        //    return BuildTreeHelper(nums, 0);
        //}

        //private static TreeNode BuildTreeHelper(int[] nums, int index)
        //{
        //    if (index >= nums.Length || nums[index] == null)
        //    {
        //        return null;
        //    }

        //    TreeNode node = new TreeNode(nums[index]);
        //    node.left = BuildTreeHelper(nums, 2 * index + 1);
        //    node.right = BuildTreeHelper(nums, 2 * index + 2);

        //    return node;
        //}


        public static TreeNode BuildTree(int?[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return null;
            }
            return BuildTreeHelper(nums, 0);
        }

        private static TreeNode BuildTreeHelper(int?[] nums, int index)
        {
            if (index >= nums.Length || nums[index] == null)
            {
                return null;
            }

            TreeNode node = new TreeNode(nums[index].Value);
            node.left = BuildTreeHelper(nums, 2 * index + 1);
            node.right = BuildTreeHelper(nums, 2 * index + 2);

            return node;
        }


        public static void PrintTree(TreeNode root)
        {
            if (root == null)
            {
                Console.WriteLine("Tree is empty.");
                return;
            }

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                int count = queue.Count;
                for (int i = 0; i < count; i++)
                {
                    TreeNode cur = queue.Dequeue();
                    Console.Write(cur.val + " ");

                    if (cur.left != null)
                    {
                        queue.Enqueue(cur.left);
                    }
                    if (cur.right != null)
                    {
                        queue.Enqueue(cur.right);
                    }
                }
                Console.WriteLine(); // 換行表示下一層
            }
        }

    }
}
