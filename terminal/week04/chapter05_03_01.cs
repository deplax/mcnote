using System;
class chapter05_03_01
{
	public static void Main(string [] args)
	{
		int countstar = 5;
		int countline = 0;

		while(countline < 5)
		{
			countline++;
			while(5 - countstar >= 0)
			{
				countstar++;
				Console.Write("* ");
			}
			Console.WriteLine();
			countstar = 5 - countline;
		}
			
	}
}
