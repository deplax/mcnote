using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
        class Node
        {
	public virtual double cal()
	{
	        return 0;
	}
	public virtual void Print()
	{
	        Console.WriteLine("Node.Print()");
	}
        }
        class ValNode : Node
        {
	public double val;
	public ValNode(double val)
	{
	        Console.WriteLine("Error: Node Call");
	        this.val = val;
	 }
	public override double cal()
	{
	        return val;
	}
	public override void Print()
	{
	        Console.WriteLine("{0}", val);
	}
        }
        class OpNode : Node
        {
	public char op;
	public Node left, right;
	public OpNode(char op)
	{
	        this.op = op;
	        left = null;
	        right = null;
	}
	public override double cal()
	{
	        double lv = left.cal();
	        double rv = right.cal();
	        switch (op)
	        {
		case '*':
		        return lv * rv;
		case '+':
		        return lv + rv;
		default:
		        Console.WriteLine("Error op");
		        return 0;
	        }
	}
	public override void Print()
	{
	        Console.WriteLine("{0}", op);
	        if (left != null)
	        {
		left.Print();
	        }
	        if (right != null)
	        {
		right.Print();
	        }
	}
        }
        class Program
        {
	static void Main(string[] args)
	{
	        OpNode mul = new OpNode('*');
	        mul.left = new ValNode(4);
	        mul.right = new ValNode(2);

	        OpNode plus = new OpNode('+');
	        plus.left = mul;
	        plus.right = new ValNode(3);

	        plus.Print();

	        Console.WriteLine("{0}", plus.cal());
	        Console.WriteLine("{0}", double.Parse("36.4"));

	}
        }
}
