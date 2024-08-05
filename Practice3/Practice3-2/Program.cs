using System;
using System.Collections.Generic;

namespace Practice3_2
{
	internal class Program
	{
		class club
		{
			private List<member> total_member = new List<member>();
		}
		class member
		{
			private string name;
			private string department;
			private string ID;
			private string level;
			private string title = "無";
		}

		static void print()
		{
			Console.WriteLine("新增社員資訊:     register			name	department	ID");
			Console.WriteLine("以特定屬性查詢:   search			name	tag		Want_search_string");
			Console.WriteLine("授予社員職位:	   entitle			name	department	ID		That_title");
			Console.WriteLine("所有成員列表:     check");
			Console.WriteLine("指令格式列表:     help");
			Console.WriteLine("離開此程式:       exit");
		}

		static bool show()
		{
			print();
			var method = Console.ReadLine();
			string[] array = method.Split(' ');
			switch (array[0]) {
				case "register":
					break;
				case "search":
					break;
				case "entitle":
					break;
				case "check":
					break;
				case "help":
					print();
					break;
				case "exit":
					return false;
				default:
					Console.WriteLine("			不存在這個功能，有疑慮請打help");
					break;
			}
			return true;
		}
		public static void Main(string[] args)
		{
			show();
		}
	}
}