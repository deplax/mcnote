using System;
class Lab01
{
	public static void Main(string [] args)
	{
		Console.Write("입력 : ");
		string temp = Console.ReadLine();
		string [] str = temp.Split(' ');
		int num1 = Convert.ToInt32(str[0]);
		int num2 = Convert.ToInt32(str[1]);

		int [] day = new int [] {31, 28, 31, 30, 31, 30, 31, 31, 30 ,31, 30, 31};

		Console.Write("출력 : ");

		int all = 0;

		for(int i = 0; i < num1 - 1; i++)
		{
			all += day[i];
		}

		all += num2;

		int op = 0;
		op = all % 7;

		switch(op)
		{
			case 0:
				Console.WriteLine("일요일");
				break;
			case 1:
				Console.WriteLine("월요일");
				break;
			case 2:
				Console.WriteLine("화요일");
				break;
			case 3:
				Console.WriteLine("수요일");
				break;
			case 4:
				Console.WriteLine("목요일");
				break;
			case 5:
				Console.WriteLine("금요일");
				break;
			case 6:
				Console.WriteLine("토요일");
				break;
		}
	}
}

	
