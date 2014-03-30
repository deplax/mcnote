using System;
class chapter05_04
{
	public static void Main(string [] args)
	{
		int sw = 1;
		while(sw == 1)
		{
			int num;
			string temp;

			Console.Write("반복횟수를 입력하세요 : ");
			temp = Console.ReadLine();
			num = Convert.ToInt32(temp);

			if(num <= 0)
			{
				Console.WriteLine("0보다 작거나 같은 수는 입력할 수 없습니다.");
			}else{
				for(int i = 0; i < num; i++)
				{
					for(int j = 0; j < i + 1; j++)
					{
						Console.Write("* ");
					}
					Console.WriteLine();
				}
				sw = 0;
			}
		}
	}
}
