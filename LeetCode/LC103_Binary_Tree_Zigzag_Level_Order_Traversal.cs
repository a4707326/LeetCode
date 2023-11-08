using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC103_Binary_Tree_Zigzag_Level_Order_Traversal
    {
        static bool isSame = true;
        public static void Start()
        {
            Console.WriteLine("LC103_Binary_Tree_Zigzag_Level_Order_Traversal");



            int?[] input = new int?[] { 3, 9, 20, null, null, 15, 7 };


            TreeNode root = TreeNode.BuildTree(input);


            var ans = ZigzagLevelOrder(root);


            //Console.WriteLine(ans);

        }

        // Input: root = [3,9,20,null,null,15,7]
        // Output: [[3],[20,9],[15,7]] 
        //猜O(N)，O(N)
        //O(N)，O(N)
        //BFS
        //LC，Sol
        public static IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {

            var queue = new Queue<TreeNode>();
            List<IList<int>> rowList = new();

            if (root == null) return rowList;
            queue.Enqueue(root);
            bool isReverse = false;
            while (queue.Count > 0)
            {
                int rowSize = queue.Count;
                List<int> row = new();

                for (int i = 0; i < rowSize; i++)
                {
                    TreeNode cur = queue.Dequeue();

                    if (isReverse == false)
                        row.Add(cur.val);
                    else
                        row.Insert(0, cur.val);

                    if (cur.left != null) queue.Enqueue(cur.left);
                    if (cur.right != null) queue.Enqueue(cur.right);

                }
                isReverse = !isReverse;
                rowList.Add(row);
            }
            return rowList;

        }


    }


}
