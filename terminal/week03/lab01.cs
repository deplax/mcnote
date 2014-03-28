using System;
namespace next
{
	class lab01
	{
		public static void Main(string [] args)
		{
			string name1 = "gireen";
			int kor1 = 80;
			int math1 = 89;

			string name2 = "goyangii";
			int kor2 = 90;
			int math2 = 60;

			createline();
			Console.WriteLine("|{0, -9}|{1, -9}|{2, -9}|{3, -9}|", "name", "kor", "math", "AVG");
			createline();
			Console.WriteLine("|{0, -9}|{1, -9}|{2, -9}|{3, -9}|", name1, kor1, math1, (double)(kor1 + math1) / 2);
			Console.WriteLine("|{0, -9}|{1, -9}|{2, -9}|{3, -9}|", name2, kor2, math2, (double)(kor2 + math2) / 2);
			Console.WriteLine("|{0, -9}|{1, -9}|{2, -9}|{3, -9}|", "AVG", (kor1 + kor2) / 2, (math1 + math2) / 2, (double)(kor1 + kor2 + math1 + math2) / 4); 
			createline();
		}

		static void createline()
		{
			const int TableWidth = 41;
			int i = 0;	
			while ( i < TableWidth)
			{
				Console.Write("-");
				i++;
			}
			Console.WriteLine();		//여기까지 라인그렸고..
		}
	}
}

