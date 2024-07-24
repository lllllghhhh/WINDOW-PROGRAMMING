using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice2_1
{
    internal class Program
    {
        class student
        {
            public List<transcript> grade_report = new List<transcript>();

            public void print_grade_report()
            {
                Console.WriteLine("我的成績單:\n編號\t科目代碼\t分數\t等第\t學分數");
                foreach (var trans in grade_report) {
                    Console.WriteLine(trans.index + "\t" + trans.class_code + "\t" + trans.grade + "\t" + trans.grade + "\t" + trans.credit);
                }
            }
        }
        struct transcript
        {
            public int index;
            public string class_code;
            public int grade;
            public string level;
            public int credit;
            
        }

        private static List<transcript> transcripts_lists = new List<transcript>
        {
            new transcript { index = 0, class_code = "0", grade = 0, level = "0", credit = 0 }
        };

        private static student student_1 = new student();
        static bool show()
            {
                Console.WriteLine("1. 新增科目(create)\n2. 刪除科目(delete)\n3. 更新科目(update)\n4. 列印成績單(print)\n5. 退出選單(exit)");
                Console.Write("輸入要執行的指令操作:");
                if (Console.ReadLine().StartsWith("create")) {
                    string[] create_array = Console.ReadLine().Split(' ');
                    foreach (var VARIABLE in create_array) {
                        Console.WriteLine(VARIABLE);
                    }
                    transcript transcript_1 = new transcript { index = 0, class_code = "0", grade = 0, level = "0", credit = 0 };
                    transcript_1.class_code = create_array[1];
                    transcript_1.grade = int.Parse(create_array[2]);
                    transcript_1.credit = int.Parse(create_array[3]);
                    student_1.grade_report.Add(transcript_1);
                    student_1.print_grade_report();
                    
                }
                else if (Console.ReadLine().StartsWith("delete")) {
                    string[] delete_array = Console.ReadLine().Split(' ');
                    foreach (var item in student_1.grade_report ) {
                        if (item.class_code == delete_array[1]) {
                            student_1.grade_report.Remove(item);
                        }
                        else {
                            Console.WriteLine("error");
                            break;
                        }
                            
                    }
                }
                else if(Console.ReadLine().StartsWith("print"))
                    student_1.print_grade_report();
                return true;
            }
        public static void Main(string[] args)
        {
            while (show())
                ;
        }
    }
}