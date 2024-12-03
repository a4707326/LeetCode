using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC118_Pascal_Triangle
    {
        public static void Start()
        {
            Console.WriteLine("LC118_Pascal_Triangle");

            int num = 5;


            var ans = Generate( num);



            ////IList<IList<string>> 
            foreach (var i in ans)
            {
                string s = "";
                foreach (var j in i)
                {
                    s += j.ToString();

                }
                Console.WriteLine(s);
            }


        }

        //Input: numRows = 5
        //Output: [[1],[1,1],[1,2,1],[1,3,3,1],[1,4,6,4,1]]
        //猜O(n*m),O(n*m)
        //答O(N^2),O(N^2)
        //演算法DP
        static IList<IList<int>> Generate(int numRows)
        {
            List<IList<int>> ans = new ();

            //先給一個list避免沒有上一個可以加
            if ( numRows > 0 ) 
            {
                ans.Add(new List<int> {1 });
            }

            //這裡i = 2表示要生成list的長度
            for (int i = 2; i <= numRows; i++)
            {
                var list = new List<int>();

                //將上一個list的左右相加
                for (int j = 0; j < i; j++)
                {
                    int left = 0;
                    int right = 0;
                    if (j > 0 )
                    {
                        left = ans[i - 2][j-1];
                    }
                    if (j < i-1)
                    {
                        right = ans[i - 2][j];
                    }

                    list.Add(left + right);
                }

                ans.Add(list);
            }
            return ans;
        }
    }



}
