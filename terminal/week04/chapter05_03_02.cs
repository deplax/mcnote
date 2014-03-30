using System;
class chapter05_03_02
{
	public static void Main(string [] args)
	{
		int countstar = 5;
		int countline = 5;

		do
		{
			do
			{
				Console.Write("* ");
				countstar--;
			}while(countstar > 0);
			
			Console.WriteLine();
			countline--;
			countstar = countline;
		}while(countline > 0);
	}
}
