using System;
class Labex02
{
	public static void Main(string [] args)
	{

		Console.Write("Input number : ");
		string temp = Console.ReadLine();
		int n = Convert.ToInt32(temp);

		for(int i = 0; i < n + 1; i++)
		{	
			for(int j = 0; j < i; j++)
			{
				Console.Write("#");
			}
			for(int j = 0; j < n - i; j++)
			{
				Console.Write("*");
			}
			Console.WriteLine();
		}
	}
}
			
			
			
		
