using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC119_Pascal_Triangle_II
    {
        public static void Start()
        {
            Console.WriteLine("LC119_Pascal_Triangle_II");


            int num = 1;


            var ans = GetRow( num);


            foreach (var i in ans)
            {
                Console.WriteLine(i.ToString());
            }

        }

        //Input: rowIndex = 3
        //Output: [1,3,3,1]
        //猜O(1),O(1)
        //答O(1),O(1)
        //演算法Greedy
        static IList<int> GetRow(int rowIndex)
        {

            List<IList<int>> ans = new();

            //先給一個list避免沒有上一個可以加

            ans.Add(new List<int> { 1 });

            rowIndex += 1;
            //這裡i = 2表示要生成list的長度
            for (int i = 2; i <= rowIndex; i++)
            {
                var list = new List<int>();

                //將上一個list的左右相加
                for (int j = 0; j < i; j++)
                {
                    int left = 0;
                    int right = 0;
                    if (j > 0)
                    {
                        left = ans[i - 2][j - 1];
                    }
                    if (j < i - 1)
                    {
                        right = ans[i - 2][j];
                    }

                    list.Add(left + right);
                }

                ans.Add(list);
            }
            return ans[ans.Count - 1];
        }
    }



}
