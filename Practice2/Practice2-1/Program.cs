using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Practice2_1
{
    internal class Program
    {
        class student {

            public Dictionary<string, entry> grades = new Dictionary<string, entry>();
            
            public void print_grade_report()
            {
                Console.WriteLine("我的成績單:\n編號 科目代碼\t分數\t等第\t學分數");
                var sorted_grades = grades.OrderByDescending(entry => entry.Value.grade).Select((entry, index) => new { Index = index + 1, Entry = entry });
                uint i = 0;
                foreach (var trans in sorted_grades) {
                    Console.WriteLine("{0,4}  {1,-11}{2,-8}{3,-8} {4}",
                        ++i, trans.Entry.Key, trans.Entry.Value.grade, grade_to_level(trans.Entry.Value.grade), trans.Entry.Value.credit);
                }
            }

            public string export() {
                string result = "";
                foreach (var trans in grades)
                    result += string.Format($"create {trans.Key} {trans.Value.grade} {trans.Value.credit}\n");
                return result;
            }
        }


        static string grade_to_level(uint grade)
        {
            if (grade >= 90)
                return "A+";
            if (grade >= 85)
                return "A";
            if (grade >= 80)
                return "A-";
            if (grade >= 77)
                return "B+";
            if (grade >= 73)
                return "B";
            if (grade >= 70)
                return "B-";
            if (grade >= 67)
                return "C+";
            if (grade >= 63)
                return "C";
            if (grade >= 60)
                return "C-";
            return "F";
        }

        class entry {

            public ushort grade;
            public ushort credit;

            public entry(string grade, string credit) {
                try {
                    var __grade = ushort.Parse(grade);
                    if (__grade > 100)
                        throw new ArgumentOutOfRangeException(nameof(grade), "必須大於0");
                    this.grade = __grade;
                }
                catch (FormatException) {
                    throw new ArgumentException("必須為數字", nameof(grade));
                }
                if (!ushort.TryParse(credit, out this.credit))
                    throw new ArgumentOutOfRangeException();
            }
        }
        
        private static student student_1 = new student();

        static bool show() {
            Console.WriteLine("1. 新增科目(create)\n2. 刪除科目(delete)\n3. 更新科目(update)\n4. 列印成績單(print)\n5. 退出選單(exit)\n6. export");
            Console.Write("輸入要執行的指令操作:");
            var method = Console.ReadLine();
            string[] array = method.Split(' ');
            switch (array[0]) {
                case "create":
                    if (array.Length < 4) {
                        Console.WriteLine("error");
                        break;
                    }
                    student_1.grades.Add(array[1], new entry(array[2], array[3]));
                    student_1.print_grade_report();
                    break;
                case "delete":
                    if (student_1.grades.Remove(array[1]))
                        student_1.print_grade_report();
                    else
                        Console.WriteLine("error");
                    break;
                case "update":
                    if (student_1.grades.ContainsKey(array[1])) {
                        var update_item = student_1.grades[array[1]];
                        update_item.grade = ushort.Parse(array[2]);
                        update_item.credit = ushort.Parse(array[3]);
                        student_1.print_grade_report();
                    }
                    else
                        Console.WriteLine("error");
                    break;
                case "print":
                    student_1.print_grade_report();
                    break;
                case "exit":
                    return false;
                case "export":
                    Console.WriteLine(student_1.export());
                    break;
                default:
                    Console.WriteLine("error: {0}", array[0]);
                    break;
            }
            return true;
        }

        public static void Main(string[] args)
        {
            while (show())
                ;
        }
    }
}