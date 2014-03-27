using System;
namespace next
{
	class lab02
	{
		public static void Main(string [] args){
	
			string triangleName, text;
			double width, height, area;

			Console.Write("Triangle Name : ");
			triangleName = Console.ReadLine();
			Console.Write("Width Length(cm) : ");
			text = Console.ReadLine();
			width = Convert.ToDouble(text);
			Console.Write("Height Length(cm) : ");
			text = Console.ReadLine();
			height = Convert.ToDouble(text);

			area = (width * height) / 2;

			Console.WriteLine("{0} Triangle area : {1}", triangleName, area);
		}
	}
}

