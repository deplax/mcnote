using System;
using System.Collections.Generic;
class Program
{
	static void Main()
	{
		LinkedList<string> linked = new LinkedList<string>();
		linked.AddLast("one");
		linked.AddLast("two");
		linked.AddLast("three");
		LinkedListNode<string> node = linked.Find("one");
		linked.AddAfter(node, "inserted");
		foreach (var value in linked)
		{
			Console.WriteLine(value);
		}
	}
}
