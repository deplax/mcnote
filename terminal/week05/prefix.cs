using System;
class PrefixConvert
{
	public static string[] StrSplit()
	{
		string temp = Console.ReadLine();
		string[] fm = temp.Split(' ');
		return fm;

	}
	
	

	public static void Main(string [] args)
	{
		Console.Write("write fomula : ");
		string[] fm = StrSplit();
	
		int num1 = 0;
		int num2 = 0;
		bool flagf = false;

		for(int i = 0; i < fm.Length; i++)
		{


			switch(fm[i])
			{
				case "+" :
					num1 += num2;
					break;
				case "-" :
					num1 -= num2;
					break;
				case "*" :
					num1 *= num2;
					break;
				case "/" :
					num1 /= num2;
					break;
				default :
				if(flagf == false)
				{
					num1 = Convert.ToInt32(fm[i]);
					flagf = true;
				}else{
					num2 = Convert.ToInt32(fm[i]);
				}
					break;
			}
		}		
		Console.WriteLine(num1);
	}
}

