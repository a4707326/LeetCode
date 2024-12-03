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
        public static void PrintTree2(TreeNode root)
        {
            List<IList<string>> result = new();
            int height = GetTreeHeight(root);
            int length = (int)Math.Pow(2, height) - 1;
            for (int i = 0; i < height; i++)
            {
                List<string> temp = new();
                for (int j = 0; j < length; j++)
                {
                    temp.Add(" ");
                }
                result.Add(temp);
            }

            TraverseTree(root, 0, (length - 1) / 2, height - 1);
            foreach (var i in result)
            {
                string a = "";
                foreach (var j in i)
                {
                    a += j;

                }
                Console.WriteLine(a.ToString());
            }


            void TraverseTree(TreeNode root, int i, int j, int height)
            {
                if (root == null) return;
                result[i][j] = root.val.ToString();
                int next = (int)Math.Pow(2, height - i - 1);
                TraverseTree(root.left, i + 1, j - next, height);
                TraverseTree(root.right, i + 1, j + next, height);
            }

            int GetTreeHeight(TreeNode root)
            {
                if (root == null) return 0;
                return 1 + Math.Max(GetTreeHeight(root.left), GetTreeHeight(root.right));
            }
        }

    }
}
