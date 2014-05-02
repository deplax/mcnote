using System;

public class Human
{
	public static int no;
	public int id;
	public string name;
	public void setID()
	{
		id = no;
		no++;
	}
}

class Test
{
	public static void Main()
	{
		Human.no = 1;
		Human h1 = new Human();
		Human h2 = new Human();
		Human h3 = new Human();
		h1.setID();
		h2.setID();
		h3.setID();
		Console.WriteLine(h1.id);
		Console.WriteLine(h2.id);
		Console.WriteLine(h3.id);
	}
}
