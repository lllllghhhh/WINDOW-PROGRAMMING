using System;
using System.Collections.Generic;

namespace Practice3_2
{
	internal class Program
	{
		class club
		{
			public List<member> total_member = new List<member>();

			public void print_member()
			{
				foreach (var mem in total_member) {
					Console.WriteLine("{0}\t{1}\t{2}\t\t{3}\t\t{4}",mem.name, mem.department, mem.ID, mem.level, mem.title);
				}
			}
		}
		class member(string name, string dep, string id, string level, string titl = "無")
		{
			public string name = name;
			public string department = dep;
			public string ID = id;
			public string level = level;
			public string title = titl;
		}

		static void print()
		{
			Console.WriteLine("新增社員資訊:     register			name	department	ID");
			Console.WriteLine("以特定屬性查詢:   search			name	tag		Want_search_string");
			Console.WriteLine("授予社員職位:	  entitle			name	department	ID		That_title");
			Console.WriteLine("所有成員列表:     check");
			Console.WriteLine("指令格式列表:     help");
			Console.WriteLine("離開此程式:       exit");
		}

		private static club club_1 = new club();
		static bool show()
		{
			var method = Console.ReadLine();
			string[] array = method.Split(' ');
			switch (array[0]) {
				case "register":
					member member_1 = new member(array[1], array[2], array[3], "盟新社員");
					member member_2 = new member(array[1], array[2], array[3], "資深社員");
					member member_3 = new member(array[1], array[2], array[3], "永久社員");
					if (club_1.total_member.Contains(member_3)) {
						Console.WriteLine("已經是永久成員了喔");
					}
					else if (club_1.total_member.Exists(member => member == member_2)) {
						club_1.total_member.Find(member => member == member_2).level = "永久社員";
						Console.WriteLine("已晉升為永久成員");
					}
					else if (club_1.total_member.Exists(member => member == member_1)) {
						club_1.total_member.Find(member => member == member_1).level = "資深社員";
						Console.WriteLine("已晉升為資深成員");
					}
					else {
						club_1.total_member.Add(member_1);
						Console.WriteLine("歡迎新社員!");
					}

					break;
				case "search":
					switch (array[1]) {
						case "name":
							if (club_1.total_member.Exists(member => member.name == array[2])) {
								foreach (var m in club_1.total_member) {
									if(m.name == array[2])
										Console.WriteLine("{0}\t{1}\t{2}\t\t{3}\t\t{4}",m.name, m.department, m.ID, m.level, m.title);
								}
							}
							else {
								Console.WriteLine("找不到這個人ㄟ");
							}
							break;
						case "department":
							if (club_1.total_member.Exists(member => member.department == array[2])) {
								foreach (var m in club_1.total_member) {
									if(m.department == array[2])
										Console.WriteLine("{0}\t{1}\t{2}\t\t{3}\t\t{4}",m.name, m.department, m.ID, m.level, m.title);
								}
							}
							else {
								Console.WriteLine("找不到這個系的人ㄟ");
							}
							break;
						case "ID":
							if (club_1.total_member.Exists(member => member.ID == array[2])) {
								foreach (var m in club_1.total_member) {
									if(m.ID == array[2])
										Console.WriteLine("{0}\t{1}\t{2}\t\t{3}\t\t{4}",m.name, m.department, m.ID, m.level, m.title);
								}
							}
							else {
								Console.WriteLine("找不到這個學號的人ㄟ");
							}
							break;
						case "level":
							if (club_1.total_member.Exists(member => member.level == array[2])) {
								foreach (var m in club_1.total_member) {
									if(m.level == array[2])
										Console.WriteLine("{0}\t{1}\t{2}\t\t{3}\t\t{4}",m.name, m.department, m.ID, m.level, m.title);
								}
							}
							else {
								Console.WriteLine("找不到這個等級的人ㄟ");
							}
							break;
						case "title":
							if (club_1.total_member.Exists(member => member.title == array[2])) {
								foreach (var m in club_1.total_member) {
									if(m.title == array[2])
										Console.WriteLine("{0}\t{1}\t{2}\t\t{3}\t\t{4}",m.name, m.department, m.ID, m.level, m.title);
								}
							}
							else {
								Console.WriteLine("找不到這個職務的人ㄟ");
							}
							break;
					}
					break;
				case "entitle":
					foreach (var ber in club_1.total_member) {
						if (ber.name == array[1] && ber.ID == array[3] && ber.department == array[2] &&
						    !(array[4].Contains("社長")))
							ber.title = array[4];
						else if(ber.name == array[1] && ber.ID == array[3] && ber.department == array[2] &&
						        array[4].Contains("社長"))
							Console.WriteLine("			我們的社長只有阿明一人，你不要想篡位！");
						else if (ber.name != array[1] && ber.ID != array[3] && ber.department != array[2]) {
							Console.WriteLine("			找不到這個人ㄟ");
							break;
						}
					}
					break;
				case "check":
					club_1.print_member();
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
			print();
			while (show())	
			 ;
		}
	}
}