using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC102_Binary_Tree_Level_Order_Traversal
    {
        static bool isSame = true;
        public static void Start()
        {
            Console.WriteLine("LC102_Binary_Tree_Level_Order_Traversal");

            int?[] input = new int?[] { 3, 9, 20, null, null, 15, 7 };


            TreeNode root = TreeNode.BuildTree(input);


            var ans = LevelOrder(root);

            foreach (var val in ans)
            {
                foreach (var item in val) 
                {
                    Console.WriteLine(item);

                }
            }

        }

        // Input: root = [3,9,20,null,null,15,7]
        // Output: [[3],[9,20],[15,7]]
        //O(N)，O(N)
        //BFS
        //LC，Sol
        public static IList<IList<int>> LevelOrder(TreeNode root)
        {

            var queue = new Queue<TreeNode>();
            List<IList<int>> list = new();
            if (root == null) return list;
            queue.Enqueue(root);

            while (queue.Count > 0)
            {

                int rowCount = queue.Count;//每一Row的的固定數量(取之當前queue)，因為 queue.Count會變動，所以這裡先記錄
                List<int> row = new();

                for (int i = 0; i < rowCount; i++)
                {

                    TreeNode cur = queue.Dequeue();//取出node
                    row.Add(cur.val);//添加val

                    if (cur.left != null)
                    {
                        queue.Enqueue(cur.left);//queue添加
                    }
                    if (cur.right != null)
                    {
                        queue.Enqueue(cur.right);//queue添加
                    }
                }

                list.Add(row);//將完成的row添加至list

            }
            return list;

        }


    }


}
