using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class BBB
    {
        public static void Start()
        {
            // 模擬輸入數據
            string[] inputData = new string[]
            {
            "4",
            "YaoLin 87 82 Y N 0",
            "ChenRuiyi 88 78 N Y 1",
            "LiXin 92 88 N N 0",
            "ZhangQin 83 87 Y N 1"
            };

            // 調用方法處理獎學金分配
            var result = ProcessScholarships(inputData);

            // 輸出結果
            Console.WriteLine(result.TopStudentName);
            Console.WriteLine(result.TopStudentScholarship);
            Console.WriteLine(result.TotalScholarship);
        }


        // 方法：處理獎學金計算
        static ScholarshipResult ProcessScholarships(string[] inputData)
        {
            int n = int.Parse(inputData[0]);
            List<Student> students = new List<Student>();
            int totalScholarship = 0;

            // 讀取每個學生的資料
            for (int i = 1; i <= n; i++)
            {
                string[] input = inputData[i].Split();
                string name = input[0];
                int finalScore = int.Parse(input[1]);
                int classEval = int.Parse(input[2]);
                bool isLeader = input[3] == "Y";
                bool isNorth = input[4] == "Y";
                int papers = int.Parse(input[5]);

                Student student = new Student(name, finalScore, classEval, isLeader, isNorth, papers);
                students.Add(student);

                totalScholarship += student.Scholarship;
            }

            // 找出獎金最多的學生
            Student maxStudent = students[0];
            foreach (var student in students)
            {
                if (student.Scholarship > maxStudent.Scholarship)
                {
                    maxStudent = student;
                }
            }

            // 返回結果
            return new ScholarshipResult
            {
                TopStudentName = maxStudent.Name,
                TopStudentScholarship = maxStudent.Scholarship,
                TotalScholarship = totalScholarship
            };
        }

        // 定義學生類
        class Student
        {
            public string Name { get; }
            public int FinalScore { get; }
            public int ClassEval { get; }
            public bool IsLeader { get; }
            public bool IsNorth { get; }
            public int Papers { get; }
            public int Scholarship { get; }

            public Student(string name, int finalScore, int classEval, bool isLeader, bool isNorth, int papers)
            {
                Name = name;
                FinalScore = finalScore;
                ClassEval = classEval;
                IsLeader = isLeader;
                IsNorth = isNorth;
                Papers = papers;
                Scholarship = CalculateScholarship();
            }

            // 計算獎金
            private int CalculateScholarship()
            {
                int scholarship = 0;

                if (FinalScore > 80 && Papers >= 1) scholarship += 8000; // 院士獎學金
                if (FinalScore > 85 && ClassEval > 80) scholarship += 4000; // 校友獎學金
                if (FinalScore > 90) scholarship += 2000; // 成績優秀獎
                if (FinalScore > 85) scholarship += 1000; // 北部獎學金
                if (ClassEval > 80 && IsLeader) scholarship += 850; // 班級貢獻獎

                return scholarship;
            }
        }

        // 定義獎學金結果類
        class ScholarshipResult
        {
            public string TopStudentName { get; set; }
            public int TopStudentScholarship { get; set; }
            public int TotalScholarship { get; set; }
        }

    }



}
