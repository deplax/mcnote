using System;
using System.Collections.Generic;
using System.Linq;

class Homework01
{
	static void Shuffle(List<int> l)
	{
		Random r = new Random();
		int rand1, rand2;
		for(int i = 0; i < Math.Pow(l.Count, 2); i++)
		{
			rand1 = r.Next(0, l.Count);
			rand2 = r.Next(0, l.Count);
			Swap(l, rand1, rand2);
		}
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
		for(int i = 1; i <= 45; i++)
		{
			ll.Add(i);
		}
		Shuffle(ll);
		for(int i = 0; i < 6; i++)
			Console.Write(ll[i] + " ");
		Console.WriteLine();
	}
}

