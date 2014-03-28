using System;
namespace next
{
	class lab03
	{
		public static void Main(string [] args)
		{
			string temp;
			int num;

			Console.Write("select number : ");
			temp = Console.ReadLine();
			num = Convert.ToInt32(temp);

			for(int i = 1; i < 10; i++){
				Console.WriteLine("{0, -3} X {1, -1} = {2}", num, i, num * i);
			}
		}
	}
}

