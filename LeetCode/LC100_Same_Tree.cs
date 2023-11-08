using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC100_Same_Tree
    {
        static bool isSame = true;
        public static void Start()
        {
            Console.WriteLine("LC100_Same_Tree");

            int?[] pArray = new int?[] { 1, 2 };
            int?[] qArray = new int?[] { 1, 2, 3 };

            TreeNode p = TreeNode.BuildTree(pArray);
            TreeNode q = TreeNode.BuildTree(qArray);

            bool ans = IsSameTree2(p, q);

            Console.WriteLine(ans);
            //Console.WriteLine{ans.ToString());

            //foreach ( var val in valList) 
            //{
            //    //Console.WriteLine($"{val.ToString()}");
            //}



        }

        //Input: p = [1,2,3], q = [1,2,3]
        //Output: true
        //猜O(N)
        //O(N)，O(N)
        //DFS
        //LC
        public static bool IsSameTree(TreeNode p, TreeNode q)
        {
            DFS(p, q);
            return isSame;
        }
        public static void DFS(TreeNode p, TreeNode q)
        {
            if (p == null && q == null) return;

            if (p == null || q == null)
            {
                isSame = false;
                return;
            }


            if (p.val == q.val)
            {
                DFS(p.left, q.left);
                DFS(p.right, q.right);
            }
            else
            {
                isSame = false;
            }

        }
        //Input: p = [1,2,3], q = [1,2,3]
        //Output: true
        //O(N)，O(N)
        //DFS
        //GPT
        public static bool IsSameTree2(TreeNode p, TreeNode q)
        {
            if (p == null && q == null)
            {
                return true;
            }

            if (p == null || q == null)
            {
                return false;
            }

            // 檢查根節點的值是否相同
            if (p.val != q.val)
            {
                return false;
            }

            // 遞歸檢查左子樹和右子樹
            return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
        }



    }


}
