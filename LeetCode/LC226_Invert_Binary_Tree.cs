using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC226_Invert_Binary_Tree
    {
        public static List<int> nodeList = new List<int>();
        public static int nodeIdx = -1;
        public static void Start()
        {
            Console.WriteLine("LC226_Invert_Binary_Tree");


            TreeNode root = new TreeNode(4);
            root.left = new TreeNode(2);
            root.right = new TreeNode(7);
            root.left.left = new TreeNode(1);
            root.left.right = new TreeNode(3);
            root.right.left = new TreeNode(6);
            root.right.right = new TreeNode(9);


            var ans = InvertTree(root);


            //foreach (int i in nodeList)
            //{
            //    Console.WriteLine(i.ToString());
            //}


        }
        //Input: root = [4,2,7,1,3,6,9]
        //Output: [4,7,2,9,6,3,1]
        //public static TreeNode InvertTree(TreeNode root)
        //{
        //    TreeSearch(root);
        //    //nodeList.Reverse();
        //    CteateTree(new TreeNode());
        //    return root;
        //}



        //public static void TreeSearch(TreeNode root)
        //{
        //    if (root == null) return;
        //    nodeList.Add(root.val);


        //    TreeSearch(root.right);
        //    TreeSearch(root.left);
        //}

        //public static void CteateTree(TreeNode root)
        //{
        //    if(root == null) return;
        //    nodeIdx++;
        //    root.val = nodeList[nodeIdx];
        //    Console.WriteLine(root.val);

        //    root.left = new TreeNode();
        //    root.right = new TreeNode();
        //    CteateTree(root.left);
        //    CteateTree(root.right);


        //    //nodeIdx++;
        //    //if (nodeIdx >= nodeList.Count)
        //    //{
        //    //    return;
        //    //}
        //    //root.right = new TreeNode();
        //    //CteateTree(root.left);


        //    //nodeIdx++;
        //    //if (nodeIdx >= nodeList.Count)
        //    //{
        //    //    return;
        //    //}
        //    //root.left = new TreeNode();
        //    //CteateTree(root.right);
        //}




        public static TreeNode InvertTree(TreeNode root)
        {
            if (root == null) return null;
            var temp = root.left;
            root.left =  root.right;
            root.right = temp;
            InvertTree(root.left);
            InvertTree(root.right);
            return root;
        }



        public static TreeNode InvertTree2(TreeNode root)
        {
            if (root != null)
            {
                var temp = root.left;
                root.left = InvertTree2(root.right);
                root.right = InvertTree2(temp);
            }

            return root;
        }

    }


}
