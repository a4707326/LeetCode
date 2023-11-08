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
    internal class LC1310_XOR_Queries_of_a_Subarray
    {
        public static void Start()
        {
            Console.WriteLine("LC1310_XOR_Queries_of_a_Subarray");

            int[] arr = { 1, 3, 4, 8 };
            int[][] queries = new int[][]
            {
                new int[] {0, 1},
                new int[] {1, 2},
                new int[] {0, 3},
                new int[] {3, 3}
            };


            var ans = XorQueries2(arr, queries);


            foreach (int i in ans) 
            {
                Console.WriteLine(i.ToString());
            }


        }

        //Input: arr = [1,3,4,8], queries = [[0,1],[1,2],[0,3],[3,3]]
        //Output: [2,7,14,8]
        //猜O[n^2]
        //(暴力解)這個解決方案的時間複雜度是 O(Q * N)，其中 Q 是查詢數組的長度，N 是輸入數組 arr 的長度
        public static int[] XorQueries(int[] arr, int[][] queries)
        {
            List<int> ans = new List<int>();
            int left = 0;
            int right = 0;
            int xor = 0;

            for (int i = 0; i < queries.Length; i++)
            {
                left = queries[i][0];
                right = queries[i][1];
                xor = arr[left];

                for (int j = left +1 ; j <= right; j++)
                {
                    xor = xor ^ arr[j];
                }
                ans.Add(xor);
            }

            return ans.ToArray();
        }

        //Input: arr = [1,3,4,8], queries = [[0,1],[1,2],[0,3],[3,3]]
        //Output: [2,7,14,8]
        //O(N + Q)
        //使用prefixXor
        public static int[] XorQueries2(int[] arr, int[][] queries)
        {
            List<int> ans = new List<int>();

            int[] prefixXor = new int[arr.Length+1];
            prefixXor[0] = 0;

            //計算前綴
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine( prefixXor[i] +"^"+ arr[i] + "=" + (prefixXor[i] ^ arr[i]));
                prefixXor[i + 1] = prefixXor[i] ^ arr[i];
            }
            //prefixXor ={0,1,2,6,14}
            //0 = 0
            //0 ^ 1 = 1
            //1 ^ 3 = 2
            //2 ^ 4 = 6
            //6 ^ 8 = 14

            //查詢結果
            for (int i = 0; i < queries.Length; i++)
            {
                int left = queries[i][0];
                int right = queries[i][1]+1;// 注意這裡的右邊界需要 +1
                ans.Add(prefixXor[left] ^ prefixXor[right]);
            }
            //ans ={2,7,14,8}
            return ans.ToArray();


        }

        //0000 =0
        //0001 =1
        //XOR
        //0010 =1


        //0001 =1
        //0011 =3
        //XOR
        //0010 =2

        //0000 =0
        //0010 =2
        //XOR
        //0010 =2

        //0001 =1
        //0011 =3
        //XOR
        //0010 =2

        //0011 =3
        //0100 =4
        //XOR
        //0111 =7

        //0001 =1
        //1000 =8
        //XOR
        //1001 =9


    }


}
