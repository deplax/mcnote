using System;
class chapter05_02
{
	public static void Main(string [] args)
	{
		for(int i = 0; i < 5; i++)
		{
			for(int j = 5; j > i; j--)
				{
					Console.Write("* ");
				}
		Console.WriteLine();
		}
	}
}
