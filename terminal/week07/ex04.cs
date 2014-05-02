using System;
using System.Collections.Generic;
using System.Linq;

class Test{
	static void Main()
	{
		List<int> ll = new List<int>();
	
		while(true)
		{
			int num = int.Parse(Console.ReadLine());

			if ( ll.IndexOf(num) != -1)
				ll.Remove(num);
			else
				ll.Add(num);

			if(num == -999)
				break;

			for(int i = 0; i < ll.Count; i++)
			{
				Console.Write(ll.ElementAt(i) + " ");
			}
			//foreach(int i in ll)
			//{
			//	Console.Write(ll(i) + " ");
			//}
			Console.WriteLine();
			
		}

	}
}
