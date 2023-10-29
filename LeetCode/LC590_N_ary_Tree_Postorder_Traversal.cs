using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC590_N_ary_Tree_Postorder_Traversal
    {

        public static List<int> ans = new List<int>();
        public static void Start()
        {
            Console.WriteLine("LC590_N_ary_Tree_Postorder_Traversal");


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


            //root.children = new List<Node>
            //{
            //    null,
            //    new Node(3, new List<Node>
            //    {
            //        new Node(2),
            //        new Node(4, new List<Node>
            //        {
            //            new Node(5),
            //            new Node(6)
            //        })
            //    })
            //};




            var ans = Postorder(root);



            foreach (int i in ans) 
            {
                Console.WriteLine(i.ToString());
            }

        }

        //Input: root = [1,null,3,2,4,null,5,6]
        //Output: [5,6,3,2,4,1]
        public static IList<int> Postorder(Node root)
        {
            PostorderStart(root);
            return ans;
        }


        public static void PostorderStart(Node root)
        {

            if (root == null) return;
            if (root.children != null)
            {
                foreach (var item in root.children)
                {
                    PostorderStart(item);
                }
            }
            ans.Add(root.val);

        }


    }


}
