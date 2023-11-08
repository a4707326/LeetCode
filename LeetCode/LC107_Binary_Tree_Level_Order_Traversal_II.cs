using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC107_Binary_Tree_Level_Order_Traversal_II
    {
        static bool isSame = true;
        public static void Start()
        {
            Console.WriteLine("LC107_Binary_Tree_Level_Order_Traversal_II");



            int?[] input = new int?[] { 3, 9, 20, null, null, 15, 7 };


            TreeNode root = TreeNode.BuildTree(input);


            var ans = LevelOrderBottom(root);


            //Console.WriteLine(ans);

        }

        // Input: root = [3,9,20,null,null,15,7]
        // Output: [[15,7],[9,20],[3]]
        //猜O(N)，O(N)
        //O(N)，O(N)
        //BFS
        //LC
        public static IList<IList<int>> LevelOrderBottom(TreeNode root)
        {
            List<IList<int>> rowList = new();
            if (root == null) return rowList;
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                int rowSize = queue.Count;
                List<int> row = new();
                for (int i = 0; i < rowSize; i++)
                {
                    TreeNode cur = queue.Dequeue();
                    if (cur != null) row.Add(cur.val);
                    if (cur.left != null) queue.Enqueue(cur.left);
                    if (cur.right != null) queue.Enqueue(cur.right);
                }
                rowList.Insert(0, row);
            }
            return rowList;
            //[3]
            //[3][9,20]
            //[15,7] [9,20][3]
        }

    }


}
