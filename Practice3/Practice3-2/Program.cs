using System;
using System.Collections.Generic;

namespace Practice3_2 {

	// avoid inner class
	class club {

		public List<member> total_member = new List<member>();
	
		public void print_member() {
			foreach (var mem in total_member) {
				Console.WriteLine($"{mem.name}\t{mem.department}\t{mem.ID}\t\t{mem.level}\t\t{mem.title}");
			}
		}

		public void register(string name, string depmt, string id) {
			// use the following instead, with enumeration:
			var target = total_member.Find(m => m.name == name && m.department == depmt && m.ID == id);
			if (target == null) {
				total_member.Add(new member(name, depmt, id, member_level.newbie) /* only create new instance ONLY after a new instance is REALLY REQUIRED. */ );
				Console.WriteLine("歡迎新社員!");
				return;
			}
			switch (target.level) {
				case member_level.newbie:
					target.level = member_level.senior;
					Console.WriteLine("已晉升為資深成員");
					break;
				case member_level.senior:
					target.level = member_level.permanent;
					Console.WriteLine("已晉升為永久成員");
					break;
				case member_level.permanent:
					Console.WriteLine("已經是永久成員了喔");
					break;
				// default case should be unreachable
			}
		}

		public club filter(Predicate<member> cond) {
			var new_club = new club();
			new_club.total_member = total_member.FindAll(cond);
			return new_club;
		}

		public void entitle(string name, string depmt, string id, string new_title) {
			var target = total_member.Find(m => m.name == name && m.department == depmt && m.ID == id);
			if (target == null) {
				Console.WriteLine("			找不到這個人ㄟ");
				return;
			}
			if (array[4].Contains("社長")) {
				Console.WriteLine("			我們的社長只有阿明一人，你不要想篡位！");
				return;
			}
			target.title = new_title;
		}
	}

	// member level: use enum instead
	enum member_level {
		newbie, senior, permanent
	}

	// avoid inner class
	class member(string name, string dep, string id, string level, string titl = "無") {

		public string name = name;

		public string department = dep;

		public string ID = id;

		// use enum instead
		public member_level level = from_lvl_string(level);

		public string title = titl;

		public member_level from_lvl_string(string lvl) {
			switch (lvl) {
				case "盟新社員":
					return member_level.newbie;
				case "資深社員":
					return member_level.senior;
				case "永久社員":
					return member_level.permanent;
				default:
					throw new Exception();
			}
		}
	}

	internal class Program {

		static void print() {
			// use BRACKETS
			Console.WriteLine("- register <name> <department> <ID>\n\t\t新增社員資訊");
			Console.WriteLine("- search <\"name\"|\"department\"|\"id\"|\"level\"|\"title\"> <query>\n\t\t以特定屬性查詢");
			Console.WriteLine("- entitle <name>	<department> <ID> <new_title>\n\t\t授予社員職位");
			Console.WriteLine("所有成員列表:     check");
			Console.WriteLine("指令格式列表:     help");
			Console.WriteLine("離開此程式:       exit");
		}

		private static club club_1 = new club();
		static bool show()
		{
			var method = Console.ReadLine();
			string[] array = method.Split(' ');
			switch (array[0].ToLower() /* recommended */) {
				case "register":
					// bad!!! these create new members EVERY iteration
					/*
					member member_1 = new member(array[1], array[2], array[3], "盟新社員");
					member member_2 = new member(array[1], array[2], array[3], "資深社員");
					member member_3 = new member(array[1], array[2], array[3], "永久社員");
	 				*/
					// bad!!! creates a new object instance only to compared against
					/*
					if (club_1.total_member.Contains(member_3)) {
						Console.WriteLine("已經是永久成員了喔");
					}
					else if (club_1.total_member.Exists(member => member == member_2) /* this is same as using .Contains(member_2) ) {
						club_1.total_member.Find(member => member == member_2).level = "永久社員";
						Console.WriteLine("已晉升為永久成員");
					}
					else if (club_1.total_member.Exists(member => member == member_1) /* this is same as using .Contains(member_1) ) {
						club_1.total_member.Find(member => member == member_1).level = "資深社員";
						Console.WriteLine("已晉升為資深成員");
					}
	 				*/
					// bad!!! not every iteration uses the newly create instances "member_2, member_1"
					/*
					else {
						club_1.total_member.Add(member_1);
						Console.WriteLine("歡迎新社員!");
					}
	 				*/
					// call member function:
					club_1.register(array[1], array[2], array[3]);
					break;
				case "search":
					club targets;
					switch (array[1].ToLower()) {
						case "name":
							// use member function; see def above:
							targets = club_1.filter(member => member.name == array[2]);
							if (targets.Count == 0) {
								Console.WriteLine("找不到這個人ㄟ");
								return true;
							}
							break;
						case "department":
							targets = club_1.filter(member => member.department == array[2]);
							if (targets.Count == 0) {
								Console.WriteLine("找不到這個系的人ㄟ");
								return true;
							}
							break;
						case "id": // only lower case is possible after .ToLower()
							targets = club_1.filter(member => member.ID == array[2]);
							if (targets.Count == 0) {
								Console.WriteLine("找不到這個學號的人ㄟ");
								return true;
							}
							break;
						case "level":
							targets = club_1.filter(member => member.level == Practice3_2.member.from_lvl_string(array[2]));
							if (targets.Count == 0) {
								Console.WriteLine("找不到這個等級的人ㄟ");
								return true;
							}
							break;
						case "title":
							targets = club_1.filter(member => member.title == array[2]);
							if (targets.Count == 0) {
								Console.WriteLine("找不到這個職務的人ㄟ");
								return true;
							}
							break;
						// default case is not handled properly
					}
					break;
				case "entitle":
					/*
					foreach (var ber in club_1.total_member) {
						// branches can be rearrange to be more readable
						if (ber.name == array[1] && ber.ID == array[3] && ber.department == array[2]) {
							if (!array[4].Contains("社長")) // precedence of boolean not operator is lower than member access operator; extra parentheses are redundant.
								ber.title = array[4];
							else // else is enough to cover the original first elseif branch
								Console.WriteLine("			我們的社長只有阿明一人，你不要想篡位！"); // what's with the blanks at the begining??
						} else if (ber.name != array[1] || ber.ID != array[3] || ber.department != array[2]) {
							// original three not equal operator joined with boolean and operator is incorrect; it is only true if ALL THREE field are not equal.
							Console.WriteLine("			找不到這個人ㄟ");
							break;
						}
					}
					*/
					club_1.entitle(array[1], array[2], array[3], array[4]);
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
