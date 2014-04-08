using System;
class Labex01
{
	public static void Main(string[] args)
	{
		Console.Write("Input number M * N(M N) : ");
		string temp = Console.ReadLine();
		string [] num = temp.Split(' ');
		int m = Convert.ToInt32(num[0]);
		int n = Convert.ToInt32(num[1]);
		int k;

		for(int i = 0; i < m; i++)
		{
			k = i + 1;
			for(int j = 0; j < n; j++)
			{
				Console.Write("{0, -3}", k);
				k = k + (i + 1);
			}
			Console.WriteLine();
		}
	}
}
