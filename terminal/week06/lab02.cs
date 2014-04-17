using System;
class Lab02
{
	public static void PrintNum(int m, int n)
	{
		Console.WriteLine("출력 : ");
		int num = 0;
		for(int i = 0; i < m; i++)
		{
			num = i + 1;
			for(int j = 0; j < n; j++)
			{
				Console.Write("{0, -3}", num);
				num += m;
			}
			Console.WriteLine();
		}
	}

	public static void Main(string [] args)
	{
		Console.Write("입력 : ");
		string temp = Console.ReadLine();
		string [] str = temp.Split(' ');
		int m = Convert.ToInt32(str[0]);
		int n = Convert.ToInt32(str[1]);
		
		PrintNum(m, n);
	}
}

