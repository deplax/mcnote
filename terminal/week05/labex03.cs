using System;
class Labex03
{
	public static void Main(string [] args)
	{
		Console.Write("배열 크기를 입력해주세요 : ");
		string temp = Console.ReadLine();
		int n = Convert.ToInt32(temp);

		string [, ] arr = new string [n, n];
		
		bool flagq = true;
		bool flagp = false;

		while(flagq)
		{
			for(int i = 0; i < n; i++)
			{
				for(int j = 0; j < n; j++)
				{
					if(flagp == false)
					{
						Console.Write("* ");
						arr[i, j] = "* ";
					}
					else
						Console.Write(arr[i, j]);
				}
				Console.WriteLine();
			}
			
			flagp = true;
			Console.Write("지울 위치를 입력해주세요 : ");
			temp = Console.ReadLine();
			string [] nn = temp.Split(' ');
			int num1 = Convert.ToInt32(nn[0]);
			int num2 = Convert.ToInt32(nn[1]);

			if(num1 < 0 || num2 < 0)
			{
				flagq = false;
				Console.WriteLine();
				Console.WriteLine("End");
			}
			else if(arr[num1, num2] == "  ")
				Console.WriteLine("이미 지웠던 곳입니다!");
			else
			{
				arr[num1, num2] = "  ";
				arr[num2, num1] = "  ";
			}	
		}
	}
}
		
		

