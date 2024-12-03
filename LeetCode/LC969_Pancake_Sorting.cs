using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC969_Pancake_Sorting
    {
        public static void Start()
        {
            Console.WriteLine("LC969_Pancake_Sorting");



            int[] nums = { 3, 2, 4, 1 };


            var ans = PancakeSort2(nums);


            foreach (var i in ans)
            {
                Console.WriteLine(i.ToString());
            }


        }

        //Input: arr = [3,2,4,1]
        //Output: [4,2,4,3]
        //有問題
        static IList<int> PancakeSort(int[] arr)
        {

            int orders = 0;
            List<int> list = new List<int>();

            while (orders < arr.Length) 
            {
                int maxIdx = GetMaxIdx();
                list.Add(maxIdx);
                Flip(maxIdx);
            }



            int GetMaxIdx() 
            {
                int max = 0;
                int maxIdx = 0;
                for (int i = 0; i < arr.Length - orders; i++)
                {
                    if (arr[i] > max)
                    {
                        max = arr[i];
                        maxIdx = i;
                    }
                }
                return maxIdx;
            }

            void Flip( int maxIdx)
            {
                int temp = arr[maxIdx];
                arr[maxIdx] = arr[0];
                arr[0] = temp;

                for (int i = 0, j = arr.Length - orders - 1; i < j ; i++,j--)
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
                orders++;
            }

            return arr;
        }

        //sol
        static IList<int> PancakeSort2(int[] arr)
        {
            void flip(int idx)
            {
                int l = 0, r = idx;
                while (l < r)
                    (arr[l], arr[r]) = (arr[r--], arr[l++]);
            }
            List<int> res = new List<int>();
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] == i + 1) continue;
                for (int j = 1; j < i && arr[0] != i + 1; j++)
                {
                    if (arr[j] == i + 1)
                    {
                        flip(j);
                        res.Add(j + 1);
                    }
                }
                flip(i);
                res.Add(i + 1);
            }
            return res;
        }

    }



}
