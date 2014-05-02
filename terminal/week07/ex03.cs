using System;
using System.Collections.Generic;
using System.Linq;

class Test{
	static void Main()
	{
		List<int> ll = new List<int>();
		for(int i = 0; i < 10; i++)
		{
			int num = int.Parse(Console.ReadLine());
			int max = ll.Count;

			ll.Insert(max/2, num);
		}

		Console.WriteLine();

		foreach(int i in ll)
		{
			Console.WriteLine(i);
		}
	}
}
