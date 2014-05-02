using System;
using System.Collections.Generic;
using System.Linq;

class Test{
	static void Shuffle(List<int> l)
	{
		Random r = new Random();
		int rand1 = r.Next(0, 10);
		int rand2 = r.Next(0, 10);

		Swap(l, rand1, rand2);
		
	}

	static void Swap(List<int> ll, int pos1, int pos2)
	{
		int v1 = ll.ElementAt(pos1);
		int v2 = ll.ElementAt(pos2);

		ll.RemoveAt(pos1);
		ll.Insert(pos1, v2);
		ll.RemoveAt(pos2);
		ll.Insert(pos2, v1);
	}


	static void Main()
	{
		List<int> ll = new List<int>();
	
			for(int i = 0; i < 10; i++)
			{
				ll.Add(i);
			}
	
			for(int i = 0; i < 100; i++)
			{
				Shuffle(ll);
			}

			for(int i = 0; i < ll.Count; i++)
			{
				Console.Write(ll.ElementAt(i) + " ");
			}

			Console.WriteLine();
			//foreach(int i in ll)
			//{
			//	Console.Write(ll(i) + " ");
			//}
			

	}
}
