using System;
public class Data
{
	public int id;
	public string name;
	public void Print()
	{
		Console.WriteLine("{0}::{1}", id, name);
	}
}
class Test
{
	static void Main()
	{
		Data a = new Data();
		a.id = 10;
		a.name = "data 1";
		a.Print();
		increaseId(a);
		a.Print();
	}
	static void increaseId(Data d)
	{
		d.id = d.id + 1;
	}
}

