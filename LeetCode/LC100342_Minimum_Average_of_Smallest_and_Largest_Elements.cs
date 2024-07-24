using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC100342_Minimum_Average_of_Smallest_and_Largest_Elements
    {
        static bool isSame = true;
        public static void Start()
        {
            Console.WriteLine("LC100342_Minimum_Average_of_Smallest_and_Largest_Elements");

            int[] ints = new int[] { 7, 8, 3, 4, 15, 13, 4, 1 };




            var ans = MinimumAverage(ints);

            Console.WriteLine(ans);
            //Console.WriteLine{ans.ToString());

            //foreach ( var val in valList) 
            //{
            //    //Console.WriteLine($"{val.ToString()}");
            //}



        }
        //1, 9, 8, 3, 10, 5
        // 9, 8, 3,  5 
        

        //1, 9, 8, 3, 10, 5
        //1, 9, 8, 3, 10, 5

        //[7,8,3,4,15,13,4,1]
        //[7,8,3,4,13,4]
        //[7,8,,4,,4]
        //[7,,,,,4]
        //[7,8,3,4,15,13,4,1]
        //[7,8,3,4,15,13,4,1]

        //WC
        static double MinimumAverage(int[] nums)
        {
            List<int> list = new List<int>(nums);
            List<double> avg = new List<double>();
            while (list.Count > 0) 
            {
                avg.Add((double)(list.Max() + list.Min()) /2);
                list.Remove(list.Max());
                list.Remove(list.Min());
            }

            return  avg.Min();
        }



    }


}
