using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC199_Binary_Tree_Right_Side_View
    {
        static bool isSame = true;
        public static void Start()
        {
            Console.WriteLine("LC199_Binary_Tree_Right_Side_View");

            int?[] input = new int?[] { 1, 2, 3, null, 5, null, 4 };


            TreeNode root = TreeNode.BuildTree(input);


            var ans = RightSideView(root);


            //Console.WriteLine(ans);

        }

        //使用BFS遍例並取每Row的最後一個放進List
        // Input: root = [1,2,3,null,5,null,4]
        // Output: [1,3,4]
        //猜O(N),O(N)
        //O(N),O(N)
        //BFS
        //LC
        public static IList<int> RightSideView(TreeNode root)
        {

            List<int> list = new();
            if (root == null) return list;
            var queue = new Queue<TreeNode>();//1.建立Queue
            queue.Enqueue(root);
            while (queue.Count > 0)//2.迴圈(Queue > 0)
            {
                int rowSize = queue.Count;
                for (int i = 0; i < rowSize; i++)
                {
                    var cur = queue.Dequeue();//2.1從Queue取出

                    if (cur != null && i == rowSize - 1) list.Add(cur.val);//2.2.找答案
                    if (cur.left != null) queue.Enqueue(cur.left);//2.3.添加Queue
                    if (cur.right != null) queue.Enqueue(cur.right);//2.3.添加Queue
                }
            }
            return list;//3.返回最後答案
        }

    }


}
