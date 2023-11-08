using System;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC912_Sort_an_Array
    {
        public static void Start()
        {
            Console.WriteLine("LC912_Sort_an_Array");

            int[] nums = { 5, 2, 3, 1 };

            var ans = SortArray(nums);


            foreach (int i in ans) 
            {
                Console.WriteLine(i.ToString());
            }


        }

        //Input: nums = [5,2,3,1]
        //Output: [1,2,3,5]
        //O(N log N)
        //分治法//合併排序
        public static int[] SortArray(int[] nums)
        {
            // 如果數組長度小於等於1，則已經是排序好的數組，直接返回
            if (nums.Length <= 1)
            {
                return nums;
            }

            // 找到數組中間位置
            int mid = nums.Length / 2;

            // 遞歸地對左右兩部分進行合併排序
            int[] leftNums = SortArray(nums.Take(mid).ToArray());//取前半段
            int[] rightNums = SortArray(nums.Skip(mid).ToArray());//取後半段

            // 合併已排序的左右兩部分
            return Merge(leftNums, rightNums);
        }

        // 合併兩個已排序的數組(這裡一開始會被猜成最小然後一直遞迴排序加到最大)
        private static int[] Merge(int[] leftNums, int[] rightNums)
        {
            int[] merged = new int[leftNums.Length + rightNums.Length];
            int i = 0;//leftNums的pointer
            int j = 0;//rightNums的pointer
            int k = 0;//merged的pointer

            // 比較左右兩部分的元素，選擇較小的元素放入合併後的數組中
            while (i < leftNums.Length && j < rightNums.Length)//左右兩邊的指針都不溢出
            {
                if (leftNums[i] < rightNums[j])
                {
                    merged[k] = leftNums[i];
                    i++;//移動後指針+1
                }
                else
                {
                    merged[k] = rightNums[j];
                    j++;//移動後指針+1
                }
                k++;//添加後指針+1
            }


            // 將剩餘的元素放入合併後的數組中
            //因為左右都是已經排序了所以可以直接加
            while (i < leftNums.Length)
            {
                merged[k] = leftNums[i];
                i++;
                k++;
            }

            while (j < rightNums.Length)
            {
                merged[k] = rightNums[j];
                j++;
                k++;
            }

            // 返回合併後的數組
            return merged;
        }




    }


}
