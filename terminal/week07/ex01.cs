using System;
public class Dog {
	public static int legs;
	public string name;
	public string type;
	public char gender;
	public int age;
	public bool eatable;
	public static void DoubleLag(){
		legs *= 2;
	}
	
}

class test{
	static void Main()
	{
		Dog d1, d2, d3;
		d1 = new Dog();
		d2 = new Dog();

		d1.name = "jiko";
		d2.name = "Woo";
		d2.eatable = true;


		Dog.legs = 4;
		
		Console.WriteLine(d1.name);	
		Dog.DoubleLeg();
		Console.WriteLine(Dog.legs);
	}
}

