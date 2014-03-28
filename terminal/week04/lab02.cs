using System;
namespace next
{
	class lab02
	{
		public static void Main(string [] args)
		{
			int num;
			int rannum;			
			int count = 0;
			string temp;
			
			Random ran = new Random();
			rannum = ran.Next(1, 11);

			//Console.WriteLine(rannum);

			while(true){
			Console.Write("press number(1~10): ");
			temp = Console.ReadLine();
			num = Convert.ToInt32(temp);

				if(num == rannum){
					Console.WriteLine("Good!");
					break;
				}else if(num > rannum){
					Console.WriteLine("to Big!!");
				}else{
					Console.WriteLine("to small!!");
				}
				count++;
			}

			Console.WriteLine(count + 1);

		}
	}
}
