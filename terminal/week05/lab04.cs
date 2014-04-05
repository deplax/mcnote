using System;
namespace Next
{
	public class Next
	{
		public static int[] ReadInt(string msg)
		{
			
			string [] words = msg.Split(' ');
			
			int [] arr = new int[words.Length];

			for(int i = 0; i < words.Length; i++)
			{
				arr[i] = Convert.ToInt32(words[i]);
			}

			return arr;
		}
	}

	class Lab04
	{
		public static void Main(string [] args)
		{
			int [] arr = Next.ReadInt("10 30 20 403 430 51");
			foreach(int i in arr)
			{
				Console.WriteLine(i);
			}
		}
	}
}
