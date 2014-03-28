using System;
namespace next
{
	class lab01
	{
		public static void Main(string [] args)
		{
			string temp;
			int sw = 1;
			int sum = 0;
			int count = 0;
			int num = 0;

			while(sw == 1)
			{
				Console.Write("press number : ", num);
				temp = Console.ReadLine();
				num = Convert.ToInt32(temp);

				if(num == -1){
					sw = 0;
				}else{
					count++;
					sum += num;
				}
				
			}

			Console.WriteLine("Sum = {0} ", sum);
			Console.WriteLine("Avg = {0} ", (double)sum/count);
		}
	}
}
			
