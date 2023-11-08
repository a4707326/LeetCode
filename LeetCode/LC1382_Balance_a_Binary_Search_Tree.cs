using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC1382_Balance_a_Binary_Search_Tree
    {
        static List<int> resultList = new ();
        public static void Start()
        {
            Console.WriteLine("LC1382_Balance_a_Binary_Search_Tree");


            // 初始化樹的結構
            TreeNode root = new TreeNode(1);
            root.right = new TreeNode(2);
            root.right.right = new TreeNode(3);
            root.right.right.right = new TreeNode(4);




            var ans = BalanceBST(root);

            //while (ans != null)
            //{
            //    Console.WriteLine(ans.val);
            //    ans = ans.left;
            //    ans = ans.right;

            //}
            //foreach (int i in ans)
            //{
            //    Console.WriteLine(i.ToString());
            //}

        }

        //Input: root = [1,null,2,null,3,null,4,null,null]
        //Output: [2,1,3,null,null,null,4]
        //Explanation: This is not the only correct answer, [3,1,4,null,2] is also correct.
        public static TreeNode BalanceBST(TreeNode root)
        {
            //1.先用遍例樹添加至一個數組
            //2.再用建立新樹

            List<int> treeList = new List<int>();
            Inorder(root);
            return Balance(0, treeList.Count() - 1);


            void Inorder(TreeNode root)
            {
                if (root == null)
                    return;

                Inorder(root.left);
                treeList.Add(root.val);
                Inorder(root.right);
            }

            TreeNode Balance(int start, int end)
            {
                if (start > end) return null;

                int mid = (start + end) / 2;

                TreeNode root = new TreeNode();
                root.val = treeList[mid];
                root.left = Balance(start, mid - 1);
                root.right = Balance(mid + 1, end);
                return root;
            }

        }
        



    }


}
