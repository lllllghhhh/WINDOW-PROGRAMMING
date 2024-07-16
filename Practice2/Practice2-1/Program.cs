using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice2_1
{
    internal class Program
    {
        struct student
        {
            public transcript[] report;
            public static List<transcript> grade_report = new List<transcript>();
        }
        struct transcript
        {
            public int index;
            public string class_code;
            public int grade;
            public string level;
            public int cedit;
            
        }
        public static void Main(string[] args)
        {
            int number = 0;
            student student_1;
            void show()
            {
                Console.WriteLine("1. 新增科目(create)\n2. 刪除科目(delete)\n3. 更新科目(update)\n4. 列印成績單(print)\n5. 退出選單(exit)");
                Console.Write("輸入要執行的指令操作:");
                var method = Console.ReadLine();
                if (method.StartsWith("create")) {
                    string[] create_array = method.Split(' ');
                    student_1.report[number].class_code = create_array[1];
                    student_1.report[number].grade = int.Parse(create_array[2]);
                    student_1.report[number].cedit = int.Parse(create_array[3]);
                    student_1.report[number].index = number;
                    number++;
                }
                else if (method.StartsWith("delete")) {
                    string[] delete_array = method.Split(' ');
                    foreach (var item in student_1.report ) {
                        if (item.class_code == delete_array[1]) {
                            for(int i = item.index; i < number;i++  )
                                student_1.report[item.index] = student_1.report[item.index+1];
                        }
                        else {
                            Console.WriteLine("error");
                            show();
                            break;
                        }
                            
                    }
                    
                    
                    number--;
                }
                /*switch (true) {
                    case create:
                        
                        break;
                    case "delete":
                        break;
                    case "update":
                        break;
                    case "print":
                        Console.WriteLine("我的成績單:\n編號    科目代碼    分數    等第    學分數" );
                        
                        break;
                    case "exit":
                        break;
                }*/
            }
            show();
        }
    }
}