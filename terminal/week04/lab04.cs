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

			Console.Write("press start, Finish, step (x y z) : ");
			temp = Console.ReadLine();
			
			string [] num = temp.Split(' ');
			
			first = Convert.ToInt32(num[0]);
			end = Convert.ToInt32(num[1]);
			step = Convert.ToInt32(num[2]);

			Console.WriteLine("numbers");
			for(int i = first; i <= end; i += step)
			{
				sum += i;
				Console.WriteLine(sum);

			}

			Console.WriteLine("sum = {0}", sum);
		}
	}
}


