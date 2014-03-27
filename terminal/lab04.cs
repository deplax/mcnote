using System;
namespace NEXT{
	class lab4{
		public static void Main(String [] args){
			const int SIZE = 5;
			int[] arr;
			int i, sum = 0;
			arr = new int[SIZE];
		
			string temp;
			i = 0;

			while(i < SIZE){
				Console.Write("num[{0}]? ", i + 1);
				temp = Console.ReadLine();
				arr[i] = Convert.ToInt32(temp);

				sum += arr[i];
				i++;
			}
			
			Console.WriteLine("Sum = {0}", sum);
		}
	}
}
