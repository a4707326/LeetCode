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
    internal class LC108_Convert_Sorted_Array_to_Binary_Search_Tree
    {
        static List<int> resultList = new ();
        public static void Start()
        {
            Console.WriteLine("LC108_Convert_Sorted_Array_to_Binary_Search_Tree");

            int[] nums = new int[] { -10, -3, 0, 5, 9 };


            var ans = SortedArrayToBST(nums);

        }


        //Input: nums = [-10,-3,0,5,9]
        // Output: [0,-3,9,-10,null,5]
        //猜O[N!]
        //由於每個節點都只被訪問一次，所以時間複雜度是O(n)
        public static TreeNode SortedArrayToBST(int[] nums)
        {
            //防呆
            if (nums == null || nums.Length == 0)
            {
                return null;
            }

            //建立BST樹
            return CreateBST( 0, nums.Length - 1);

            //需要帶入左右的邊界
            TreeNode CreateBST( int left, int right)
            {
                //終止條件
                if (left > right)
                {
                    return null;
                }
                
                int mid = left + (right - left) / 2;//取中間
                TreeNode root = new TreeNode(nums[mid]);//建立節點
                root.left = CreateBST(left, mid - 1);//先走左DFS
                root.right = CreateBST(mid + 1, right);//在走右DFS

                return root;
            }
        }
        //先走左DFS
        //[0,1,2,3,4,5,6] left = 0 right = 5
        //mid 3
        //[0,1,2,3,4,5,6] left = 0 right = 2
        //mid 1
        //[0,1,2,3,4,5,6] left = 0 right = 0
        //mid 0
        //[0,1,2,3,4,5,6] left = 0 right = -1
        //mid null
        //[0,1,2,3,4,5,6] left = 1 right = 0
        //mid null
        //在走右DFS
        //[0,1,2,3,4,5,6] left = 1 right = 2
        //mid 2




        //Input: nums = [-10,-3,0,5,9]
        // Output: [0,-3,9,-10,null,5]
        //它們的時間複雜度是 O(k)
        public static TreeNode SortedArrayToBST2(int[] nums)
        {
            //防呆
            if (nums.Length == 0) return null;
            //只有一個
            if (nums.Length == 1) return new TreeNode(nums[0], null, null);

            //取中間
            int mid = nums.Length / 2;

            return new TreeNode(
                nums[mid],
                SortedArrayToBST2(nums.Take(mid).ToArray()),
                SortedArrayToBST2(nums.Skip(mid + 1).ToArray())
            );

        }




    }


}
