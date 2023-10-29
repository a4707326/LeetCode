using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC1337_The_K_Weakest_Rows_in_a_Matrix
    {
        public static void Start()
        {
            Console.WriteLine("LC1337_The_K_Weakest_Rows_in_a_Matrix");

            int[][] mat = new int[][] {
                new int[] {1, 1, 0, 0, 0},
                new int[] {1, 1, 1, 1, 0},
                new int[] {1, 0, 0, 0, 0},
                new int[] {1, 1, 0, 0, 0},
                new int[] {1, 1, 1, 1, 1}
            };

            var ans = KWeakestRows(mat,3);


            foreach (int i in ans) 
            {
                Console.WriteLine(i.ToString());
            }


        }
        //Input: mat = 
        //[[1,1,0,0,0],
        // [1,1,1,1,0],
        // [1,0,0,0,0],
        // [1,1,0,0,0],
        // [1,1,1,1,1]], 
        //k = 3
        //Output: [2,0,3]
        //Explanation: 
        //The number of soldiers in each row is: 
        //- Row 0: 2 
        //- Row 1: 4 
        //- Row 2: 1 
        //- Row 3: 2 
        //- Row 4: 5 
        //The rows ordered from weakest to strongest are[2, 0, 3, 1, 4].
        public static int[] KWeakestRows(int[][] mat, int k)
        {
            Dictionary<int,int> dict = new Dictionary<int,int>();

            for (int i = 0; i < mat.Length; i++)
            {
                int force = Array.IndexOf(mat[i], 0);
                if (force == -1) force = mat[i].Length;
                dict.Add(i, force);
            }

            return dict.OrderBy(x => x.Value).Select(x => x.Key).Take(k).ToArray();
        }







    }


}
