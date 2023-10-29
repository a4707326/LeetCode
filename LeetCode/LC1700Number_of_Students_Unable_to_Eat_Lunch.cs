using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC1700Number_of_Students_Unable_to_Eat_Lunch
    {



        public static void Start()
        {
            Console.WriteLine("LC1700Number_of_Students_Unable_to_Eat_Lunch");

            int[] students = { 1,1,0,0 };
            int[] sandwiches = { 0, 1, 0, 1 };

            var ans = CountStudents(students, sandwiches);

            Console.WriteLine(ans);

            //foreach (int i in ans) 
            //{
            //    Console.WriteLine(i.ToString());
            //}


        }

        //Input: students = [1,1,0,0], sandwiches = [0,1,0,1]
        //Output: 0 
        public static int CountStudents(int[] students, int[] sandwiches)
        {
            List<int> studentsList = students.ToList();
            List<int> sandwichesList = sandwiches.ToList();

            int failCount = 0;
            while (failCount < students.Length && studentsList.Count > 0) 
            {
                if (studentsList[0] == sandwichesList[0])
                {
                    failCount = 0;
                    studentsList.RemoveAt(0);
                    sandwichesList.RemoveAt(0);
                }
                else
                {
                    studentsList.Add(studentsList[0]);
                    studentsList.RemoveAt(0);
                    failCount++;
                }

            }
            return studentsList.Count;
        }







    }


}
