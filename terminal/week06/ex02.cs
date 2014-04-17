using System;
class Test
{
	static void Main()
	{
		int[] x = {1 ,2 ,3};
		PrintIntArray(x);
		DoubleArray(x);
		PrintIntArray(x);
	}

	static void PrintIntArray(int[] arr)
	{
		foreach (int i in arr)
			Console.Write("{0} ", i);
		Console.WriteLine("");
	}

	static void DoubleArray(int[] n)
	{
		for (int i = 0; i < n.Length; i++)
			n[i] *= 2;
	}
}
