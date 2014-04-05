using System;
class Lab01
{
	public static void Main(string [] args)
	{
		string temp;
		int line;
		int num1 = 1;
		int num2;

		Console.Write("press number : ");
		temp = Console.ReadLine();
		line = Convert.ToInt32(temp);

		num2 = line;

		for(int i = 0; i < line; i++)
		{
			for(int k = 0; k < num2 - 1; k++)
			{
				Console.Write("  ");
			}

			for(int j = 0; j < num1; j++)
			{
				Console.Write(" *");
			}
			Console.WriteLine();
			num1 += 2;
			num2--;
		}
	}
}

