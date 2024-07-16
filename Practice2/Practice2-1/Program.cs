using System;
using System.Collections.Generic;

namespace Practice2_1
{
    internal class Program
    {
        struct student
        {
            private static List<transcript> grade_report = new List<transcript>();
        }
        struct transcript
        {
            private string class_code;
            private int grade;
            private string level;
            private int cedit;
            
        }
        public static void Main(string[] args)
        {
            void show()
            {
                Console.WriteLine("1. 新增科目(create)\n2. 刪除科目(delete)\n3. 更新科目(update)\n4. 列印成績單(print)\n5. 退出選單(exit)");
                Console.Write("輸入要執行的指令操作:");
                var method = Console.ReadLine();
                switch (method) {
                    case "create":
                        break;
                    case "delete":
                        break;
                    case "update":
                        break;
                    case "print":
                        
                        break;
                    case "exit":
                        break;
                }
            }
            show();
        }
    }
}