using System;
namespace next
{
	class lab04
	{
		public static void Main(string [] args)
		{
			int first, end, step;
			string temp;
			int sum = 0;

			Console.Write("press start number : ");
			temp = Console.ReadLine();
			first = Convert.ToInt32(temp);
			Console.Write("press finish number : ");
			temp = Console.ReadLine();
			end = Convert.ToInt32(temp);
			Console.Write("press step number : ");
			temp = Console.ReadLine();
			step = Convert.ToInt32(temp);


			Console.WriteLine("numbers");
			for(int i = first; i <= end; i += step)
			{
				Console.WriteLine(i);
				sum += i;
			}

			Console.WriteLine("sum = {0}", sum);
		}
	}
}


