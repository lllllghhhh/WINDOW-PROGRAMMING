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
                int i = 0;
                foreach (var trans in grade_report) {
                    Console.WriteLine(++i + "\t" + trans.class_code + "\t\t" + trans.grade + "\t" + trans.grade + "\t" + trans.credit);
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
                var method = Console.ReadLine();
                if (method.StartsWith("create")) {
                    string[] create_array = method.Split(' ');
                    transcript transcript_1 = new transcript { index = 0, class_code = "0", grade = 0, level = "0", credit = 0 };
                    transcript_1.class_code = create_array[1];
                    transcript_1.grade = int.Parse(create_array[2]);
                    transcript_1.credit = int.Parse(create_array[3]);
                    student_1.grade_report.Add(transcript_1);
                    student_1.print_grade_report();
                    
                }
                else if (method.StartsWith("delete")) {
                    string[] delete_array = method.Split(' ');
                    var itemToRemove = student_1.grade_report.Find(item => item.class_code == delete_array[1]);
                    if (itemToRemove.class_code != null)  
                    {
                        student_1.grade_report.Remove(itemToRemove);
                        student_1.print_grade_report();
                    }
                    else {
                        Console.WriteLine("error");
                    }
                }
                else if (method.StartsWith("update")) {
                    string[] update_array = method.Split(' ');
                    var update_item = student_1.grade_report.Find(item => item.class_code == update_array[1]);
                    if (update_item.class_code != null)  
                    {
                        student_1.grade_report.Remove(update_item);
                        transcript transcript_1 = new transcript { index = 0, class_code = "0", grade = 0, level = "0", credit = 0 };
                        transcript_1.class_code = update_array[1];
                        transcript_1.grade = int.Parse(update_array[2]);
                        transcript_1.credit = int.Parse(update_array[3]);
                        student_1.grade_report.Insert(update_item.index,transcript_1);
                        student_1.print_grade_report();
                    }
                    else {
                        Console.WriteLine("error");
                    }
                }
                else if(method.StartsWith("print"))
                    student_1.print_grade_report();
                else if (method == "exit")
                    return false;
                else 
                    Console.WriteLine("error");
                
                return true;
            }
        public static void Main(string[] args)
        {
            while (show())
                ;
        }
    }
}