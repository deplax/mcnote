using System;
class Lab03
{
	public static int [] StrSplit()
	{
		string msg = Console.ReadLine();
		string [] temp = msg.Split(' ');
		int [] arr  = new int [temp.Length];

		for(int i = 0; i < temp.Length; i++)
		{
			arr[i] = Convert.ToInt32(temp[i]);
		} 

		return arr;
	}

	public static int Readstrtoint()
	{
		string temp = Console.ReadLine();
		return Convert.ToInt32(temp);
	}

	public static void Arrprint( int [,] array, int num1, int num2)
	{
		for(int i = 0; i < num1; i++)
		{
				Console.Write("|");
			for(int j = 0; j < num2; j++)
			{
				Console.Write(" {0,-2}", array[i, j]);

			}

				Console.Write("|");
				Console.WriteLine();

		}
	}

	public static void Main(string [] args)
	{
		int num1 = 0;
		int num2 = 0;

		Console.Write("Input array row size : ");
		num1 = Readstrtoint();
		Console.Write("Input array colum size : ");
		num2 = Readstrtoint();

		int [,] array1 = new int[num1, num2];
		int [] arr1;

		Console.Write("Input {0} number (ex num1 num2 ...) : ", num1 * num2);
		arr1 = StrSplit();

		int arcnt = 0;
		//값을 받아야지요.
		for(int i = 0; i < num1; i++)
		{
			for(int j = 0; j < num2; j++)
			{
				array1[i, j] = arr1[arcnt];
				arcnt++;
			}
		}

		Arrprint(array1, num1, num2);


		//두번째꺼 입력

		int [,] array2 = new int[num1, num2];
		int [] arr2;

		Console.Write("Input {0} number (ex num1 num2 ...) : ", num1 * num2);
		arr2 = StrSplit();

		arcnt = 0;
		//값을 받아야지요.
		for(int i = 0; i < num1; i++)
		{
			for(int j = 0; j < num2; j++)
			{
				array2[i, j] = arr2[arcnt];
				arcnt++;
			}
		}

		Arrprint(array2, num1, num2);

		//더해야지요

		Console.WriteLine("Sum : ");

		int [,] array3 = new int[num1, num2];
		for(int i = 0; i < num1; i++)
		{
			for(int j = 0; j < num2; j++)
			{
				array3[i, j] = array1[i, j] + array2[i, j];
			}
		}
		Arrprint(array3, num1, num2);

	}
}

