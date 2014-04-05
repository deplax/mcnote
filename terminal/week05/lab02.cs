using System;
class Lab02
{
	public static void Main(string [] args)
	{
		


		string temp;
		int num1 = 0;
		int num2 = 0;
		int h, w;


		Console.Write("Height : ");
		temp = Console.ReadLine();
		h = Convert.ToInt32(temp);

		Console.Write("Width : ");
		temp = Console.ReadLine();
		w = Convert.ToInt32(temp);

		for(int i = 0; i < h; i++)
		{
			
			for(int j = 0; j < w; j++)
			{
				Console.Write("{0}{1} ", num1, num2);
				num2++;
			}
			
			num1++;
			num2 = 0;
			Console.WriteLine();
		}
	}
}

