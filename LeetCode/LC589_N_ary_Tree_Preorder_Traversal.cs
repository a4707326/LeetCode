using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC589_N_ary_Tree_Preorder_Traversal
    {

        public static List<int> ans = new List<int>();
        public static void Start()
        {
            Console.WriteLine("LC589_N_ary_Tree_Preorder_Traversal");


            Node root = new Node(1);
            root.children = new List<Node>
            {
                new Node(3, new List<Node>
                {
                     new Node(5),
                     new Node(6)
                }),

                   new Node(2),
                   new Node(4),

            };




            var ans = Preorder(root);



            foreach (int i in ans) 
            {
                Console.WriteLine(i.ToString());
            }





        }


        //Input: root = [1,null,3,2,4,null,5,6]
        //Output: [1,3,5,6,2,4]
        //这个方法的时间复杂度是 O(N)
        public static IList<int> Preorder(Node root)
        {

            PreorderStart(root);
            return ans;
        }
        
        public static void PreorderStart(Node root)
        {
            if (root == null) return;
            ans.Add(root.val);

            if (root.children == null) return;

            foreach (var item in root.children)
            {
                PreorderStart(item);
            }
        }


    }


}
