using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC2974_Minimum_Number_Game
    {
        static bool isSame = true;
        public static void Start()
        {
            Console.WriteLine("LC2974_Minimum_Number_Game");

            int[] nums = new int[] { 5, 4, 2, 3 };

            var ans = NumberGame(nums);

            //Console.WriteLine(ans);
            //Console.WriteLine{ans.ToString());

            foreach (var val in ans)
            {
                Console.WriteLine($"{val.ToString()}");
            }



        }
        //Input: nums = [5,4,2,3]
        //Output: [3,2,5,4]

        public static int[] NumberGame(int[] nums)
        {

            List<int> list = new List<int>(nums);
            List<int> ansList = new();
            
            int bob = 0;
            int alice = 0;

            while (list.Count > 0) 
            {
                alice = list.Min(x => x);
                list.Remove(alice);
                bob = list.Min(x => x);
                list.Remove(bob);

                ansList.Add(bob);
                ansList.Add(alice);
     
            }

            return ansList.ToArray();
        }

    }


}
