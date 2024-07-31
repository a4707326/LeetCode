using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC509_Fibonacci_Number
    {
        public static void Start()
        {
            Console.WriteLine("LC509_Fibonacci_Number");

            int num = 5;

            var ans = Fib( num);


            Console.WriteLine(ans);

        }

        //Input: n = 2
        //Output: 1
        //Input: n = 5
        //Output: 5
        static int Fib(int n)
        {
            if (n <=  1) { return n; }
            return Fib(n-1)+ Fib(n-2);
        }
    }



}
