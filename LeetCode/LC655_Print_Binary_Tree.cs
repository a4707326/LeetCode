using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC655_Print_Binary_Tree
    {
        public static void Start()
        {
            Console.WriteLine("LC655_Print_Binary_Tree");



            int?[] input = new int?[] { 1, 2, 3, null, 4 };
            TreeNode root = TreeNode.BuildTree(input);


            var ans = PrintTree(root);


            foreach (var i in ans)
            {
                string a = "";
                foreach (var j in i)
                {
                    a += j;
                    
                }
                Console.WriteLine(a.ToString());
            }
        }

        //        Input: root = [1,2,3,null,4]
        //        Output: 
        //[["","","","1","","",""],
        // ["","2","","","","3",""],
        // ["","","4","","","",""]]
        //sol，noK
        
        static IList<IList<string>> PrintTree(TreeNode root)
        {
            List<IList<string>> result = new();
            int height = GetTreeHeight(root);
            int length = (int)Math.Pow(2, height) - 1;
            for (int i = 0; i < height; i++)
            {
                List<string> temp = new();
                for (int j = 0; j < length; j++)
                {
                    temp.Add("");
                }
                result.Add(temp);
            }
            //,0,3,2
            TraverseTree(root, 0, (length - 1) / 2, height - 1);
            return result;


            void TraverseTree(TreeNode root, int i, int j, int height)
            {
                if (root == null) return;
                result[i][j] = root.val.ToString();
                int next = (int)Math.Pow(2, height - i - 1);
                TraverseTree(root.left, i + 1, j - next, height);
                TraverseTree(root.right, i + 1, j + next, height);
            }

            int GetTreeHeight(TreeNode root)
            {
                if (root == null) return 0;
                return 1 + Math.Max(GetTreeHeight(root.left), GetTreeHeight(root.right));
            }
        }

    }



}
