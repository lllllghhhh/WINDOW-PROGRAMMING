using System;
using System.Collections.Generic;

namespace Practice3_2
{
	internal class Program
	{
		class club
		{
			public List<member> total_member = new List<member>();
		}
		class member(string name, string dep, string id, string level, string titl = "無")
		{
			private string name = name;
			private string department = dep;
			private string ID = id;
			public string level = level;
			private string title = titl;
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

		private static club club_1 = new club();
		static bool show()
		{
			print();
			var method = Console.ReadLine();
			string[] array = method.Split('	');
			switch (array[0]) {
				case "register":
					member member_1 = new member(array[1], array[2], array[3], "盟新社員");
					member member_2 = new member(array[1], array[2], array[3], "資深社員");
					if (club_1.total_member.Contains(member_2))
						club_1.total_member.Find(member => member.level == "資深社員" ).level = "永久社員";
					else if(club_1.total_member.Contains(member_1))
						club_1.total_member.Find(member => member.level == "盟新社員" ).level = "資深社員";
					else 
						club_1.total_member.Add(member_1);
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