using System;
class chapter05_01
{
	public static void Main(string [] args)
	{
		for(int i = 0; i < 5; i++)
		{
			for(int j = 0; j < i + 1; j++)
				{
					Console.Write("* ");
				}
		Console.WriteLine();
		}
	}
}
