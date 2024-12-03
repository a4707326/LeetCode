using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class WC414_Q1_Convert_Date_to_Binary
    {
        public static void Start()
        {
            Console.WriteLine("WC414_Q1_Convert_Date_to_Binary");



            string str = "2080-02-29";


            var ans = ConvertDateToBinary(str);




            Console.WriteLine(ans);

        }

        //Input: date = "2080-02-29"
        //Output: "100000100000-10-11101"

        static string ConvertDateToBinary(string date)
        {

            string yy = Convert.ToString(int.Parse(date.Split("-")[0]),2);
            string mm = Convert.ToString(int.Parse(date.Split("-")[1]), 2);
            string dd = Convert.ToString(int.Parse(date.Split("-")[2]), 2);
            return yy +"-" + mm + "-" +dd;
        }
    }



}
