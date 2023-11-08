using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC101_Symmetric_Tree
    {
        static bool isSame = true;
        public static void Start()
        {
            Console.WriteLine("LC101_Symmetric_Tree");

            int?[]ints = new int?[] { 1, 2, 2, 3, 4, 4, 3 };


            TreeNode root = TreeNode.BuildTree(ints);


            bool ans = IsSymmetric(root);

            Console.WriteLine(ans);

        }

        // Input: root = [1,2,2,3,4,4,3]
        // Output: true
        //猜O(N) ,O(N)
        //O(N)，O(N)
        //BFS
        //Sol
        public static bool IsSymmetric(TreeNode root)
        {
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root.left);
            queue.Enqueue(root.right);
            while (queue.Count > 0)//2//4
            {
                var left = queue.Dequeue();//取出//2//3
                var right = queue.Dequeue();//取出//2//3

                if (left == null && right == null) continue;

                if (left == null || right == null) return false;

                if (left.val != right.val) return false;


                queue.Enqueue(left.left);
                queue.Enqueue(right.right);
                queue.Enqueue(left.right);
                queue.Enqueue(right.left);

            }

            return true;
        }
        //Q[2,2]
        //Q[3,3,4,4]
        //Q[4,4,n,n,n,n,n]
        //Q[n,n,n,n,n,n,n,n,n,n]



    }


}
